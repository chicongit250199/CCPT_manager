namespace CCPT
{
    partial class kho
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maThietBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThietBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBaoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhMucBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.desktopAplicationDataSet1 = new CCPT.DesktopAplicationDataSet1();
            this.danhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatb = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTentb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoSerial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxBaohanh = new System.Windows.Forms.ComboBox();
            this.lblinfor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cbxphanloai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.danhMucTableAdapter1 = new CCPT.DesktopAplicationDataSet1TableAdapters.DanhMucTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopAplicationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThietBiDataGridViewTextBoxColumn,
            this.soSerialDataGridViewTextBoxColumn,
            this.loaiDataGridViewTextBoxColumn,
            this.tenThietBiDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.thoiGianBaoHanhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.danhMucBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(5, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditModeChanged += new System.EventHandler(this.kho_Load);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EnabledChanged += new System.EventHandler(this.dataGridView1_EnabledChanged);
            // 
            // maThietBiDataGridViewTextBoxColumn
            // 
            this.maThietBiDataGridViewTextBoxColumn.DataPropertyName = "MaThietBi";
            this.maThietBiDataGridViewTextBoxColumn.HeaderText = "Mã thiết bị";
            this.maThietBiDataGridViewTextBoxColumn.Name = "maThietBiDataGridViewTextBoxColumn";
            // 
            // soSerialDataGridViewTextBoxColumn
            // 
            this.soSerialDataGridViewTextBoxColumn.DataPropertyName = "SoSerial";
            this.soSerialDataGridViewTextBoxColumn.HeaderText = "Số Serial";
            this.soSerialDataGridViewTextBoxColumn.Name = "soSerialDataGridViewTextBoxColumn";
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loại";
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            // 
            // tenThietBiDataGridViewTextBoxColumn
            // 
            this.tenThietBiDataGridViewTextBoxColumn.DataPropertyName = "TenThietBi";
            this.tenThietBiDataGridViewTextBoxColumn.HeaderText = "Tên Thiết Bị";
            this.tenThietBiDataGridViewTextBoxColumn.Name = "tenThietBiDataGridViewTextBoxColumn";
            this.tenThietBiDataGridViewTextBoxColumn.Width = 150;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // thoiGianBaoHanhDataGridViewTextBoxColumn
            // 
            this.thoiGianBaoHanhDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianBaoHanh";
            this.thoiGianBaoHanhDataGridViewTextBoxColumn.HeaderText = "Bảo hành";
            this.thoiGianBaoHanhDataGridViewTextBoxColumn.Name = "thoiGianBaoHanhDataGridViewTextBoxColumn";
            // 
            // danhMucBindingSource1
            // 
            this.danhMucBindingSource1.DataMember = "DanhMuc";
            this.danhMucBindingSource1.DataSource = this.desktopAplicationDataSet1;
            // 
            // desktopAplicationDataSet1
            // 
            this.desktopAplicationDataSet1.DataSetName = "DesktopAplicationDataSet1";
            this.desktopAplicationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thiết bị";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMatb
            // 
            this.txtMatb.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatb.Location = new System.Drawing.Point(127, 20);
            this.txtMatb.Name = "txtMatb";
            this.txtMatb.Size = new System.Drawing.Size(219, 24);
            this.txtMatb.TabIndex = 1;
            this.txtMatb.TextChanged += new System.EventHandler(this.txtMatb_TextChanged);
            // 
            // txtDongia
            // 
            this.txtDongia.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(485, 57);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(204, 24);
            this.txtDongia.TabIndex = 4;
            this.txtDongia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thiết bị";
            // 
            // txtTentb
            // 
            this.txtTentb.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTentb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentb.Location = new System.Drawing.Point(485, 20);
            this.txtTentb.Name = "txtTentb";
            this.txtTentb.Size = new System.Drawing.Size(248, 24);
            this.txtTentb.TabIndex = 6;
            this.txtTentb.TextChanged += new System.EventHandler(this.txtTentb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSoSerial
            // 
            this.txtSoSerial.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSerial.Location = new System.Drawing.Point(127, 57);
            this.txtSoSerial.Name = "txtSoSerial";
            this.txtSoSerial.Size = new System.Drawing.Size(219, 24);
            this.txtSoSerial.TabIndex = 10;
            this.txtSoSerial.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Serial";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bảo hành";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(485, 91);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(248, 24);
            this.txtSoLuong.TabIndex = 13;
            // 
            // cbxLoai
            // 
            this.cbxLoai.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Items.AddRange(new object[] {
            "Màn hình",
            "Ổ cứng",
            "Pin",
            "Ram",
            "Phím",
            "Chuột"});
            this.cbxLoai.Location = new System.Drawing.Point(127, 90);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(219, 26);
            this.cbxLoai.TabIndex = 14;
            this.cbxLoai.Text = "Màn hình";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(543, 134);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 34);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.Yellow;
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnXoa.Location = new System.Drawing.Point(648, 134);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(85, 34);
            this.BtnXoa.TabIndex = 16;
            this.BtnXoa.Text = "Xoá";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Yellow;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(419, 134);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 34);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxBaohanh
            // 
            this.cbxBaohanh.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxBaohanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBaohanh.FormattingEnabled = true;
            this.cbxBaohanh.Items.AddRange(new object[] {
            "03",
            "06",
            "09",
            "12",
            "24",
            "36"});
            this.cbxBaohanh.Location = new System.Drawing.Point(127, 129);
            this.cbxBaohanh.Name = "cbxBaohanh";
            this.cbxBaohanh.Size = new System.Drawing.Size(160, 26);
            this.cbxBaohanh.TabIndex = 18;
            this.cbxBaohanh.Text = "03";
            // 
            // lblinfor
            // 
            this.lblinfor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfor.ForeColor = System.Drawing.Color.Red;
            this.lblinfor.Location = new System.Drawing.Point(33, 175);
            this.lblinfor.Name = "lblinfor";
            this.lblinfor.Size = new System.Drawing.Size(343, 20);
            this.lblinfor.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tháng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(695, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "VNĐ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.cbxphanloai);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 289);
            this.panel1.TabIndex = 22;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(22, 9);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 27;
            this.btnback.Text = "Quay lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CCPT.Properties.Resources.Start_Menu_Search_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(684, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(471, 7);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(197, 26);
            this.txtTimkiem.TabIndex = 25;
            // 
            // cbxphanloai
            // 
            this.cbxphanloai.DisplayMember = "Màn hình";
            this.cbxphanloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxphanloai.FormattingEnabled = true;
            this.cbxphanloai.Items.AddRange(new object[] {
            "Màn hình",
            "Ổ cứng",
            "Pin",
            "Ram",
            "Phím",
            "Chuột"});
            this.cbxphanloai.Location = new System.Drawing.Point(259, 9);
            this.cbxphanloai.Name = "cbxphanloai";
            this.cbxphanloai.Size = new System.Drawing.Size(152, 24);
            this.cbxphanloai.TabIndex = 24;
            this.cbxphanloai.Text = "Màn hình";
            this.cbxphanloai.SelectedIndexChanged += new System.EventHandler(this.cbxphanloai_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Phân Loại";
            // 
            // danhMucTableAdapter1
            // 
            this.danhMucTableAdapter1.ClearBeforeFill = true;
            // 
            // kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 499);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblinfor);
            this.Controls.Add(this.cbxBaohanh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cbxLoai);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoSerial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTentb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatb);
            this.Controls.Add(this.label1);
            this.Name = "kho";
            this.Text = "Quản lý Kho";
            this.Load += new System.EventHandler(this.kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopAplicationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource danhMucBindingSource;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatb;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTentb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbxLoai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxBaohanh;
        private System.Windows.Forms.Label lblinfor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThietBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThietBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianBaoHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ComboBox cbxphanloai;
        private System.Windows.Forms.Button btnback;
        private DesktopAplicationDataSet1 desktopAplicationDataSet1;
        private System.Windows.Forms.BindingSource danhMucBindingSource1;
        private DesktopAplicationDataSet1TableAdapters.DanhMucTableAdapter danhMucTableAdapter1;
    }
}