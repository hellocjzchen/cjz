namespace cjz.User_interface
{
    partial class FAppForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加应用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.exepage = new System.Windows.Forms.TabPage();
            this.docpage = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加应用ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加应用ToolStripMenuItem
            // 
            this.添加应用ToolStripMenuItem.Name = "添加应用ToolStripMenuItem";
            this.添加应用ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加应用ToolStripMenuItem.Text = "添加应用";
            this.添加应用ToolStripMenuItem.Click += new System.EventHandler(this.添加应用ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.exepage);
            this.tabControl1.Controls.Add(this.docpage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 514);
            this.tabControl1.TabIndex = 1;
            // 
            // exepage
            // 
            this.exepage.Location = new System.Drawing.Point(4, 22);
            this.exepage.Name = "exepage";
            this.exepage.Padding = new System.Windows.Forms.Padding(3);
            this.exepage.Size = new System.Drawing.Size(777, 488);
            this.exepage.TabIndex = 0;
            this.exepage.Text = "应用程序";
            this.exepage.UseVisualStyleBackColor = true;
            // 
            // docpage
            // 
            this.docpage.Location = new System.Drawing.Point(4, 22);
            this.docpage.Name = "docpage";
            this.docpage.Padding = new System.Windows.Forms.Padding(3);
            this.docpage.Size = new System.Drawing.Size(777, 396);
            this.docpage.TabIndex = 1;
            this.docpage.Text = "常用资料";
            this.docpage.UseVisualStyleBackColor = true;
            // 
            // FAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 539);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAppForm";
            this.Load += new System.EventHandler(this.FAppForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加应用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage exepage;
        private System.Windows.Forms.TabPage docpage;
    }
}