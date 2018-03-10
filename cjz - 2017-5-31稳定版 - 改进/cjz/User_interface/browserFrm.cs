
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace cjz
{
    public partial class browserFrm : Form
    {
        ImageList largeimagelist = new ImageList();
        ImageList smallimagelist = new ImageList();
        public string currentFilePath { get; set; }
        public string itempath { get; set; }
        public browserFrm()
        {
            InitializeComponent();
        }

        private void browserFrm_Load(object sender, EventArgs e)
        {
            listView1.LargeImageList = largeimagelist;
            listView1.SmallImageList = smallimagelist;
            listView1.LargeImageList.ImageSize = new Size(32, 32);
            listView1.SmallImageList.ImageSize = new Size(16, 16);
            string str_path = System.Configuration.ConfigurationManager.AppSettings["cjz"];
            if (str_path != string.Empty)
            {
                CommonHelper.loadFileAndFolder(str_path, this.listView1, this.largeimagelist, smallimagelist);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //双击，1. 如果是文件， 则打开， 
            //      2.  如果是文件夹，则向下打开一层
            //      
            #region listview双击获取item事件，同时获取路径，名称
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                ListViewItem lv = info.Item as ListViewItem;
                itempath=currentFilePath = lv.Tag.ToString();
                if (Directory.Exists(currentFilePath))
                {
                    this.Text = Path.Combine(this.Text, lv.Text);
                    CommonHelper.loadFileAndFolder(currentFilePath, listView1, largeimagelist, smallimagelist);
                    return;
                }
                if (File.Exists(currentFilePath))
                {
                    System.Diagnostics.Process.Start(currentFilePath);
                    return;
                }
                #endregion
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem lv = this.listView1.SelectedItems[0];
                        currentFilePath = lv.Tag.ToString();
                        if (Directory.Exists(currentFilePath))
                        {
                            CommonHelper.loadFileAndFolder(currentFilePath, listView1, largeimagelist, smallimagelist);
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (currentFilePath!=string.Empty)
                    {
                        //string str = Path.GetFullPath(currentFilePath);
                        int index = currentFilePath.LastIndexOf('\\');
                        currentFilePath = currentFilePath.Substring(0, index);
                        CommonHelper.loadFileAndFolder(currentFilePath, listView1, largeimagelist, smallimagelist);
                    }                                       
                }
            }
            catch(Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.listView1.Columns.Add("名称", 600, HorizontalAlignment.Left);
            this.listView1.Columns.Add("访问时间", 600, HorizontalAlignment.Left);
            this.listView1.View = View.Details;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
        }
    }
}
