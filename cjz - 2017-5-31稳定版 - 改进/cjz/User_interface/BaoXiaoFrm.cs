using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace cjz
{
    public partial class BaoXiaoFrm : Form
    {
        public Form1 mainfrm;
        ImageList largeimagelist ;
        ImageList smallimagelist ;
        travelInfoBLL bll = new travelInfoBLL();
        travelInfo newinfo = new travelInfo();
        float basic_allowance;
        bool modify_flag = false;
        bool listviewitem_selected = false;
        ListViewItem oldlistItem = new ListViewItem();
        string selecteditempath = string.Empty;
        float borrowM = 0;
        string oldfilesname = string.Empty;
        string nowfilepath = string.Empty;
        bool titlechanged = false;
        public BaoXiaoFrm()
        {
            InitializeComponent();
        }
        public BaoXiaoFrm(Form1 frm)
        {
            this.mainfrm = frm;
            InitializeComponent();
        }

        private void BaoXiaoFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainfrm.Show();
            this.Close();
        }

        private void BaoXiaoFrm_Load(object sender, EventArgs e)
        {
            listViewNF1.LargeImageList = largeimagelist = new ImageList();
            listViewNF1.SmallImageList = smallimagelist = new ImageList();
            listViewNF1.LargeImageList.ImageSize = new Size(32, 32);
            listViewNF1.SmallImageList.ImageSize = new Size(16, 16);
            listViewNF1.View = View.Tile;
            string dt = DateTime.Now.Year.ToString();
            string destpath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], dt);
            if (Directory.Exists(destpath))
            {
                //load file
                CommonHelper.loadFile(destpath, this.listViewNF1, this.largeimagelist,this.smallimagelist);
                //load data from textbox;
                //开始时将newinfo初始化，都是0，点击修改的时候newinfo应该是获取这个datagridview选中行的值，当下面选项卡textbox发生任何变化时都会改变这个newinfo的值，当不选中datagridview行时，这个newinfo值为0，为输入新数据做准备。                
                newinfo = GetNewInfo();
                basic_allowance = float.Parse(this.txtAllowanceM.Text.Trim());
                btnFinish.Enabled = true;
                btnGenerateExcel.Enabled = true;
                btnNextOrModify.Enabled = true;
            }
            else
                MessageBox.Show("没有报销文件需要修改或者添加，请添加新的报销文件后再修改！");

        }

        private void listViewNF1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                #region listview双击获取item事件，同时获取路径，名称
                ListViewHitTestInfo info = listViewNF1.HitTest(e.X, e.Y);
                bll = new travelInfoBLL();
                if (info.Item != null)
                {
                    ListViewItem item = info.Item as ListViewItem;
                    selecteditempath = item.Tag.ToString();
                    this.txtTitle.Text =oldfilesname= Path.GetFileNameWithoutExtension(selecteditempath);
                    string tmppath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), "tmp", txtTitle.Text) + ".dat";
                    
                    if (!File.Exists(tmppath))
                    {
                        if (MessageBox.Show("不存在该tmp'文件，是否从excel导入？", "", MessageBoxButtons.OKCancel)== DialogResult.OK)
                        {
                            // bll.serialize_zongjie( bll.getZongJie());
                            bll.excel2ZongJie(selecteditempath);
                            DataGridView_LoadData(bll.getZongJie() ,tmppath);
                            bll.serialize_zongjie(tmppath);
                        }
                        return;
                    }
                    if (oldlistItem != item)
                    {//首先判断是否listview点击同一个项，然后清除datagridview，再反系列化数据，然后清除文本框
                        oldlistItem = item;
                        this.dataGridView1.Rows.Clear();
                        dataGridView_LoadData(tmppath);
                        CleanTextBox();
                        
                    }
                    else
                        MessageBox.Show("您选中的是同一个选项");
                    listviewitem_selected = true;

                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridView_LoadData(ZongJie zj,string tmppath)
        {
            try
            {
                
                zj = bll.getZongJie();
                bll.addTitle(Path.GetFileNameWithoutExtension(tmppath));
                borrowM = bll.getZongJie().jiekuan;
                dataGridView1.Rows.Clear();
                if (zj.list.Count==0)
                {
                    return;
                }
                foreach (travelInfo tv in zj.list)
                {
                    addToGridView(tv);
                }
                SetTotalText(bll.getZongJie());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void SetTotalText(ZongJie zj)
        {
            if (zj!=null)
            {
                this.txtCount.Text = zj.list.Count.ToString();
                this.txtFlightTM.Text = zj.totalfly.ToString();
                this.txtTaxiTM.Text = (zj.totaltaxi + zj.totaltrain).ToString();
                this.txtOtherTM.Text = zj.totalqita.ToString();
                this.txtZhusuTM.Text = zj.totalzhusu.ToString();
                this.txtAllowanceTM.Text= zj.totalbutie.ToString();
                this.txtTotalTM.Text = zj.totalzongshu.ToString();
            }
        }

        //点击excel的时候读取tmp文件夹中的相对应文件。
        private void dataGridView_LoadData(string tmppath)
        {
            try
            {
                this.dataGridView1.Rows.Clear();
                bll.deserialize_zongjie(tmppath);
                ZongJie zj = bll.getZongJie();
                bll.addTitle(Path.GetFileNameWithoutExtension(tmppath));
                borrowM = bll.getZongJie().jiekuan;
                foreach (travelInfo tv in zj.list)
                {
                    addToGridView(tv);
                }
                SetTotalText(zj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #region 从textedit到traveinfo数据的加载，用于存入excel
        private travelInfo LoadEntry()
        {
            try
            {
                travelInfo info = new travelInfo();
                info.dtime = this.dt1.Text;
                info.summary = this.txtSummary.Text;
                info.flyticket = Convert.ToSingle(this.txtSummary.Text);
                info.trainticket = float.Parse(this.txtTrainM.Text);
                info.taxiticket = Convert.ToSingle(this.txtTaxiM.Text);
                float otherM = Convert.ToSingle(this.txtOtherM.Text);
                info.otherpay = info.trainticket > 0 ? (otherM + 100) : otherM;
                info.accomadationpay = Convert.ToSingle(this.txtZhusuM.Text);
                info.allowance = Convert.ToSingle(this.txtAllowanceM.Text);
                info.totalpay = Convert.ToSingle(this.txtTotalM.Text);
                return info;
            }
            catch
            {
                return default(travelInfo);
            }
        }
        #endregion

        private void textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox tedit = sender as TextBox;
                switch (tedit.Name)
                {
                    case "txtFlightM":
                        if (newinfo.flyticket == float.Parse(tedit.Text))
                        {
                            return;
                        }
                        newinfo.totalpay += (float.Parse(tedit.Text) - newinfo.flyticket);
                        if (modify_flag)
                        {
                            dataGridView1.SelectedRows[0].Cells[2].Value = float.Parse(tedit.Text.Trim());
                        }

                        this.txtTotalM.Text = newinfo.totalpay.ToString();
                        newinfo.flyticket = float.Parse(tedit.Text);
                        break;
                    case "txtTrainM":
                        //==0 or ==number
                        if (newinfo.trainticket == float.Parse(tedit.Text))
                        {
                            return;
                        }
                        if (modify_flag)
                        {
                            dataGridView1.SelectedRows[0].Cells[3].Value = Convert.ToSingle(dataGridView1.SelectedRows[0].Cells[3].Value) + float.Parse(tedit.Text.Trim());
                        }
                        //before=0
                        if (newinfo.trainticket == 0)
                        {
                            newinfo.otherpay += 100;
                            newinfo.totalpay += +100;
                        }
                        //now=0
                        if (float.Parse(tedit.Text.Trim()) == 0)
                        {
                            newinfo.otherpay -= 100;
                            newinfo.totalpay -= (newinfo.trainticket + 100);
                        }
                        //now>0
                        if (float.Parse(tedit.Text.Trim()) > 0)
                        {
                            newinfo.totalpay += (float.Parse(tedit.Text) - newinfo.trainticket);
                        }
                        this.txtTotalM.Text = newinfo.totalpay.ToString();
                        this.txtOtherM.Text = newinfo.otherpay.ToString();
                        newinfo.trainticket = float.Parse(tedit.Text);
                        break;
                    case "txtOtherM":
                        if (newinfo.otherpay == float.Parse(tedit.Text))
                        {
                            return;
                        }
                        if (modify_flag)
                        {
                            dataGridView1.SelectedRows[0].Cells[4].Value = float.Parse(tedit.Text.Trim());
                        }
                        newinfo.totalpay += (float.Parse(tedit.Text) - newinfo.otherpay);
                        this.txtTotalM.Text = newinfo.totalpay.ToString();
                        newinfo.otherpay = float.Parse(tedit.Text);
                        break;
                    case "txtTaxiM":
                        if (newinfo.taxiticket == float.Parse(tedit.Text))
                        {
                            return;
                        }
                        if (modify_flag)
                        {
                            dataGridView1.SelectedRows[0].Cells[3].Value = float.Parse(tedit.Text.Trim());
                        }
                        newinfo.totalpay += (float.Parse(tedit.Text) - newinfo.taxiticket);
                        this.txtTotalM.Text = newinfo.totalpay.ToString();
                        newinfo.taxiticket = float.Parse(tedit.Text);
                        break;
                    case "txtZhusuM":
                        if (newinfo.accomadationpay == float.Parse(tedit.Text))
                        {
                            return;
                        }
                        if (modify_flag)
                        {
                            dataGridView1.SelectedRows[0].Cells[5].Value = float.Parse(tedit.Text.Trim());
                        }
                        this.txtAllowanceM.Text = (basic_allowance - float.Parse(tedit.Text.Trim())).ToString();
                        float total = newinfo.totalpay - newinfo.allowance - newinfo.accomadationpay + float.Parse(this.txtAllowanceM.Text.Trim()) + float.Parse(this.txtZhusuM.Text.Trim());
                        newinfo.totalpay = total;
                        newinfo.allowance = basic_allowance - float.Parse(tedit.Text);
                        this.txtAllowanceM.Text = newinfo.allowance.ToString();
                        this.txtTotalM.Text = newinfo.totalpay.ToString();
                        newinfo.accomadationpay = float.Parse(tedit.Text);
                        break;
                    case "txtAllowanceM":
                        if (newinfo.allowance == float.Parse(tedit.Text))
                        {
                            return;
                        }
                        if (modify_flag)
                        {
                            dataGridView1.SelectedRows[0].Cells[6].Value = float.Parse(tedit.Text.Trim());
                        }
                        float total1 = newinfo.totalpay - newinfo.allowance - newinfo.accomadationpay + float.Parse(this.txtAllowanceM.Text.Trim()) + float.Parse(this.txtZhusuM.Text.Trim());
                        newinfo.totalpay = total1;
                        newinfo.allowance = float.Parse(tedit.Text);
                        this.txtTotalM.Text = newinfo.totalpay.ToString();
                        newinfo.allowance = float.Parse(tedit.Text);
                        break;
                    case "txtBorrowM":
                        if (modify_flag)
                        {
                            bll.getZongJie().jiekuan = float.Parse(tedit.Text.Trim());
                        }
                        break;
                    case "txtSummary":
                        if (modify_flag)
                        {
                            dataGridView1.SelectedRows[0].Cells[1].Value = tedit.Text.Trim();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 用来记录新添加的数值变化前的数值，为中间变量
        /// </summary>
        private travelInfo GetNewInfo()
        {
            try
            {
                travelInfo newinfo = new travelInfo();
                newinfo.dtime = this.dt1.Text;
                newinfo.summary = this.txtSummary.Text.Trim();
                newinfo.flyticket = float.Parse(this.txtFlightM.Text.Trim());
                newinfo.Ppayfly = this.checkBox1.Checked;
                newinfo.trainticket = float.Parse(this.txtTrainM.Text.Trim());
                newinfo.taxiticket = float.Parse(this.txtTaxiM.Text.Trim());
                newinfo.otherpay = float.Parse(this.txtOtherM.Text.Trim());
                newinfo.accomadationpay = float.Parse(this.txtZhusuM.Text.Trim());
                newinfo.allowance = float.Parse(this.txtAllowanceM.Text.Trim());
                newinfo.totalpay = float.Parse(this.txtTotalM.Text.Trim());
                return newinfo;
            }
            catch
            {
                return null; ;
            }
        }
        //下一步
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listviewitem_selected == false)
            {
                MessageBox.Show("请先选择所要编辑的文件");
                return;
            }
            if (modify_flag == false)
            {
                
                if (this.txtSummary.Text == "")
                {
                    return;
                }
                newinfo = GetNewInfo();
                bll.AddNew(newinfo);
                SetTotalText(bll.getZongJie());
                //newinfo to datagridview
                addToGridView(newinfo);
                bll.addBorrowM(this.txtBorrowM.Text.Trim());
                btnFinish.Enabled = true;
                CleanTextBox();
                this.dt1.Text=this.dt1.Value.AddDays(1).ToString();
                //save newinfo to bll

                //last step
                newinfo = GetNewInfo();
            }
            else
            {
                //modify  
                //修改，先将标志改为false，然后获取要更改的位置，替换zongjie中list的值，再检查借款是否需要修改，清空textbox，将最大日期+1天
                
                modify_flag = false;
                int index = this.dataGridView1.CurrentRow.Index;
                if (index < 0)
                {
                    return;
                }
                newinfo = GetNewInfo();
                bll.ModifyData(newinfo,index);
                this.btnNextOrModify.Text = "下一步";
                if (float.Parse(this.txtBorrowM.Text.Trim()) != 0)
                {
                    bll.addBorrowM(this.txtBorrowM.Text.Trim());
                }
                CleanTextBox();
                dt1.Text = dt1.Value.AddDays(1).ToString();
                if (dt1.Value<Convert.ToDateTime( this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[0].Value))
                {
                    int mindex = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows[mindex].Selected = false;
                    dataGridView1.Rows[mindex + 1].Selected = true;
                    //
                    this.dt1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    this.txtSummary.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    this.txtFlightM.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    this.txtTrainM.Text = "0.0";
                    this.txtTaxiM.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    this.txtOtherM.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    this.txtZhusuM.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    this.txtAllowanceM.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    this.txtTotalM.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    this.btnNextOrModify.Text = "修改";
                    this.groupBox1.Text = "数据修改";
                    modify_flag = true;
                }
                modifyDatagridView(newinfo);
                SetTotalText(bll.getZongJie());


            }

        }

        private void modifyDatagridView(travelInfo newinfo)
        {
            dataGridView1.CurrentRow.Cells[0].Value = newinfo.dtime;
            dataGridView1.CurrentRow.Cells[1].Value = newinfo.summary;
            dataGridView1.CurrentRow.Cells[2].Value = (newinfo.flyticket + newinfo.trainticket).ToString();
            dataGridView1.CurrentRow.Cells[3].Value = newinfo.taxiticket.ToString();
            dataGridView1.CurrentRow.Cells[4].Value = newinfo.otherpay.ToString();
            dataGridView1.CurrentRow.Cells[5].Value = newinfo.accomadationpay.ToString();
            dataGridView1.CurrentRow.Cells[6].Value = newinfo.allowance.ToString();
            dataGridView1.CurrentRow.Cells[7].Value = newinfo.totalpay.ToString();
        }

        //清空在这几个情况下作，下一步时情况，刚打开文件的时候，
        private void CleanTextBox()
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                dt1.Text = DateTime.Now.ToString();
            }
            //else
            //    dt1.Text = (Convert.ToDateTime(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value)).AddDays(1).ToString();

            txtFlightM.Text = "0.0";
            txtTrainM.Text = "0.0";
            //txtSummary.Text = "";
            txtTaxiM.Text = "0.0";
            txtOtherM.Text = "0.0";
            txtBorrowM.Text = bll.getZongJie().jiekuan.ToString();
            txtTotalM.Text = (float.Parse(txtZhusuM.Text.Trim()) + float.Parse(txtAllowanceM.Text.Trim())).ToString();
        }

        //加入到datagridview中
        private void addToGridView(travelInfo newinfo)
        {
            try
            {
                DataGridViewRow drow = new DataGridViewRow();
                //int index = dataGridView1.Rows.Add(drow);
                //dataGridView1.Rows[index].Cells[0].Value= newinfo.dtime;
                //dataGridView1.Rows[index].Cells[1].Value = newinfo.summary;
                //dataGridView1.Rows[index].Cells[2].Value = (newinfo.flyticket + newinfo.trainticket).ToString();
                //dataGridView1.Rows[index].Cells[3].Value = newinfo.taxiticket.ToString();
                //dataGridView1.Rows[index].Cells[4].Value = newinfo.otherpay.ToString();
                //dataGridView1.Rows[index].Cells[5].Value = newinfo.accomadationpay.ToString();
                //dataGridView1.Rows[index].Cells[6].Value = newinfo.allowance.ToString();
                //dataGridView1.Rows[index].Cells[7].Value = newinfo.totalpay.ToString();
                DataGridViewTextBoxCell[] textcell = new DataGridViewTextBoxCell[8];
                for (int i = 0; i < 8; i++)
                {
                    textcell[i] = new DataGridViewTextBoxCell();
                }
                textcell[1].Value = newinfo.summary;
                textcell[0].Value = newinfo.dtime;
                textcell[2].Value = (newinfo.flyticket + newinfo.trainticket).ToString();
                textcell[3].Value = newinfo.taxiticket.ToString();
                textcell[4].Value = newinfo.otherpay.ToString();
                textcell[5].Value = newinfo.accomadationpay.ToString();
                textcell[6].Value = newinfo.allowance.ToString();
                textcell[7].Value = newinfo.totalpay.ToString();
                drow.Cells.AddRange(textcell);
                dataGridView1.Rows.Add(drow);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //完成按钮，生成dat文件
        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                //改了标题
                if (oldfilesname!=string.Empty && oldfilesname!=this.txtTitle.Text.Trim())
                {
                    //删掉老的file 和老的excel文件
                    string tmpPath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), "tmp", oldfilesname) + ".dat";
                    File.Delete(tmpPath);                    

                    tmpPath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), oldfilesname) + ".xlsx";
                    nowfilepath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), this.txtTitle.Text.Trim()) + ".xlsx";
                    titlechanged = true;
                    File.Delete(tmpPath);

                    MessageBox.Show("标题已经改变，因此删除了老的dat文件和老的excel报销文件");
                    //生成新的dat文件
                    tmpPath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), "tmp", this.txtTitle.Text.Trim()) + ".dat";
                    bll.serialize_zongjie(tmpPath);
                    MessageBox.Show("新dat文件生成正常");
                    //生成新的excel文件
                    File.Copy(System.Configuration.ConfigurationManager.AppSettings["excel_module"], nowfilepath);
                    //刷新listview
                    string dt = DateTime.Now.Year.ToString();
                    string destpath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], dt);
                    if (Directory.Exists(destpath))
                    {
                        this.listViewNF1.Items.Clear();
                        //load file
                        CommonHelper.loadFile(destpath, this.listViewNF1, this.largeimagelist, this.smallimagelist);
                    }
                }
                else
                {
                    //未改标题
                    if (this.listviewitem_selected == false)
                    {
                        //未选中，则需要重选，否则没有办法保存
                        MessageBox.Show("请选中所要保存的文件项");
                    }
                    else
                    {
                        if (this.dataGridView1.Rows.Count > 0)
                        {
                            string tmpPath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), "tmp", this.txtTitle.Text) + ".dat";
                            //save bll.list to tmp file
                            bll.serialize_zongjie(tmpPath);
                            MessageBox.Show("写入dat文件完成");
                        }
                        else
                            MessageBox.Show("没有数据输入");

                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //生成excel
        [DllImport("kernel32.dll")]
        public static extern IntPtr _lopen(string lpPathName, int iReadWrite);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        public const int OF_READWRITE = 2;
        public const int OF_SHARE_DENY_NONE = 0x40;
        public readonly IntPtr HFILE_ERROR = new IntPtr(-1);

        //生成excel
        private void btnGenerateExcel_Click(object sender, EventArgs e)
        {

            try
            {
                //标题改变了， 删除了老的excel文件，重新生成新的excel，此时在listview中没有excel，只能用nowfilespath来确定路径，生成excel
                //判断是否标题改变，改变则直接使用nowtitlepath，否则使用现有的listview的path生成excel
                string destPath;
                if (titlechanged)
                {
                    destPath = nowfilepath;
                }
                else
                {
                    if (this.listviewitem_selected == false)
                    {
                        MessageBox.Show("未选中需要生成excel的文件！！！");
                        return;
                    }
                    destPath = this.listViewNF1.SelectedItems[0].Tag.ToString();
                }
               
                string tmpPath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), "tmp", this.txtTitle.Text) + ".dat";
               
                
                bll.deserialize_zongjie(tmpPath);
                bll.ZongJie2Excel(destPath, 8);
                MessageBox.Show("生成excel成功");
                IntPtr vHandle = _lopen(destPath, OF_READWRITE | OF_SHARE_DENY_NONE);
                if (vHandle == HFILE_ERROR)
                {
                    MessageBox.Show("文件被占用！");
                    return;
                }
                //Process process = new Process();
                //process.StartInfo.FileName = destPath;
                //process.StartInfo.Arguments = "";
                //process.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (GetRowIndexAt(e.Y) == -1)
            {
                CleanTextBox();
                newinfo = GetNewInfo();
                this.btnNextOrModify.Text = "下一个";
                this.groupBox1.Text = "数据添加";
                if (this.dataGridView1.Rows.Count<=0)
                {
                    this.dt1.Text = DateTime.Now.ToShortDateString();
                }
                else
                {
                    DateTime dt = Convert.ToDateTime(bll.getZongJie().list[bll.getZongJie().list.Count - 1].dtime);
                    this.dt1.Text = dt.Date.AddDays(1).ToString();
                }                
                modify_flag = false;
                return;
            }
            this.dt1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.txtSummary.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.txtFlightM.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.txtTrainM.Text = "0.0";
            this.txtTaxiM.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.txtOtherM.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            this.txtZhusuM.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            this.txtAllowanceM.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            this.txtTotalM.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            this.btnNextOrModify.Text = "修改";
            this.groupBox1.Text = "数据修改";
            newinfo = GetNewInfo();
            modify_flag = true;
        }
        public int GetRowIndexAt(int mouseLocation_Y)
        {
            if (dataGridView1.FirstDisplayedScrollingRowIndex < 0)
            {
                return -1;
            }
            if (dataGridView1.ColumnHeadersVisible == true && mouseLocation_Y <= dataGridView1.ColumnHeadersHeight)
            {
                return -1;
            }
            int index = dataGridView1.FirstDisplayedScrollingRowIndex;
            int displayedCount = dataGridView1.DisplayedRowCount(true);
            for (int k = 1; k <= displayedCount;)
            {
                if (dataGridView1.Rows[index].Visible == true)
                {
                    Rectangle rect = dataGridView1.GetRowDisplayRectangle(index, true);  // 取该区域的显示部分区域   
                    if (rect.Top <= mouseLocation_Y && mouseLocation_Y < rect.Bottom)
                    {
                        return index;
                    }
                    k++;
                }
                index++;
            }
            return -1;
        }

        private void txtTotalM_TextChanged(object sender, EventArgs e)
        {
            if (modify_flag)
            {
                dataGridView1.SelectedRows[0].Cells[7].Value = float.Parse(this.txtTotalM.Text.Trim());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // CommonHelper.InvokeCmd("calc.exe");
            Process process = new Process();
            process.StartInfo.FileName = "calc.exe";
            process.StartInfo.Arguments = "";
            process.Start();
            LogHelper.log("计算器启动！");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ListViewItem item =this.listViewNF1.SelectedItems[0];
            selecteditempath = item.Tag.ToString();            
            string tmppath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], DateTime.Now.Year.ToString(), "tmp", txtTitle.Text) + ".dat";
            if (File.Exists(tmppath))
            {
                File.Delete(tmppath);
                MessageBox.Show("delete 文件成功");
            }
            bll = new travelInfoBLL();
            bll.excel2ZongJie(selecteditempath);                    
            bll.serialize_zongjie(tmppath);
            MessageBox.Show(item.Text+" dat文件创建成功！");
            LogHelper.log(item.Text+" dat文件创建成功!");
            dataGridView_LoadData(tmppath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string destPath = this.listViewNF1.SelectedItems[0].Tag.ToString();
            Process process = new Process();
            process.StartInfo.FileName = destPath;
            process.StartInfo.Arguments = "";
            process.Start();
            LogHelper.log(this.listViewNF1.SelectedItems[0].Text + "excel文件启动！");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.listViewNF1.Columns.Add("名称", 600, HorizontalAlignment.Left);
            //this.listView1.Columns.Add("访问时间", 600, HorizontalAlignment.Left);
            this.listViewNF1.View = View.Details;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.listViewNF1.View = View.LargeIcon;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.listViewNF1.View = View.SmallIcon;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.listViewNF1.View = View.Tile;
        }

        private void tsb_Fresh_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.Year.ToString();
            string destpath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], dt);
            if (Directory.Exists(destpath))
            {
                this.listViewNF1.Items.Clear();
                //load file
                CommonHelper.loadFile(destpath, this.listViewNF1, this.largeimagelist, this.smallimagelist);
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTitle.Text.Trim()!=string.Empty && bll.getZongJie().title!= this.txtTitle.Text.Trim())
            {
                //标题改变了，
               // oldfilesname = this.txtTitle.Text.Trim();
              //  bll.getZongJie().title = this.txtTitle.Text.Trim();
            }
        }
        //打开excel
        private void btn_openExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string destPath;
                if (titlechanged)
                {
                    destPath = nowfilepath;
                    titlechanged = false;
                }
                else
                {
                    destPath = this.listViewNF1.SelectedItems[0].Tag.ToString();
                }

                Process process = new Process();
                process.StartInfo.FileName = destPath;
                process.StartInfo.Arguments = "";
                process.Start();
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }

        private void listViewNF1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem info = listViewNF1.GetItemAt(e.X, e.Y);
                if (info!= null)
                {
                    Point pt = this.PointToClient(listViewNF1.PointToScreen(new Point(e.X,e.Y+80)));
                    contextMenuStrip1.Show(pt);
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewNF1.SelectedItems.Count > 0)
            {
                string destdirpath = listViewNF1.Tag.ToString();
                string destpath, tmpdestpath;
                int ncount = listViewNF1.CheckedItems.Count;

                ListViewItem item = listViewNF1.SelectedItems[0];
                tmpdestpath = Path.Combine(destdirpath, "tmp", Path.GetFileNameWithoutExtension(item.Text)) + ".dat";
                destpath = Path.Combine(destdirpath, item.Text);
                // CommonHelper.InvokeCmd("move " + sourcepath + " " + destpath);           
                //File.Move(tmpsourchpath, tmpdestpath);
                //File.Delete()
                File.Delete(destpath);
                if (File.Exists(tmpdestpath))
                {
                    File.Delete(tmpdestpath);
                }
                tsb_Fresh_Click(sender, e);
            }
        }

        private void 报销完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将文件从待报销放入到已报销文件夹中，删除掉dat文件。
            if (listViewNF1.SelectedItems.Count > 0)
            {
                string destdirpath = listViewNF1.Tag.ToString();
                string destpath, tmpdestpath,sourcepath;
                int ncount = listViewNF1.CheckedItems.Count;

                ListViewItem item = listViewNF1.SelectedItems[0];
                tmpdestpath = Path.Combine(destdirpath, "tmp", Path.GetFileNameWithoutExtension(item.Text)) + ".dat";
                destpath = Path.Combine(destdirpath, item.Text);
                sourcepath = destpath.Replace("待报销", "出差已报销");
                // CommonHelper.InvokeCmd("move " + sourcepath + " " + destpath);           
                //File.Move(tmpsourchpath, tmpdestpath);
                //File.Delete()
                File.Move(destpath,sourcepath);
                if (File.Exists(tmpdestpath))
                {
                    File.Delete(tmpdestpath);
                }
                LogHelper.log(item.Text+" 报销文件完成！");
                //刷新listview
                tsb_Fresh_Click(sender, e);
            }
        }
    }
}
