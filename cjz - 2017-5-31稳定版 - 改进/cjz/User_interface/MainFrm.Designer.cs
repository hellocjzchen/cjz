namespace cjz
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Create = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_ShowPj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_EditBX = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_BXFinish = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_SearchJobNo = new System.Windows.Forms.ToolStripButton();
            this.tsbn_SearchCMPPJ = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbn_Record = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbn_SystemSetup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbn_app = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FrmPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Create,
            this.toolStripSeparator1,
            this.tsbtn_ShowPj,
            this.toolStripSeparator2,
            this.tsbtn_EditBX,
            this.toolStripSeparator3,
            this.tsbtn_BXFinish,
            this.toolStripSeparator4,
            this.tsbtn_SearchJobNo,
            this.tsbn_SearchCMPPJ,
            this.toolStripSeparator5,
            this.tsbn_Record,
            this.toolStripSeparator6,
            this.tsbn_SystemSetup,
            this.toolStripSeparator7,
            this.tsbn_app});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Create
            // 
            this.tsbtn_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Create.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Create.Image")));
            this.tsbtn_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Create.Name = "tsbtn_Create";
            this.tsbtn_Create.Size = new System.Drawing.Size(190, 40);
            this.tsbtn_Create.Text = "创建项目文件及报销文件";
            this.tsbtn_Create.Click += new System.EventHandler(this.button_pressDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbtn_ShowPj
            // 
            this.tsbtn_ShowPj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_ShowPj.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_ShowPj.Image")));
            this.tsbtn_ShowPj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ShowPj.Name = "tsbtn_ShowPj";
            this.tsbtn_ShowPj.Size = new System.Drawing.Size(110, 40);
            this.tsbtn_ShowPj.Text = "显示项目文件";
            this.tsbtn_ShowPj.Click += new System.EventHandler(this.button_pressDown);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbtn_EditBX
            // 
            this.tsbtn_EditBX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_EditBX.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_EditBX.Image")));
            this.tsbtn_EditBX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_EditBX.Name = "tsbtn_EditBX";
            this.tsbtn_EditBX.Size = new System.Drawing.Size(110, 40);
            this.tsbtn_EditBX.Text = "编辑报销文件";
            this.tsbtn_EditBX.Click += new System.EventHandler(this.button_pressDown);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbtn_BXFinish
            // 
            this.tsbtn_BXFinish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_BXFinish.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_BXFinish.Image")));
            this.tsbtn_BXFinish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_BXFinish.Name = "tsbtn_BXFinish";
            this.tsbtn_BXFinish.Size = new System.Drawing.Size(110, 40);
            this.tsbtn_BXFinish.Text = "报销完成操作";
            this.tsbtn_BXFinish.Click += new System.EventHandler(this.button_pressDown);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbtn_SearchJobNo
            // 
            this.tsbtn_SearchJobNo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_SearchJobNo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_SearchJobNo.Image")));
            this.tsbtn_SearchJobNo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_SearchJobNo.Name = "tsbtn_SearchJobNo";
            this.tsbtn_SearchJobNo.Size = new System.Drawing.Size(175, 40);
            this.tsbtn_SearchJobNo.Text = "查询项目编号及JobNo";
            this.tsbtn_SearchJobNo.Click += new System.EventHandler(this.button_pressDown);
            // 
            // tsbn_SearchCMPPJ
            // 
            this.tsbn_SearchCMPPJ.Image = ((System.Drawing.Image)(resources.GetObject("tsbn_SearchCMPPJ.Image")));
            this.tsbn_SearchCMPPJ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_SearchCMPPJ.Name = "tsbn_SearchCMPPJ";
            this.tsbn_SearchCMPPJ.Size = new System.Drawing.Size(192, 40);
            this.tsbn_SearchCMPPJ.Text = "查询公司项目编号";
            this.tsbn_SearchCMPPJ.Click += new System.EventHandler(this.button_pressDown);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbn_Record
            // 
            this.tsbn_Record.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbn_Record.Image = ((System.Drawing.Image)(resources.GetObject("tsbn_Record.Image")));
            this.tsbn_Record.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_Record.Name = "tsbn_Record";
            this.tsbn_Record.Size = new System.Drawing.Size(62, 40);
            this.tsbn_Record.Text = "备忘录";
            this.tsbn_Record.Click += new System.EventHandler(this.button_pressDown);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbn_SystemSetup
            // 
            this.tsbn_SystemSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbn_SystemSetup.Image = ((System.Drawing.Image)(resources.GetObject("tsbn_SystemSetup.Image")));
            this.tsbn_SystemSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_SystemSetup.Name = "tsbn_SystemSetup";
            this.tsbn_SystemSetup.Size = new System.Drawing.Size(78, 40);
            this.tsbn_SystemSetup.Text = "系统设置";
            this.tsbn_SystemSetup.Click += new System.EventHandler(this.button_pressDown);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbn_app
            // 
            this.tsbn_app.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbn_app.Image = ((System.Drawing.Image)(resources.GetObject("tsbn_app.Image")));
            this.tsbn_app.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_app.Name = "tsbn_app";
            this.tsbn_app.Size = new System.Drawing.Size(110, 40);
            this.tsbn_app.Text = "常用应用程序";
            this.tsbn_app.Click += new System.EventHandler(this.button_pressDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FrmPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 678);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FrmPanel
            // 
            this.FrmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmPanel.Location = new System.Drawing.Point(3, 3);
            this.FrmPanel.Name = "FrmPanel";
            this.FrmPanel.Size = new System.Drawing.Size(1258, 672);
            this.FrmPanel.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.隐藏ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.隐藏ToolStripMenuItem.Text = "隐藏";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_Create;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_ShowPj;
        private System.Windows.Forms.ToolStripButton tsbtn_EditBX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtn_SearchJobNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtn_BXFinish;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel FrmPanel;
        private System.Windows.Forms.ToolStripButton tsbn_SearchCMPPJ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbn_Record;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbn_SystemSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbn_app;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}