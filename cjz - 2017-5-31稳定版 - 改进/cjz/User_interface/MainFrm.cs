using cjz.User_interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace cjz
{
    public partial class MainFrm : Form
    {
        

        public MainFrm() 
        {
            InitializeComponent();
            
        }
        public void button_pressDown(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton tsbtn = sender as ToolStripButton;
                Form frm = null;
                switch (tsbtn.Name)
                {
                    case "tsbtn_Create":
                        frm = GetFrmFromPanel("newpj");
                        frm.Dock = DockStyle.None;
                        break;
                    case "tsbtn_EditBX":
                        frm = GetFrmFromPanel("bxfrm");
                        break;
                    case "tsbtn_SearchJobNo":
                        frm = GetFrmFromPanel("jobno");
                        frm.Dock = DockStyle.None;
                        break;
                    case "tsbtn_BXFinish":
                        frm = GetFrmFromPanel("fbx");
                        frm.Dock = DockStyle.None;
                        break;
                    case "tsbtn_ShowPj":
                        frm = GetFrmFromPanel("browserfrm");
                        break;
                    case "tsbn_SearchCMPPJ":
                        frm = GetFrmFromPanel("CmpPJFrm");
                        frm.Dock = DockStyle.None;
                        break;
                    case "tsbn_Record":
                        frm = GetFrmFromPanel("Frecord");
                        frm.Dock = DockStyle.None;
                        break;
                    case "tsbn_SystemSetup":
                        frm = GetFrmFromPanel("SystemManager");
                        frm.Dock = DockStyle.None;
                        break;
                    case "tsbn_app":
                        frm = GetFrmFromPanel("FAppForm");
                        frm.Dock = DockStyle.None;
                        break;
                    default:
                        break;
                }
                LogHelper.log(frm.Text + "启动！");
                foreach (Control item in FrmPanel.Controls)
                {
                    Form f = item as Form;
                    f.Hide();
                }
                //this.FrmPanel.Controls.Clear();               
                frm.Show();
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LogHelper.logFileName = Application.StartupPath + @"\database\history.log";
            loadPanel();
        }
        private Form GetFrmFromPanel(string name)
        {
            Form frm = null;
            frm = FrmPanel.Controls[name] as Form;
            return frm;
        }
        private void loadPanel()
        {
            try
            {
                Form[] frm = new Form[9];

                frm[0] = new NewProjectFolder();
                frm[0].Name = "newpj";                

                frm[1] = new BaoXiaoFrm();
                frm[1].Name = "bxfrm";

                frm[2] = new FCompleteBaoxiao();
                frm[2].Name = "fbx";

                frm[3] = new ScholzFrm();
                frm[3].Name = "jobno";

                frm[4] = new browserFrm();
                frm[4].Name = "browserfrm";

                frm[5] = new CmpPJFrm();
                frm[5].Name = "CmpPJFrm";

                frm[6] = new Frecord();
                frm[6].Name = "Frecord";

                frm[7] = new SystemManager();
                frm[7].Name = "SystemManager";

                
                frm[8] = new FAppForm();
                frm[8].Name = "FAppForm";
                for (int i = 0; i < 9; i++)
                {
                    frm[i].TopLevel = false;
                    frm[i].Dock = DockStyle.Fill;
                }
                FrmPanel.Controls.AddRange(frm);
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
                
            }
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Maximized;
                //foreach (Form item in FrmPanel.Controls)
                //{
                //    item.WindowState = FormWindowState.Maximized;
                //}
                ;
                this.notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
    }
}
