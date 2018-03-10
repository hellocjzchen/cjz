using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace cjz
{
    public partial class CmpPJFrm : Form
    {
        CmpProjectBLL bll = new CmpProjectBLL();
        CmpProject cmppj = new CmpProject();
        int index = 0;  //所选中的行
        public CmpPJFrm()
        {
            InitializeComponent();
        }
        //导入excel
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = System.Configuration.ConfigurationManager.AppSettings["cmpprojectfile"];
                List<CmpProject> list = bll.LoadExcel2Datatable(filePath);
                bll.EmptyDatabaseTable();
                bll.InsertMemberlist(list);
                SetDataGridViewDataSourse(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SetDataGridViewDataSourse(List<CmpProject> list)
        {
            try
            {
                IList<CmpProject> mlist = (IList<CmpProject>)this.dataGridView1.DataSource;
                if (mlist!=null)
                {
                    mlist.RemoveAt(dataGridView1.CurrentRow.Index);
                }                
                dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmpPJFrm_Load(object sender, EventArgs e)
        {            
            List<CmpProject> list = bll.GetMemberList();
            dataGridView1.AutoGenerateColumns = false;
            LoadDataToDatagridView(list);
        }

        private void LoadDataToDatagridView(List<CmpProject> list)
        {
            
            this.dataGridView1.DataSource = list;
            List<string> customerlist = bll.Getcustomer();
            List<string> supplierlist = bll.GetSupplier();
            List<string> pjGMlist = bll.GetpjManager();
            cmb_Customer.DataSource = customerlist;
            cmb_Customer.DisplayMember = "mcustomer";
            cmb_supplier.DataSource = supplierlist;
            cmb_supplier.DisplayMember = "mSupplier";
            cmb_pjManager.DataSource = pjGMlist;
            cmb_pjManager.DisplayMember = "pjManager";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (GetRowIndexAt(e.Y) == -1)
            {
                CleanTextBox();
                this.btn_mdy_add.Text = "添加";
                return;
            }
            LoadDataFromDataGridView();
            this.btn_mdy_add.Text = "修改";

        }

        private void LoadDataFromDataGridView()
        {
            index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            this.txt_Projectid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.txt_pjcustomer.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.txt_pjsupplier.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.dtpicker.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_pjdiscription.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_pjmanager.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txt_pjnote.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txt_pjstatus.Text= dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            lbl_pjid.Text = index.ToString();
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
        private void CleanTextBox()
        {
            index= dataGridView1.Rows.Count + 1;
            this.txt_Projectid.Text = GetProjectID();
            this.txt_pjcustomer.Text = "";
            this.txt_pjsupplier.Text = "";
            this.dtpicker.Text =DateTime.Now.ToShortTimeString();
            txt_pjdiscription.Text = "";
            txt_pjmanager.Text = "";
            txt_pjnote.Text = "";
            txt_pjstatus.Text = "";
            lbl_pjid.Text = index.ToString();
        }
        private string GetProjectID()
        {
            try
            {
                int count = dataGridView1.Rows.Count;
                string oldpjid = dataGridView1.Rows[count - 1].Cells[1].Value.ToString();
                string stryear = oldpjid.Substring(2, 4);
                int year = int.Parse(stryear);
                string newid = "GH";
                if (year != DateTime.Now.Year)
                {
                    newid = newid + DateTime.Now.Year.ToString() + "001";
                }
                else
                {
                    newid = oldpjid.Substring(0, 6) + (int.Parse(oldpjid.Substring(6, 3)) + 1).ToString();
                }
                return newid;
            }
            catch
            {
                return string.Empty;
                
            }
        }

        private void btn_mdy_add_Click(object sender, EventArgs e)
        {
            LoadData();
            if (this.btn_mdy_add.Text == "添加")
            {
                if (txt_pjcustomer.Text == string.Empty || txt_pjdiscription.Text == string.Empty || txt_pjmanager.Text == string.Empty || txt_pjsupplier.Text == string.Empty || txt_pjdiscription.Text == string.Empty )
                {
                    return;
                }

                bll.InsertMemberInfo(cmppj);
            }
            else
            {
                bll.ModifyMemberInfobyid(cmppj, int.Parse(this.lbl_pjid.Text));
            }
        }

        private void LoadData()
        {
            cmppj = new CmpProject();
            cmppj.ProjectID = txt_Projectid.Text;
            cmppj.customer = txt_pjcustomer.Text;
            cmppj.Supplier = txt_pjsupplier.Text;
            cmppj.CreateDate = dtpicker.Text;
            cmppj.pjDiscription = txt_pjdiscription.Text;
            cmppj.pjManager = txt_pjmanager.Text;
            cmppj.note = txt_pjnote.Text;
            cmppj.pjStatus = txt_pjstatus.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guest = this.cmb_Customer.Text;
            List<CmpProject> pjlist= bll.GetMemberListByCustomer(guest);
            LoadDataToDatagridView(pjlist);
        }

        private void btn_searchall_Click(object sender, EventArgs e)
        {
            LoadDataToDatagridView(bll.GetMemberList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string supplier = this.cmb_supplier.Text;
            List<CmpProject> pjlist = bll.GetMemberListBySupplier(supplier);
            LoadDataToDatagridView(pjlist);
        }

        private void btn_searchbyGM_Click(object sender, EventArgs e)
        {
            string gm = this.cmb_pjManager.Text;
            List<CmpProject> pjlist = bll.GetMemberListByPjManager(gm);
            LoadDataToDatagridView(pjlist);
        }

        private void btn_unionSearch_Click(object sender, EventArgs e)
        {
            string guest = this.cmb_Customer.Text;
            string supp = this.cmb_supplier.Text;
            string pjGm = this.cmb_pjManager.Text;
            List<CmpProject> pjlist = bll.GetMemberlistByUnionSearch(guest, supp, pjGm);
            LoadDataToDatagridView(pjlist);
        }
    }
}
