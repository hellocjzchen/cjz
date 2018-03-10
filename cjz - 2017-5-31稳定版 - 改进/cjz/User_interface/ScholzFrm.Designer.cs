namespace cjz
{
    partial class ScholzFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddorMdy = new System.Windows.Forms.Button();
            this.txtSignY = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbuser = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lvalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.58974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.41026F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 139);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 113);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加修改";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtUser, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtJobNo, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtP, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtL, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtD, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtT, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAddorMdy, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSignY, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_id, 6, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("宋体", 12F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 107);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.Location = new System.Drawing.Point(68, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(111, 26);
            this.txtUser.TabIndex = 1;
            // 
            // txtJobNo
            // 
            this.txtJobNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJobNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtJobNo.Location = new System.Drawing.Point(286, 5);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(106, 26);
            this.txtJobNo.TabIndex = 2;
            // 
            // txtP
            // 
            this.txtP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtP.Font = new System.Drawing.Font("宋体", 12F);
            this.txtP.Location = new System.Drawing.Point(497, 35);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(153, 26);
            this.txtP.TabIndex = 4;
            // 
            // txtL
            // 
            this.txtL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtL.Font = new System.Drawing.Font("宋体", 12F);
            this.txtL.Location = new System.Drawing.Point(286, 35);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(106, 26);
            this.txtL.TabIndex = 5;
            // 
            // txtD
            // 
            this.txtD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtD.Location = new System.Drawing.Point(68, 35);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(111, 26);
            this.txtD.TabIndex = 6;
            // 
            // txtT
            // 
            this.txtT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT.Location = new System.Drawing.Point(68, 75);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(111, 26);
            this.txtT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "有效直径：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "最高温度：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(186, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "JobNo.：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(186, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "有效长度：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(399, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "签订日期：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(399, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "最大压力：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddorMdy
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnAddorMdy, 2);
            this.btnAddorMdy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddorMdy.Location = new System.Drawing.Point(286, 75);
            this.btnAddorMdy.Name = "btnAddorMdy";
            this.btnAddorMdy.Size = new System.Drawing.Size(204, 28);
            this.btnAddorMdy.TabIndex = 14;
            this.btnAddorMdy.Text = "添加";
            this.btnAddorMdy.UseVisualStyleBackColor = true;
            this.btnAddorMdy.Click += new System.EventHandler(this.btnAddorMdy_Click);
            // 
            // txtSignY
            // 
            this.txtSignY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSignY.Location = new System.Drawing.Point(497, 5);
            this.txtSignY.Multiline = true;
            this.txtSignY.Name = "txtSignY";
            this.txtSignY.Size = new System.Drawing.Size(153, 23);
            this.txtSignY.TabIndex = 15;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_id.Location = new System.Drawing.Point(497, 72);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(153, 34);
            this.label_id.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cmbuser);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 113);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查找";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "从excel导入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "根据用户名查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbuser
            // 
            this.cmbuser.FormattingEnabled = true;
            this.cmbuser.Location = new System.Drawing.Point(123, 26);
            this.cmbuser.Name = "cmbuser";
            this.cmbuser.Size = new System.Drawing.Size(130, 20);
            this.cmbuser.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(44, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "用户：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userName,
            this.jobNo,
            this.SignYear,
            this.Dvalid,
            this.Lvalid,
            this.PressureMax,
            this.TempMax});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(668, 292);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 75;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "用户";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 75;
            // 
            // jobNo
            // 
            this.jobNo.DataPropertyName = "jobNo";
            this.jobNo.HeaderText = "jobNo.";
            this.jobNo.Name = "jobNo";
            this.jobNo.ReadOnly = true;
            this.jobNo.Width = 75;
            // 
            // SignYear
            // 
            this.SignYear.DataPropertyName = "SignYear";
            this.SignYear.HeaderText = "签订日期";
            this.SignYear.Name = "SignYear";
            this.SignYear.ReadOnly = true;
            this.SignYear.Width = 80;
            // 
            // Dvalid
            // 
            this.Dvalid.DataPropertyName = "Dvalid";
            this.Dvalid.HeaderText = "有效直径";
            this.Dvalid.Name = "Dvalid";
            this.Dvalid.ReadOnly = true;
            this.Dvalid.Width = 80;
            // 
            // Lvalid
            // 
            this.Lvalid.DataPropertyName = "Lvalid";
            this.Lvalid.HeaderText = "有效长度";
            this.Lvalid.Name = "Lvalid";
            this.Lvalid.ReadOnly = true;
            this.Lvalid.Width = 80;
            // 
            // PressureMax
            // 
            this.PressureMax.DataPropertyName = "PressureMax";
            this.PressureMax.HeaderText = "最大压力";
            this.PressureMax.Name = "PressureMax";
            this.PressureMax.ReadOnly = true;
            this.PressureMax.Width = 80;
            // 
            // TempMax
            // 
            this.TempMax.DataPropertyName = "TempMax";
            this.TempMax.HeaderText = "最高温度";
            this.TempMax.Name = "TempMax";
            this.TempMax.ReadOnly = true;
            this.TempMax.Width = 80;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(668, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "SCHOLZ设备JobNo清单列表";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScholzFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScholzFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScholzFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScholzFrm_FormClosing);
            this.Load += new System.EventHandler(this.ScholzFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lvalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempMax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddorMdy;
        private System.Windows.Forms.TextBox txtSignY;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_id;
    }
}