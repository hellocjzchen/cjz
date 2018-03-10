using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUtils;
using System.IO;

namespace listViewFrm
{
    public partial class listViewFrm : UserControl
    {
        //public string CurrentViewPath { get; set; }
        //public string CurrentItemPath { get; set; }
        ImageList largeimagelist = new ImageList();
        ImageList smallimagelist = new ImageList();
        public listViewFrm()
        {
            InitializeComponent();
           
        }
        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }

      
      

        private void listViewFrm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //双击，1. 如果是文件， 则打开， 
            //      2.  如果是文件夹，则向下打开一层
            //      
            #region listview双击获取item事件，同时获取路径，名称
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                ListViewItem lv = info.Item as ListViewItem;
                string str = lv.Tag.ToString();
                if (Directory.Exists(str))
                {
                    this.Text = Path.Combine(this.Text, lv.Text);
                    CommonHelper.loadFileAndFolder(str, listView1, largeimagelist, smallimagelist);
                    return;
                }
                if (File.Exists(str))
                {
                    System.Diagnostics.Process.Start(str);
                    return;
                }
                #endregion
            }
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!this.Text.Contains('\\'))
                {
                    return;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem lv = this.listView1.SelectedItems[0];
                        string str = lv.Tag.ToString();
                        if (Directory.Exists(str))
                        {
                            this.Text = Path.Combine(this.Text, lv.Text);
                            CommonHelper.loadFileAndFolder(str, listView1, largeimagelist,smallimagelist);
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    ListViewItem lv = this.listView1.SelectedItems[0];
                    string str = lv.Tag.ToString();
                    int index = str.LastIndexOf('\\');
                    string str1 =str.Substring(0, index);
                    CommonHelper.loadFileAndFolder(str1, listView1, largeimagelist,smallimagelist);
                    int mindex = this.Text.LastIndexOf('\\');
                    this.Text = this.Text.Substring(0, mindex);
                }
            }
            catch
            {
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

        private void listViewFrm_Load(object sender, EventArgs e)
        {
            SetContent();
        }
        public void SetContent()
        {
            listView1.LargeImageList = largeimagelist;
            listView1.LargeImageList.ImageSize = new Size(32, 32);
            string str_path = System.Configuration.ConfigurationManager.AppSettings["cjz"];
            if (str_path != string.Empty)
            {
                CommonHelper.loadFileAndFolder(str_path, this.listView1, this.largeimagelist,smallimagelist);
            }
        }
    }
}
