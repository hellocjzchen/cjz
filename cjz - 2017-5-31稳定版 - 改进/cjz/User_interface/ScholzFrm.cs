using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cjz
{
    public partial class ScholzFrm : Form
    {
        Form1 mainform;
        ScholzJobNo scholzJobno;
        ScholzJobNoBLL bll = new ScholzJobNoBLL();       
        int index = 0;
        public ScholzFrm()
        {
            InitializeComponent();
        }
        public ScholzFrm(Form1 frm)
        {
            mainform = frm;
            InitializeComponent();
            List<ScholzJobNo> list = bll.GetMemberList();
        }

        private void ScholzFrm_Load(object sender, EventArgs e)
        {
            List<ScholzJobNo> list = bll.GetMemberList();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = list;
            //
            List<string> usrlist = bll.GetUserName();
            usrlist.Add("所有");
            cmbuser.DataSource = usrlist;
            cmbuser.DisplayMember = "userName";
        }

        private void ScholzFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainform.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (GetRowIndexAt(e.Y) == -1)
            {
                CleanTextBox();                
                this.btnAddorMdy.Text = "添加";
                
                return;
            }
            LoadDataFromDataGridView();
           
            this.btnAddorMdy.Text = "修改";
            
        }

        private void LoadDataFromDataGridView()
        {
            index=Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value);
            txtUser.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtJobNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtSignY.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtD.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtL.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtP.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtT.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            label_id.Text = index.ToString();
        }

        private void CleanTextBox()
        {
            txtUser.Text = "";
            txtJobNo.Text = "";
            txtSignY.Text = DateTime.Now.Year.ToString();
            txtD.Text = "";
            txtL.Text = "";
            txtP.Text = "";
            txtT.Text = "";
            label_id.Text = "";

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
        private void LoadData()
        {
            scholzJobno = new ScholzJobNo();
            scholzJobno.userName = txtUser.Text.Trim();
            scholzJobno.jobNo = txtJobNo.Text.Trim();
            scholzJobno.SignYear = txtSignY.Text.Trim();
            scholzJobno.Dvalid = txtD.Text.Trim();
            scholzJobno.Lvalid = txtL.Text.Trim();
            scholzJobno.PressureMax = txtP.Text.Trim();
            scholzJobno.TempMax = txtT.Text.Trim();
            scholzJobno.DelFlag = false;
            scholzJobno.id = int.Parse(this.label_id.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = cmbuser.Text;
            List<ScholzJobNo> list = null;
            if (username != "所有")
            {
                list = bll.GetMemberListByUserName(username);
            }
            else
                list = bll.GetMemberList();
            
            IList<ScholzJobNo> mlist = (IList<ScholzJobNo>)dataGridView1.DataSource;
            mlist.RemoveAt(dataGridView1.CurrentRow.Index);
            dataGridView1.DataSource = null;        
            this.dataGridView1.DataSource = list;
        }

        private void btnAddorMdy_Click(object sender, EventArgs e)
        {
            
            if (this.btnAddorMdy.Text=="添加")
            {
                if (txtUser.Text == string.Empty || txtJobNo.Text == string.Empty || txtSignY.Text == string.Empty || txtD.Text == string.Empty || txtL.Text == string.Empty || txtP.Text == string.Empty || txtT.Text == string.Empty)
                {
                    return;
                }
                LoadData();
                bll.InsertMemberInfo(scholzJobno);
            }
            else
            {
                LoadData();
                bll.ModifyMemberInfobyid(scholzJobno, int.Parse(this.label_id.Text));
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["cmpScholzJobNoFile"];
            List<ScholzJobNo> jblist= bll.LoadExcel2Datatable(filePath);
            bll.EmptyDatabaseTable();
            bll.InsertMemberlist(jblist);
            SetDataGridViewDataSourse(jblist);
        }

        private void SetDataGridViewDataSourse(object list)
        {
            try
            {
                IList<ScholzJobNo> mlist = (IList<ScholzJobNo>)this.dataGridView1.DataSource;
                if (mlist != null)
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
    }
}
