using cjz.module;
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
using System.Xml.Linq;
using Utils;

namespace cjz.User_interface
{
    public partial class FAppForm : Form
    {
        string exexmlpath = string.Empty;
        string docxmlpath = string.Empty;
        string _path = string.Empty;
        public FAppForm()
        {
            InitializeComponent();

        }

        private void FAppForm_Load(object sender, EventArgs e)
        {
            exexmlpath = Application.StartupPath + @"\database\exexml.xml";
            docxmlpath = Application.StartupPath + @"\database\docxml.xml";
            LoadAndGenerateBtn(exepage, exexmlpath);
            LoadAndGenerateBtn(docpage,docxmlpath);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                Button btn = sender as Button;
                process.StartInfo.FileName = btn.Tag.ToString();
                process.StartInfo.Arguments = "";
                process.Start();
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }

        private void 添加应用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage page;
            if (this.tabControl1.SelectedTab == exepage)
            {
                page = exepage;
                _path = exexmlpath;
            }
            else
            {
                page = docpage;
                _path = docxmlpath;
            }
                

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog()== DialogResult.OK)
            {
                string _path1 = dlg.FileName;
                MessageBox.Show(_path1);
                string exename = Path.GetFileNameWithoutExtension(_path1);
                //add

                XElement xe = XElement.Load(_path);
                XElement record = new XElement(
                    new XElement("field",
                    new XElement("exeName", exename),
                    new XElement("path", dlg.FileName))
                    );
                xe.Add(record);
                xe.Save(_path);
                LogHelper.log("插入app数据成功");
                LoadAndGenerateBtn(page,_path);

            }
        }

        private void LoadAndGenerateBtn(TabPage page,string path)
        {
            try
            {
                XElement xe = XElement.Load(path);
                IEnumerable<XElement> elements = from ele in xe.Elements("field")
                                                 select ele;
                int x = 30, y = 20;
                page.Controls.Clear();
                foreach (var item in elements)
                {

                    Button btn = new Button();
                    btn.Text =  item.Element("exeName").Value;
                    btn.Tag = item.Element("path").Value;
                    btn.Name = "btn" + item.Element("exeName").Value;
                    btn.Image =Image.FromHbitmap( CommonHelper.GetIcon(item.Element("path").Value).ToBitmap().GetHbitmap());
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.Click += Btn_Click;
                    btn.Size = new Size(72, 68);
                    btn.Location = new Point(x, y);
                    page.Controls.Add(btn);
                    x += 72;
                    if (x + 48 > page.Width)
                    {
                        y += 80;
                        x = 30;
                    }

                }
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAndGenerateBtn(exepage, exexmlpath);
            LoadAndGenerateBtn(docpage, docxmlpath);
        }
    }
}
