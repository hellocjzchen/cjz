namespace cjz
{
    partial class CmpPJFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pjid = new System.Windows.Forms.Label();
            this.txt_pjcustomer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_pjstatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pjmanager = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pjdiscription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pjsupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pjnote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Projectid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mdy_add = new System.Windows.Forms.Button();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_searchbyGM = new System.Windows.Forms.Button();
            this.cmb_pjManager = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Customer = new System.Windows.Forms.ComboBox();
            this.btn_searchall = new System.Windows.Forms.Button();
            this.btn_unionSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.60961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.39039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ProjectID,
            this.customer,
            this.supplier,
            this.createDate,
            this.pjDiscription,
            this.pjManager,
            this.note,
            this.pjStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(964, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "项目号";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.DataPropertyName = "customer";
            this.customer.HeaderText = "客户";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.DataPropertyName = "Supplier";
            this.supplier.HeaderText = "供应商";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // createDate
            // 
            this.createDate.DataPropertyName = "CreateDate";
            this.createDate.HeaderText = "创建日期";
            this.createDate.Name = "createDate";
            this.createDate.ReadOnly = true;
            // 
            // pjDiscription
            // 
            this.pjDiscription.DataPropertyName = "pjDiscription";
            this.pjDiscription.HeaderText = "项目描述";
            this.pjDiscription.Name = "pjDiscription";
            this.pjDiscription.ReadOnly = true;
            // 
            // pjManager
            // 
            this.pjManager.DataPropertyName = "pjManager";
            this.pjManager.HeaderText = "项目经理";
            this.pjManager.Name = "pjManager";
            this.pjManager.ReadOnly = true;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "注释";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // pjStatus
            // 
            this.pjStatus.DataPropertyName = "pjStatus";
            this.pjStatus.HeaderText = "状态";
            this.pjStatus.Name = "pjStatus";
            this.pjStatus.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(964, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "新丰公司项目清单";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 408);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 189);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加修改";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_pjid, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_pjcustomer, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_pjstatus, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_pjmanager, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_pjdiscription, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_pjsupplier, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_pjnote, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Projectid, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_mdy_add, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpicker, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(950, 157);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_pjid
            // 
            this.lbl_pjid.AutoSize = true;
            this.lbl_pjid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pjid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pjid.Location = new System.Drawing.Point(631, 104);
            this.lbl_pjid.Name = "lbl_pjid";
            this.lbl_pjid.Size = new System.Drawing.Size(113, 53);
            this.lbl_pjid.TabIndex = 20;
            this.lbl_pjid.Text = "labelid";
            this.lbl_pjid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pjcustomer
            // 
            this.txt_pjcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pjcustomer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pjcustomer.Location = new System.Drawing.Point(436, 3);
            this.txt_pjcustomer.Multiline = true;
            this.txt_pjcustomer.Name = "txt_pjcustomer";
            this.txt_pjcustomer.Size = new System.Drawing.Size(189, 46);
            this.txt_pjcustomer.TabIndex = 18;
            this.txt_pjcustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(317, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 53);
            this.label8.TabIndex = 16;
            this.label8.Text = "状态：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pjstatus
            // 
            this.txt_pjstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pjstatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pjstatus.Location = new System.Drawing.Point(436, 107);
            this.txt_pjstatus.Multiline = true;
            this.txt_pjstatus.Name = "txt_pjstatus";
            this.txt_pjstatus.Size = new System.Drawing.Size(189, 47);
            this.txt_pjstatus.TabIndex = 17;
            this.txt_pjstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(631, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 52);
            this.label7.TabIndex = 14;
            this.label7.Text = "项目经理：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pjmanager
            // 
            this.txt_pjmanager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pjmanager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pjmanager.Location = new System.Drawing.Point(750, 55);
            this.txt_pjmanager.Multiline = true;
            this.txt_pjmanager.Name = "txt_pjmanager";
            this.txt_pjmanager.Size = new System.Drawing.Size(197, 46);
            this.txt_pjmanager.TabIndex = 15;
            this.txt_pjmanager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(317, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 52);
            this.label6.TabIndex = 12;
            this.label6.Text = "项目描述：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pjdiscription
            // 
            this.txt_pjdiscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pjdiscription.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pjdiscription.Location = new System.Drawing.Point(436, 55);
            this.txt_pjdiscription.Multiline = true;
            this.txt_pjdiscription.Name = "txt_pjdiscription";
            this.txt_pjdiscription.Size = new System.Drawing.Size(189, 46);
            this.txt_pjdiscription.TabIndex = 13;
            this.txt_pjdiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(631, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "供应商：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pjsupplier
            // 
            this.txt_pjsupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pjsupplier.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pjsupplier.Location = new System.Drawing.Point(750, 3);
            this.txt_pjsupplier.Multiline = true;
            this.txt_pjsupplier.Name = "txt_pjsupplier";
            this.txt_pjsupplier.Size = new System.Drawing.Size(197, 46);
            this.txt_pjsupplier.TabIndex = 11;
            this.txt_pjsupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(317, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 52);
            this.label4.TabIndex = 8;
            this.label4.Text = "客户：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "注释";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pjnote
            // 
            this.txt_pjnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pjnote.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pjnote.Location = new System.Drawing.Point(122, 107);
            this.txt_pjnote.Multiline = true;
            this.txt_pjnote.Name = "txt_pjnote";
            this.txt_pjnote.Size = new System.Drawing.Size(189, 47);
            this.txt_pjnote.TabIndex = 4;
            this.txt_pjnote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "项目号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Projectid
            // 
            this.txt_Projectid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Projectid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Projectid.Location = new System.Drawing.Point(122, 3);
            this.txt_Projectid.Multiline = true;
            this.txt_Projectid.Name = "txt_Projectid";
            this.txt_Projectid.Size = new System.Drawing.Size(189, 46);
            this.txt_Projectid.TabIndex = 2;
            this.txt_Projectid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "创建日期：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mdy_add
            // 
            this.btn_mdy_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mdy_add.Location = new System.Drawing.Point(750, 107);
            this.btn_mdy_add.Name = "btn_mdy_add";
            this.btn_mdy_add.Size = new System.Drawing.Size(197, 47);
            this.btn_mdy_add.TabIndex = 19;
            this.btn_mdy_add.Text = "添加";
            this.btn_mdy_add.UseVisualStyleBackColor = true;
            this.btn_mdy_add.Click += new System.EventHandler(this.btn_mdy_add_Click);
            // 
            // dtpicker
            // 
            this.dtpicker.CalendarFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpicker.CustomFormat = "yyyy-MM-dd";
            this.dtpicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpicker.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker.Location = new System.Drawing.Point(122, 55);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(189, 35);
            this.dtpicker.TabIndex = 21;
            this.dtpicker.Value = new System.DateTime(2017, 6, 5, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查找";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.2931F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.70689F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tableLayoutPanel3.Controls.Add(this.btn_searchbyGM, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.cmb_pjManager, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button3, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_supplier, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Customer, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_searchall, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_unionSearch, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(950, 157);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_searchbyGM
            // 
            this.btn_searchbyGM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchbyGM.Location = new System.Drawing.Point(623, 79);
            this.btn_searchbyGM.Name = "btn_searchbyGM";
            this.btn_searchbyGM.Size = new System.Drawing.Size(324, 34);
            this.btn_searchbyGM.TabIndex = 26;
            this.btn_searchbyGM.Text = "根据项目经理查询";
            this.btn_searchbyGM.UseVisualStyleBackColor = true;
            this.btn_searchbyGM.Click += new System.EventHandler(this.btn_searchbyGM_Click);
            // 
            // cmb_pjManager
            // 
            this.cmb_pjManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_pjManager.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_pjManager.FormattingEnabled = true;
            this.cmb_pjManager.Location = new System.Drawing.Point(166, 79);
            this.cmb_pjManager.Name = "cmb_pjManager";
            this.cmb_pjManager.Size = new System.Drawing.Size(451, 28);
            this.cmb_pjManager.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(3, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 40);
            this.label11.TabIndex = 24;
            this.label11.Text = "项目经理：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(623, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "从excel导入";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(623, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "根据供应商查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(623, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "根据客户查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_supplier.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(166, 39);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(451, 28);
            this.cmb_supplier.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 36);
            this.label9.TabIndex = 9;
            this.label9.Text = "客户：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 40);
            this.label10.TabIndex = 11;
            this.label10.Text = "供应商：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Customer
            // 
            this.cmb_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Customer.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Customer.FormattingEnabled = true;
            this.cmb_Customer.Location = new System.Drawing.Point(166, 3);
            this.cmb_Customer.Name = "cmb_Customer";
            this.cmb_Customer.Size = new System.Drawing.Size(451, 29);
            this.cmb_Customer.TabIndex = 12;
            // 
            // btn_searchall
            // 
            this.btn_searchall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_searchall.Location = new System.Drawing.Point(166, 119);
            this.btn_searchall.Name = "btn_searchall";
            this.btn_searchall.Size = new System.Drawing.Size(451, 35);
            this.btn_searchall.TabIndex = 23;
            this.btn_searchall.Text = "查询总表";
            this.btn_searchall.UseVisualStyleBackColor = true;
            this.btn_searchall.Click += new System.EventHandler(this.btn_searchall_Click);
            // 
            // btn_unionSearch
            // 
            this.btn_unionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_unionSearch.Location = new System.Drawing.Point(3, 119);
            this.btn_unionSearch.Name = "btn_unionSearch";
            this.btn_unionSearch.Size = new System.Drawing.Size(157, 35);
            this.btn_unionSearch.TabIndex = 27;
            this.btn_unionSearch.Text = "联合查询";
            this.btn_unionSearch.UseVisualStyleBackColor = true;
            this.btn_unionSearch.Click += new System.EventHandler(this.btn_unionSearch_Click);
            // 
            // CmpPJFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CmpPJFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CmpPJFrm";
            this.Load += new System.EventHandler(this.CmpPJFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pjid;
        private System.Windows.Forms.TextBox txt_pjcustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pjstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pjmanager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pjdiscription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pjsupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pjnote;
        private System.Windows.Forms.TextBox txt_Projectid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mdy_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pjDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn pjManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn pjStatus;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Button btn_searchall;
        private System.Windows.Forms.Button btn_searchbyGM;
        private System.Windows.Forms.ComboBox cmb_pjManager;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_unionSearch;
    }
}