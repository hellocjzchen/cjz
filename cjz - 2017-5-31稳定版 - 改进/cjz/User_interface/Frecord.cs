using cjz.BLL.RecContentBLL;
using cjz.BLL.recordCategaryBLL;
using cjz.module;
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

namespace cjz.User_interface
{
    public partial class Frecord : Form
    {
        RecContentBLL reccontentbll = new RecContentBLL();
        recordCategaryBLL recordcategarybll = new recordCategaryBLL();
        int rootNodeNo,subNodeNo;
        bool addPnodeflag = false;
        bool addSnodeflag = false;
        public Frecord()
        {
            InitializeComponent();
        }

        private void TSMI_InsertItem_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode("请加入新的类别");
            this.treeView1.Nodes.Add(node);
            rootNodeNo++;
            node.Tag = rootNodeNo;
            this.treeView1.SelectedNode = node;
            treeView1.SelectedNode.BeginEdit();
            addPnodeflag = true;
            
        }

        private void LoadData()
        {
            List<recordCategary> categarylist = recordcategarybll.GetrecordCategaryList();
            List<RecContent> contentlist = reccontentbll.GetRecContentList();
            rootNodeNo = categarylist.Count;
            subNodeNo = contentlist.Count;
            if (categarylist.Count > 0)
            {
                TreeNode node;
                foreach (recordCategary item in categarylist)
                {
                    if (!item.DelFlag)
                    {
                        node = new TreeNode();
                        node.Text = item.rCategary;
                        node.Tag = item.id;
                        if (contentlist.Count > 0)
                        {
                            TreeNode subnode;
                            foreach (RecContent con in contentlist)
                            {
                                if (con.FID == item.id && !con.DelFlag)
                                {
                                    subnode = new TreeNode();
                                    subnode.Text = con.recName;
                                    subnode.Tag = con.ID;
                                    node.Nodes.Add(subnode);
                                }

                            }
                        }

                        this.treeView1.Nodes.Add(node);


                    }
                }

            }
        }

        private void Frecord_Load(object sender, EventArgs e)
        {
            LoadData();
            this.TSMI_Modify.BackColor = Color.Gray;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = this.treeView1.SelectedNode;
                if (node != null & node.Parent != null) //子节点
                {
                    int id = Convert.ToInt32(node.Tag);
                    string text;
                    if (addSnodeflag) //新加子节点
                    {
                        text = "";
                    }
                    else
                    { //正常切换子节点
                        if (this.richTextBox1.Modified)
                        {
                            int mid = Convert.ToInt32(this.richTextBox1.Tag);
                            MemoryStream mstream = new MemoryStream();
                            this.richTextBox1.SaveFile(mstream, RichTextBoxStreamType.RichText);
                            reccontentbll.UpdateContentByID(mid, System.Text.Encoding.UTF8.GetString(mstream.ToArray()));
                        }
                        text = reccontentbll.GetContentByID(id);
                    }
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
                    if (bytes.Length > 0)
                    {
                        MemoryStream mstream = new MemoryStream(bytes);
                        mstream.Position = 0;
                        this.richTextBox1.Clear();
                        this.richTextBox1.LoadFile(mstream, RichTextBoxStreamType.RichText);
                    }
                    else //主节点
                        this.richTextBox1.Text = "";
                    this.richTextBox1.Tag = id;
                }
            }
            catch (System.Exception ex)
            {
                LogHelper.log(ex.Message);
                return;
            }
            
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!' }) == -1)
                    {
                        // Stop editing without canceling the label change.
                        e.Node.EndEdit(true);
                        
                        if (e.Node.Parent != null)
                        {
                            RecContent content = new RecContent();
                            content.ID= Convert.ToInt32(e.Node.Tag);
                            //子节点，                            
                            content.FID = Convert.ToInt32(e.Node.Parent.Tag);
                            content.recName = e.Label.ToString();
                            content.record = "";
                            if (addSnodeflag)
                            {
                                //添加新节点
                                reccontentbll.InsertMemberInfo(content);
                            }
                            else
                            {
                                //修改节点名字
                                content.ID = Convert.ToInt32(e.Node.Tag);
                                reccontentbll.updaterRecNameByID(content);
                            }
                        }
                        else
                        {
                            //父节点
                            recordCategary cat = new recordCategary();
                            cat.DelFlag = false;                            
                            cat.rCategary = e.Label.ToString();
                            cat.id = Convert.ToInt32(e.Node.Tag);
                            if (addPnodeflag)
                            {
                                //添加节点                                
                                cat.id = rootNodeNo;
                                recordcategarybll.InsertrecordCategaryInfo(cat);
                                addPnodeflag = false;
                            }
                            else
                            {
                                //修改节点名字
                                recordcategarybll.updaterCategaryByID(cat);
                            }
                        }
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and 
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MessageBox.Show("Invalid tree node label.\n" +
                           "The invalid characters are: '@','.', ',', '!'",
                           "Node Label Edit");
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    /* Cancel the label edit action, inform the user, and 
                       place the node in edit mode again. */
                    e.CancelEdit = true;
                    MessageBox.Show("Invalid tree node label.\nThe label cannot be blank",
                       "Node Label Edit");
                    e.Node.BeginEdit();
                }                    
            }
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.treeView1.SelectedNode!=null)
            {
                this.treeView1.SelectedNode.BeginEdit();
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Right)
            {
                TreeNode tn = treeView1.GetNodeAt(e.X, e.Y);
                if (tn != null) treeView1.SelectedNode = tn;
                contextMenuStrip1.Show(e.X, e.Y);
            }
        }
        //删除节点和类别
        private void TSMI_Delete_Click(object sender, EventArgs e)
        {
            string name = this.treeView1.SelectedNode.Text;
            if (this.treeView1.SelectedNode.Parent!=null)
            {
                //子节点                
                reccontentbll.DeleteItemByName(name);
                
            }
            else
            {
                if (MessageBox.Show("确定删除本类别？")== DialogResult.OK)
                {
                    recordcategarybll.DeleteItemByName(name);
                    
                }
            }
            this.treeView1.SelectedNode.Remove();
        }

        private void 插入当前日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode!=null)
            {
                if (this.treeView1.SelectedNode.Parent!=null)
                {
                    this.richTextBox1.AppendText("\n"+DateTime.Now.ToString("yyyy / MM / dd HH: mm:ss: ffff dddd") + "\n");
                }
            }
            
        }
        //允许修改
        private void TSMI_ModifyContent_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.ReadOnly==true)
            {
                this.richTextBox1.ReadOnly = false;
                this.TSMI_Modify.BackColor = Color.Green;
                this.TSMI_Modify.Text = "禁止修改";
            }
            else
            {
                this.richTextBox1.ReadOnly = true;
                this.TSMI_Modify.BackColor = Color.Gray;
                this.TSMI_Modify.Text = "允许修改";
            }
            
            
        }
        //保存文件
        private void TSMI_FM_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Modified)
            {
                this.richTextBox1.ReadOnly = true;
                MemoryStream mstream = new MemoryStream();
                mstream.Position = 0;
                this.richTextBox1.SaveFile(mstream, RichTextBoxStreamType.RichText);
                int id = Convert.ToInt32(this.richTextBox1.Tag);
                reccontentbll.UpdateContentByID(id,System.Text.Encoding.UTF8.GetString( mstream.ToArray()));
                this.TSMI_Modify.BackColor = Color.Gray;
            }
        }

        private void TSMI_COPY_Click(object sender, EventArgs e)
        {
            //复制
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);//复制RTF数据到剪贴板
        }

        private void TSMI_STICK_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Clipboard.GetDataObject().GetFormats().Length==0)
                //{
                //    MessageBox.Show("剪切板为空");
                //}
                //MemoryStream ms = new MemoryStream();
                //IDataObject dataobject = Clipboard.GetDataObject();
                //var obj=System.Windows.Forms.Clipboard.GetData(DataFormats.WaveAudio);
                //byte[] buf = System.Text.Encoding.UTF8.GetBytes(obj.ToString());
                //ms.Position = 0;
                //this.richTextBox1.SaveFile(ms, RichTextBoxStreamType.RichText);
                //ms.Write(buf, 0,buf.Length);
                //ms.Position = 0;
                //this.richTextBox1.LoadFile(ms, RichTextBoxStreamType.RichText);                
                this.richTextBox1.Paste();
            }
            catch (System.Exception ex)
            {
                LogHelper.log(ex.Message);
                return;
            }
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //剪切
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);//复制RTF数据到剪贴板
            richTextBox1.SelectedRtf = "";//再把当前选取的RTF内容清除掉,当前就实现剪切功能了.
        }

        private void 修改字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result=fontDialog1.ShowDialog();
            if (result== DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void 修改文本框字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void TSMI_InsertSubItem_Click(object sender, EventArgs e)
        {
            addSnodeflag = true;
            if (this.treeView1.SelectedNode!=null)
            {
                TreeNode root;
                if (this.treeView1.SelectedNode.Parent != null)
                {
                     root = this.treeView1.SelectedNode.Parent;
                }
                else
                {
                    root = this.treeView1.SelectedNode;
                }
                    subNodeNo++;
                    int id = subNodeNo;
                    TreeNode subnode = new TreeNode();
                    subnode.Tag = id;
                    subnode.Text ="新节点";
                    root.Nodes.Add(subnode);
                    this.treeView1.SelectedNode = subnode;
                //将节点插入到数据库中，然后可以启动改名
                this.treeView1.SelectedNode.BeginEdit();               

            }
        }
    }
}
