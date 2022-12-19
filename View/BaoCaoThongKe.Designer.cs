namespace QuanLyCuaHangGiaDung.View
{
    partial class BaoCaoThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoThongKe));
            this.tabBaocaothongke = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbtext = new System.Windows.Forms.Label();
            this.lbDoanhthu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.btnXuatexcel = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.txtSongaylam = new System.Windows.Forms.TextBox();
            this.txtPhucap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThangluong = new System.Windows.Forms.ComboBox();
            this.lbThuclinh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLammoiBL = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoabl = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbMabl = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMabl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabBaocaothongke.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBaocaothongke
            // 
            this.tabBaocaothongke.Controls.Add(this.tabPage1);
            this.tabBaocaothongke.Controls.Add(this.tabPage2);
            this.tabBaocaothongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBaocaothongke.Location = new System.Drawing.Point(0, 0);
            this.tabBaocaothongke.Name = "tabBaocaothongke";
            this.tabBaocaothongke.SelectedIndex = 0;
            this.tabBaocaothongke.Size = new System.Drawing.Size(1110, 675);
            this.tabBaocaothongke.TabIndex = 0;
            this.tabBaocaothongke.SelectedIndexChanged += new System.EventHandler(this.tabBaocaothongke_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê doanh thu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvThongke);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1096, 490);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvThongke
            // 
            this.dgvThongke.AllowUserToAddRows = false;
            this.dgvThongke.AllowUserToDeleteRows = false;
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongke.Location = new System.Drawing.Point(3, 18);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.ReadOnly = true;
            this.dgvThongke.RowHeadersWidth = 51;
            this.dgvThongke.RowTemplate.Height = 24;
            this.dgvThongke.Size = new System.Drawing.Size(1090, 469);
            this.dgvThongke.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbtext);
            this.groupBox2.Controls.Add(this.lbDoanhthu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 582);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext.Location = new System.Drawing.Point(260, 18);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(230, 29);
            this.lbtext.TabIndex = 1;
            this.lbtext.Text = "Doanh thu cửa hàng:";
            // 
            // lbDoanhthu
            // 
            this.lbDoanhthu.AutoSize = true;
            this.lbDoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhthu.ForeColor = System.Drawing.Color.Red;
            this.lbDoanhthu.Location = new System.Drawing.Point(507, 18);
            this.lbDoanhthu.Name = "lbDoanhthu";
            this.lbDoanhthu.Size = new System.Drawing.Size(26, 29);
            this.lbDoanhthu.TabIndex = 0;
            this.lbDoanhthu.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.dateNgay);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.cbThang);
            this.groupBox1.Controls.Add(this.rdThang);
            this.groupBox1.Controls.Add(this.btnXuatexcel);
            this.groupBox1.Controls.Add(this.btnThongke);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(939, 19);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(131, 51);
            this.btnLammoi.TabIndex = 21;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // dateNgay
            // 
            this.dateNgay.CustomFormat = "MM/dd/yyyy";
            this.dateNgay.Enabled = false;
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgay.Location = new System.Drawing.Point(355, 36);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(135, 22);
            this.dateNgay.TabIndex = 20;
            this.dateNgay.Value = new System.DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(256, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 20);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Theo ngày";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rdThang_CheckedChanged);
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(134, 34);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(75, 24);
            this.cbThang.TabIndex = 13;
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Checked = true;
            this.rdThang.Location = new System.Drawing.Point(20, 35);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(96, 20);
            this.rdThang.TabIndex = 12;
            this.rdThang.TabStop = true;
            this.rdThang.Text = "Theo tháng";
            this.rdThang.UseVisualStyleBackColor = true;
            this.rdThang.CheckedChanged += new System.EventHandler(this.rdThang_CheckedChanged);
            // 
            // btnXuatexcel
            // 
            this.btnXuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatexcel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXuatexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatexcel.Image")));
            this.btnXuatexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatexcel.Location = new System.Drawing.Point(777, 19);
            this.btnXuatexcel.Name = "btnXuatexcel";
            this.btnXuatexcel.Size = new System.Drawing.Size(156, 51);
            this.btnXuatexcel.TabIndex = 11;
            this.btnXuatexcel.Text = "Xuất Excel";
            this.btnXuatexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatexcel.UseVisualStyleBackColor = true;
            this.btnXuatexcel.Click += new System.EventHandler(this.btnXuatexcel_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.Coral;
            this.btnThongke.Location = new System.Drawing.Point(633, 19);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(138, 51);
            this.btnThongke.TabIndex = 0;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bảng lương nhân viên";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox8.Controls.Add(this.txtThuong);
            this.groupBox8.Controls.Add(this.txtSongaylam);
            this.groupBox8.Controls.Add(this.txtPhucap);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.cbThangluong);
            this.groupBox8.Controls.Add(this.lbThuclinh);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.txtTaikhoan);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.txtPhat);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox8.Location = new System.Drawing.Point(776, 91);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(323, 448);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chi tiết lương";
            // 
            // txtThuong
            // 
            this.txtThuong.Location = new System.Drawing.Point(145, 136);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(98, 22);
            this.txtThuong.TabIndex = 28;
            // 
            // txtSongaylam
            // 
            this.txtSongaylam.Location = new System.Drawing.Point(145, 91);
            this.txtSongaylam.Name = "txtSongaylam";
            this.txtSongaylam.Size = new System.Drawing.Size(98, 22);
            this.txtSongaylam.TabIndex = 27;
            // 
            // txtPhucap
            // 
            this.txtPhucap.Location = new System.Drawing.Point(145, 227);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.Size = new System.Drawing.Size(98, 22);
            this.txtPhucap.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(87, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tháng:";
            // 
            // cbThangluong
            // 
            this.cbThangluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThangluong.FormattingEnabled = true;
            this.cbThangluong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThangluong.Location = new System.Drawing.Point(145, 38);
            this.cbThangluong.Name = "cbThangluong";
            this.cbThangluong.Size = new System.Drawing.Size(98, 24);
            this.cbThangluong.TabIndex = 24;
            // 
            // lbThuclinh
            // 
            this.lbThuclinh.AutoSize = true;
            this.lbThuclinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuclinh.ForeColor = System.Drawing.Color.Lime;
            this.lbThuclinh.Location = new System.Drawing.Point(111, 315);
            this.lbThuclinh.Name = "lbThuclinh";
            this.lbThuclinh.Size = new System.Drawing.Size(32, 20);
            this.lbThuclinh.TabIndex = 23;
            this.lbThuclinh.Text = "0 đ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(111, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "THỰC LĨNH:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(77, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Phụ cấp:";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.AutoSize = true;
            this.txtTaikhoan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTaikhoan.Location = new System.Drawing.Point(99, 189);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(37, 16);
            this.txtTaikhoan.TabIndex = 14;
            this.txtTaikhoan.Text = "Phạt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(80, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Thưởng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(51, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số ngày làm:";
            // 
            // txtPhat
            // 
            this.txtPhat.Location = new System.Drawing.Point(145, 186);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.Size = new System.Drawing.Size(98, 22);
            this.txtPhat.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dgvBangLuong);
            this.groupBox7.Location = new System.Drawing.Point(200, 91);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(570, 445);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin chi tiết";
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangLuong.Location = new System.Drawing.Point(3, 18);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.RowTemplate.Height = 24;
            this.dgvBangLuong.Size = new System.Drawing.Size(564, 424);
            this.dgvBangLuong.TabIndex = 0;
            this.dgvBangLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangLuong_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnThem);
            this.groupBox6.Controls.Add(this.btnLuu);
            this.groupBox6.Controls.Add(this.btnXoa);
            this.groupBox6.Controls.Add(this.btnLammoiBL);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(194, 539);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(905, 104);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(71, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 46);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(247, 37);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(131, 46);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(428, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 46);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLammoiBL
            // 
            this.btnLammoiBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoiBL.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLammoiBL.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoiBL.Image")));
            this.btnLammoiBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoiBL.Location = new System.Drawing.Point(639, 37);
            this.btnLammoiBL.Name = "btnLammoiBL";
            this.btnLammoiBL.Size = new System.Drawing.Size(131, 46);
            this.btnLammoiBL.TabIndex = 7;
            this.btnLammoiBL.Text = "Làm mới";
            this.btnLammoiBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoiBL.UseVisualStyleBackColor = true;
            this.btnLammoiBL.Click += new System.EventHandler(this.btnLammoiBL_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnXoabl);
            this.groupBox5.Controls.Add(this.btnTimKiem);
            this.groupBox5.Controls.Add(this.cbMabl);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(3, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 552);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // btnXoabl
            // 
            this.btnXoabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoabl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoabl.Image = ((System.Drawing.Image)(resources.GetObject("btnXoabl.Image")));
            this.btnXoabl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoabl.Location = new System.Drawing.Point(12, 217);
            this.btnXoabl.Name = "btnXoabl";
            this.btnXoabl.Size = new System.Drawing.Size(159, 46);
            this.btnXoabl.TabIndex = 11;
            this.btnXoabl.Text = "Xóa Lương";
            this.btnXoabl.UseVisualStyleBackColor = true;
            this.btnXoabl.Click += new System.EventHandler(this.btnXoabl_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(12, 113);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(159, 46);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbMabl
            // 
            this.cbMabl.FormattingEnabled = true;
            this.cbMabl.Location = new System.Drawing.Point(38, 60);
            this.cbMabl.Name = "cbMabl";
            this.cbMabl.Size = new System.Drawing.Size(108, 24);
            this.cbMabl.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtMabl);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTennv);
            this.groupBox4.Controls.Add(this.cbManv);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1096, 88);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin bảng lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(102, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã bảng lương:";
            // 
            // txtMabl
            // 
            this.txtMabl.Location = new System.Drawing.Point(216, 34);
            this.txtMabl.Name = "txtMabl";
            this.txtMabl.Size = new System.Drawing.Size(90, 22);
            this.txtMabl.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(339, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // txtTennv
            // 
            this.txtTennv.Enabled = false;
            this.txtTennv.Location = new System.Drawing.Point(674, 34);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(177, 22);
            this.txtTennv.TabIndex = 17;
            // 
            // cbManv
            // 
            this.cbManv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(445, 34);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(81, 24);
            this.cbManv.TabIndex = 18;
            this.cbManv.SelectedIndexChanged += new System.EventHandler(this.cbManv_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(574, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên nhân viên:";
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1110, 675);
            this.Controls.Add(this.tabBaocaothongke);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCaoThongKe";
            this.Text = "Báo cáo thông kê";
            this.tabBaocaothongke.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBaocaothongke;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.Label lbDoanhthu;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.Button btnXuatexcel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMabl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoabl;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLammoiBL;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lbThuclinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtTaikhoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThangluong;
        private System.Windows.Forms.TextBox txtThuong;
        private System.Windows.Forms.TextBox txtSongaylam;
        private System.Windows.Forms.TextBox txtPhucap;
        private System.Windows.Forms.ComboBox cbMabl;
    }
}