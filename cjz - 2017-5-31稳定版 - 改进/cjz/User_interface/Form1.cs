using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cjz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //创建项目
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewProjectFolder dlg = new NewProjectFolder(this);
            dlg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoXiaoFrm dlg = new BaoXiaoFrm(this);
            dlg.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string destPath = System.Configuration.ConfigurationManager.AppSettings["cjz"];
                Process process = new Process();
                process.StartInfo.FileName = destPath;
                process.StartInfo.Arguments = "";
                process.Start();
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Console.WriteLine("系统找不到指定的程序文件。\r{0}", ex);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCompleteBaoxiao dlg = new FCompleteBaoxiao(this);
            dlg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScholzFrm dlg = new ScholzFrm(this);
            dlg.ShowDialog();
        }
    }
}
