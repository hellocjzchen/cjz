namespace cjz
{
    partial class FCompleteBaoxiao
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_y = new System.Windows.Forms.ComboBox();
            this.listViewNF_D = new cjz.ListViewNF();
            this.listViewNF_Y = new cjz.ListViewNF();
            this.cmb_d = new System.Windows.Forms.ComboBox();
            this.btnto_Y = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.cmb_y, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewNF_D, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewNF_Y, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_d, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnto_Y, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.36634F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.63366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 521);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmb_y
            // 
            this.cmb_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_y.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_y.FormattingEnabled = true;
            this.cmb_y.Location = new System.Drawing.Point(589, 3);
            this.cmb_y.Name = "cmb_y";
            this.cmb_y.Size = new System.Drawing.Size(476, 24);
            this.cmb_y.TabIndex = 7;
            this.cmb_y.TextChanged += new System.EventHandler(this.cmb_y_TextChanged);
            // 
            // listViewNF_D
            // 
            this.listViewNF_D.BackColor = System.Drawing.SystemColors.Highlight;
            this.listViewNF_D.CheckBoxes = true;
            this.listViewNF_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNF_D.Location = new System.Drawing.Point(3, 48);
            this.listViewNF_D.Name = "listViewNF_D";
            this.tableLayoutPanel1.SetRowSpan(this.listViewNF_D, 2);
            this.listViewNF_D.Size = new System.Drawing.Size(474, 438);
            this.listViewNF_D.TabIndex = 0;
            this.listViewNF_D.UseCompatibleStateImageBehavior = false;
            // 
            // listViewNF_Y
            // 
            this.listViewNF_Y.BackColor = System.Drawing.SystemColors.Highlight;
            this.listViewNF_Y.CheckBoxes = true;
            this.listViewNF_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNF_Y.Location = new System.Drawing.Point(589, 48);
            this.listViewNF_Y.Name = "listViewNF_Y";
            this.tableLayoutPanel1.SetRowSpan(this.listViewNF_Y, 2);
            this.listViewNF_Y.Size = new System.Drawing.Size(476, 438);
            this.listViewNF_Y.TabIndex = 1;
            this.listViewNF_Y.UseCompatibleStateImageBehavior = false;
            this.listViewNF_Y.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewNF_Y_ItemChecked);
            // 
            // cmb_d
            // 
            this.cmb_d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_d.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_d.FormattingEnabled = true;
            this.cmb_d.Location = new System.Drawing.Point(3, 3);
            this.cmb_d.Name = "cmb_d";
            this.cmb_d.Size = new System.Drawing.Size(474, 24);
            this.cmb_d.TabIndex = 6;
            this.cmb_d.TextChanged += new System.EventHandler(this.cmb_d_TextChanged);
            // 
            // btnto_Y
            // 
            this.btnto_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnto_Y.Location = new System.Drawing.Point(483, 48);
            this.btnto_Y.Name = "btnto_Y";
            this.tableLayoutPanel1.SetRowSpan(this.btnto_Y, 2);
            this.btnto_Y.Size = new System.Drawing.Size(100, 438);
            this.btnto_Y.TabIndex = 5;
            this.btnto_Y.Text = ">>";
            this.btnto_Y.UseVisualStyleBackColor = true;
            this.btnto_Y.Click += new System.EventHandler(this.btnto_Y_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 492);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "待报销";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(589, 492);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(476, 21);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "已报销";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FCompleteBaoxiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 0);
            this.Name = "FCompleteBaoxiao";
            this.Text = "FCompleteBaoxiao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCompleteBaoxiao_FormClosing);
            this.Load += new System.EventHandler(this.FCompleteBaoxiao_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ListViewNF listViewNF_D;
        private System.Windows.Forms.Button btnto_Y;
        private ListViewNF listViewNF_Y;
        private System.Windows.Forms.ComboBox cmb_y;
        private System.Windows.Forms.ComboBox cmb_d;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}