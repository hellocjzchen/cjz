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
using System.Collections;
namespace cjz
{


    public partial class FCompleteBaoxiao : Form
    {
        Form1 frm;
        ImageList largeimagelist_d;
        ImageList largeimagelist_y ;
        ImageList smallimagelist_d;
        ImageList smallimagelist_y;
        string path_d;
        string path_y;

        public FCompleteBaoxiao()
        {
            InitializeComponent();
        }
        public FCompleteBaoxiao(Form1 frm1)
        {
            frm = frm1;
            InitializeComponent();
            //countEvent.OnDelCountChangedEvent += new DelCountChanged(AfterCountChanged);
        }

        private void AfterCountChanged(object sender, EventArgs e)
        {
            //if(countEvent.count>0)
            //{
            //    btnto_D.Enabled = false;
            //    btnto_D.BackColor = Color.Azure;
            //}
            //else
            //{
            //    btnto_D.Enabled = true;
            //    btnto_D.BackColor = Color.Transparent;
            //}
        }

        private void FCompleteBaoxiao_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }
        //load
        private void FCompleteBaoxiao_Load(object sender, EventArgs e)
        {
            try
            {
                listViewNF_D.LargeImageList = largeimagelist_d= new ImageList();
                listViewNF_D.SmallImageList = smallimagelist_d = new ImageList();
                listViewNF_D.LargeImageList.ImageSize = new Size(32, 32);
                listViewNF_D.SmallImageList.ImageSize = new Size(16, 16);
                listViewNF_Y.LargeImageList = largeimagelist_y = new ImageList();
                listViewNF_Y.SmallImageList = smallimagelist_y = new ImageList();
                listViewNF_Y.LargeImageList.ImageSize = new Size(32, 32);
                listViewNF_Y.SmallImageList.ImageSize = new Size(16, 16);
                string[] d_folders = CommonHelper.GetSubFolderName(System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"]);

                string[] y_folders = CommonHelper.GetSubFolderName(System.Configuration.ConfigurationManager.AppSettings["yibaoxiao_path"]);
                cmb_d.Tag = System.Configuration.ConfigurationManager.AppSettings["baoxiao_path"];
                cmb_y.Tag = System.Configuration.ConfigurationManager.AppSettings["yibaoxiao_path"];
                cmb_d.Items.Add("待报销文件夹");
                cmb_y.Items.Add("已报销文件夹");
                cmb_d.SelectedIndex = 0;
                cmb_y.SelectedIndex = 0;
                cmb_d.Items.AddRange(d_folders);
                cmb_y.Items.AddRange(y_folders);
                cmb_d.SelectedIndex = cmb_d.Items.Count - 1;
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }


        }
        //CMB选项发生变化
        private void cmb_d_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = cmb_d.SelectedIndex;
                string text = cmb_d.Items[i].ToString();
                path_d = Path.Combine((string)cmb_d.Tag, text);

                cmb_y.SelectedItem = text;
                path_y = Path.Combine((string)cmb_y.Tag, text);
                if (i == 0)
                {
                    listViewNF_D.Clear();
                    listViewNF_Y.Clear();
                    cmb_y.SelectedIndex = 0;
                    return;
                }
                CommonHelper.loadFile(path_d, listViewNF_D, largeimagelist_d,smallimagelist_d);
                CommonHelper.loadFile(path_y, listViewNF_Y, largeimagelist_y,smallimagelist_y);
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }
        //cmb选项变化
        private void cmb_y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = cmb_y.SelectedIndex;
                string text = cmb_y.Items[i].ToString();
                if (i == 0)
                {

                    listViewNF_D.Clear();
                    cmb_d.SelectedIndex = 0;
                    listViewNF_Y.Clear();
                    return;
                }
                cmb_d.SelectedItem = text;
                string path_y = Path.Combine((string)cmb_y.Tag, text);
                CommonHelper.loadFile(path_y, listViewNF_Y, largeimagelist_y,smallimagelist_y);
                if (!cmb_d.Items.Contains(text))
                {
                    Directory.CreateDirectory(Path.Combine(cmb_d.Tag.ToString(), text));
                    Directory.CreateDirectory(Path.Combine(cmb_d.Tag.ToString(), text, "tmp"));
                    cmb_d.Items.Add(text);
                }
                string path_d = Path.Combine((string)cmb_d.Tag, text);
                CommonHelper.loadFile(path_d, listViewNF_D, largeimagelist_d,smallimagelist_d);
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }
        private void listViewNF_Y_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Selected = e.Item.Checked;
            if (listViewNF_Y.CheckedItems.Count > 0)
            {
                if (listViewNF_D.CheckedItems.Count>0)
                {
                    return;
                }
                btnto_Y.Enabled = false;
                btnto_Y.BackColor = Color.Violet;
                btnto_Y.Text = "<<";
                btnto_Y.FlatAppearance.BorderSize = 0;
            }
            else
            {
                btnto_Y.Enabled = true;
                btnto_Y.BackColor = Color.Transparent;
                btnto_Y.Text = ">>";
                btnto_Y.FlatAppearance.BorderSize = 1;
            }
        }

        private void btnto_Y_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewNF_D.CheckedItems.Count > 0)
                {
                    string sourcedirpath = listViewNF_D.Tag.ToString();
                    string destdirpath = listViewNF_Y.Tag.ToString();
                    string sourcepath, destpath, tmpsourchpath, tmpdestpath;
                    int ncount = listViewNF_D.CheckedItems.Count;
                    ListViewItem item;
                    for (int i = 0; i < ncount; i++)
                    {                        
                        item = listViewNF_D.CheckedItems[i];
                        sourcepath = Path.Combine(sourcedirpath, item.Text);
                        tmpsourchpath = Path.Combine(sourcedirpath, "tmp", Path.GetFileNameWithoutExtension(item.Text)) + ".dat";

                        tmpdestpath = Path.Combine(destdirpath, "tmp", Path.GetFileNameWithoutExtension( item.Text))+".dat";
                        destpath = Path.Combine(destdirpath, item.Text);
                       // CommonHelper.InvokeCmd("move " + sourcepath + " " + destpath);           
                        //File.Move(tmpsourchpath, tmpdestpath);
                        //File.Delete()
                        File.Move(sourcepath, destpath);
                        if (File.Exists(tmpsourchpath))
                        {
                            File.Delete(tmpsourchpath);
                        }                        
                    }
                    listViewNF_D.Clear();
                    listViewNF_Y.Clear();
                    CommonHelper.loadFile(path_d, listViewNF_D, largeimagelist_d,smallimagelist_d);
                    CommonHelper.loadFile(path_y, listViewNF_Y, largeimagelist_y,smallimagelist_y);
                   // this.Close();
                }
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
            }
        }

        
    }
}
