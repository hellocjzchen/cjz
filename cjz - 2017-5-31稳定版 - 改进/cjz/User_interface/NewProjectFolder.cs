using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
namespace cjz
{
    public partial class NewProjectFolder : Form
    {
        public Form1 mainfrm;
        public NewProjectFolder()
        {
            InitializeComponent();
        }
        public NewProjectFolder(Form1 frm)
        {
            mainfrm = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text != null)
                {
                    int index = comboBox1.SelectedIndex;
                    string destpath = string.Empty;
                    switch (index)
                    {
                        case 0:
                            destpath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["normal_project_path"], this.textBox1.Text);
                            MessageBox.Show(comboBox1.Text);
                            break;
                        case 1:
                            destpath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["scholz_project_path"], this.textBox1.Text);
                            MessageBox.Show(comboBox1.Text);
                            break;
                        default:
                            break;
                    }
                    string sourcePath = System.Configuration.ConfigurationManager.AppSettings["project_module"];
                    CommonHelper.CopyFolder(sourcePath, destpath);
                }
            }
            catch (Exception)
            {
            }           
        }

        private void NewProjectFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainfrm.Show();
        }

        private void NewProjectFolder_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string dt = DateTime.Now.Year.ToString();
                string destpath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"], dt);
                string tmppath;
                if (txtExcelName.Text != "")
                {
                    if (!Directory.Exists(destpath))
                    {
                        Directory.CreateDirectory(destpath);
                        tmppath = Path.Combine(destpath, "tmp");
                        Directory.CreateDirectory(tmppath);
                    }
                    else
                    {
                        tmppath = Path.Combine(destpath, "tmp", this.txtExcelName.Text.Trim()) + ".dat";
                        destpath = Path.Combine(destpath, this.txtExcelName.Text.Trim()) + ".xlsx";
                        File.Copy(System.Configuration.ConfigurationManager.AppSettings["excel_module"], destpath);
                        using (File.Create(tmppath))
                        {
                        }                       
                        this.txtExcelName.Clear();
                        
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
