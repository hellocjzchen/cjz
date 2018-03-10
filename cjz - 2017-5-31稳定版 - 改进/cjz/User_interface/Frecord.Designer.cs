namespace cjz.User_interface
{
    partial class Frecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.插入当前日期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_COPY = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_STICK = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ModifyContent = new System.Windows.Forms.ToolStripMenuItem();
            this.修改文本框字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改选中字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_ChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FinishModify = new System.Windows.Forms.ToolStripMenuItem();
            this.修改文本框字体ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改选中字体ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_InsertItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_InsertSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1386, 788);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.PowderBlue;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(312, 788);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1070, 763);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入当前日期ToolStripMenuItem,
            this.TSMI_COPY,
            this.TSMI_STICK,
            this.剪切ToolStripMenuItem,
            this.TSMI_ModifyContent,
            this.修改文本框字体ToolStripMenuItem,
            this.修改选中字体ToolStripMenuItem,
            this.TSMI_FM});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 180);
            // 
            // 插入当前日期ToolStripMenuItem
            // 
            this.插入当前日期ToolStripMenuItem.Name = "插入当前日期ToolStripMenuItem";
            this.插入当前日期ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.插入当前日期ToolStripMenuItem.Text = "插入当前日期";
            this.插入当前日期ToolStripMenuItem.Click += new System.EventHandler(this.插入当前日期ToolStripMenuItem_Click);
            // 
            // TSMI_COPY
            // 
            this.TSMI_COPY.Name = "TSMI_COPY";
            this.TSMI_COPY.Size = new System.Drawing.Size(160, 22);
            this.TSMI_COPY.Text = "复制";
            this.TSMI_COPY.Click += new System.EventHandler(this.TSMI_COPY_Click);
            // 
            // TSMI_STICK
            // 
            this.TSMI_STICK.Name = "TSMI_STICK";
            this.TSMI_STICK.Size = new System.Drawing.Size(160, 22);
            this.TSMI_STICK.Text = "粘贴";
            this.TSMI_STICK.Click += new System.EventHandler(this.TSMI_STICK_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // TSMI_ModifyContent
            // 
            this.TSMI_ModifyContent.Name = "TSMI_ModifyContent";
            this.TSMI_ModifyContent.Size = new System.Drawing.Size(160, 22);
            this.TSMI_ModifyContent.Text = "允许修改";
            this.TSMI_ModifyContent.Click += new System.EventHandler(this.TSMI_ModifyContent_Click);
            // 
            // 修改文本框字体ToolStripMenuItem
            // 
            this.修改文本框字体ToolStripMenuItem.Name = "修改文本框字体ToolStripMenuItem";
            this.修改文本框字体ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.修改文本框字体ToolStripMenuItem.Text = "修改文本框字体";
            this.修改文本框字体ToolStripMenuItem.Click += new System.EventHandler(this.修改文本框字体ToolStripMenuItem_Click);
            // 
            // 修改选中字体ToolStripMenuItem
            // 
            this.修改选中字体ToolStripMenuItem.Name = "修改选中字体ToolStripMenuItem";
            this.修改选中字体ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.修改选中字体ToolStripMenuItem.Text = "修改选中字体";
            this.修改选中字体ToolStripMenuItem.Click += new System.EventHandler(this.修改字体ToolStripMenuItem_Click);
            // 
            // TSMI_FM
            // 
            this.TSMI_FM.Name = "TSMI_FM";
            this.TSMI_FM.Size = new System.Drawing.Size(160, 22);
            this.TSMI_FM.Text = "完成修改";
            this.TSMI_FM.Click += new System.EventHandler(this.TSMI_FM_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ChangeFont,
            this.TSMI_Modify,
            this.TSMI_FinishModify,
            this.修改文本框字体ToolStripMenuItem1,
            this.修改选中字体ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_ChangeFont
            // 
            this.TSMI_ChangeFont.Name = "TSMI_ChangeFont";
            this.TSMI_ChangeFont.Size = new System.Drawing.Size(68, 21);
            this.TSMI_ChangeFont.Text = "更改字体";
            // 
            // TSMI_Modify
            // 
            this.TSMI_Modify.BackColor = System.Drawing.Color.Transparent;
            this.TSMI_Modify.Name = "TSMI_Modify";
            this.TSMI_Modify.Size = new System.Drawing.Size(68, 21);
            this.TSMI_Modify.Text = "允许修改";
            this.TSMI_Modify.Click += new System.EventHandler(this.TSMI_ModifyContent_Click);
            // 
            // TSMI_FinishModify
            // 
            this.TSMI_FinishModify.Name = "TSMI_FinishModify";
            this.TSMI_FinishModify.Size = new System.Drawing.Size(68, 21);
            this.TSMI_FinishModify.Text = "完成修改";
            this.TSMI_FinishModify.Click += new System.EventHandler(this.TSMI_FM_Click);
            // 
            // 修改文本框字体ToolStripMenuItem1
            // 
            this.修改文本框字体ToolStripMenuItem1.Name = "修改文本框字体ToolStripMenuItem1";
            this.修改文本框字体ToolStripMenuItem1.Size = new System.Drawing.Size(104, 21);
            this.修改文本框字体ToolStripMenuItem1.Text = "修改文本框字体";
            this.修改文本框字体ToolStripMenuItem1.Click += new System.EventHandler(this.修改文本框字体ToolStripMenuItem_Click);
            // 
            // 修改选中字体ToolStripMenuItem1
            // 
            this.修改选中字体ToolStripMenuItem1.Name = "修改选中字体ToolStripMenuItem1";
            this.修改选中字体ToolStripMenuItem1.Size = new System.Drawing.Size(92, 21);
            this.修改选中字体ToolStripMenuItem1.Text = "修改选中字体";
            this.修改选中字体ToolStripMenuItem1.Click += new System.EventHandler(this.修改字体ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_InsertItem,
            this.TSMI_InsertSubItem,
            this.TSMI_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // TSMI_InsertItem
            // 
            this.TSMI_InsertItem.Name = "TSMI_InsertItem";
            this.TSMI_InsertItem.Size = new System.Drawing.Size(124, 22);
            this.TSMI_InsertItem.Text = "插入类项";
            this.TSMI_InsertItem.Click += new System.EventHandler(this.TSMI_InsertItem_Click);
            // 
            // TSMI_InsertSubItem
            // 
            this.TSMI_InsertSubItem.Name = "TSMI_InsertSubItem";
            this.TSMI_InsertSubItem.Size = new System.Drawing.Size(124, 22);
            this.TSMI_InsertSubItem.Text = "插入子项";
            this.TSMI_InsertSubItem.Click += new System.EventHandler(this.TSMI_InsertSubItem_Click);
            // 
            // TSMI_Delete
            // 
            this.TSMI_Delete.Name = "TSMI_Delete";
            this.TSMI_Delete.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Delete.Text = "删除";
            this.TSMI_Delete.Click += new System.EventHandler(this.TSMI_Delete_Click);
            // 
            // Frecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frecord";
            this.Text = "Frecord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frecord_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ChangeFont;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Modify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_InsertItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_InsertSubItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 插入当前日期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ModifyContent;
        private System.Windows.Forms.ToolStripMenuItem 修改选中字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FM;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FinishModify;
        private System.Windows.Forms.ToolStripMenuItem TSMI_COPY;
        private System.Windows.Forms.ToolStripMenuItem TSMI_STICK;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem 修改文本框字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改文本框字体ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改选中字体ToolStripMenuItem1;
    }
}