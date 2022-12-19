namespace QuanLyCuaHangGiaDung.View
{
    partial class QuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySanPham));
            this.tabSanpham = new System.Windows.Forms.TabControl();
            this.tabDssanpham = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXuatexcel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenlsp = new System.Windows.Forms.TextBox();
            this.cbDvt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.cbLsp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSapxep = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabLoaisanpham = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoaLoai = new System.Windows.Forms.Button();
            this.btnXuatexcelLoai = new System.Windows.Forms.Button();
            this.btnSuaLoai = new System.Windows.Forms.Button();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvLoaisanpham = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenloai = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbSapxepLoai = new System.Windows.Forms.ComboBox();
            this.btnTimkiemLoai = new System.Windows.Forms.Button();
            this.txtTimkiemLoai = new System.Windows.Forms.TextBox();
            this.btnLammoiLoai = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.cbMancc = new System.Windows.Forms.ComboBox();
            this.tabSanpham.SuspendLayout();
            this.tabDssanpham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabLoaisanpham.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisanpham)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSanpham
            // 
            this.tabSanpham.Controls.Add(this.tabDssanpham);
            this.tabSanpham.Controls.Add(this.tabLoaisanpham);
            this.tabSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSanpham.Location = new System.Drawing.Point(0, 0);
            this.tabSanpham.Name = "tabSanpham";
            this.tabSanpham.SelectedIndex = 0;
            this.tabSanpham.Size = new System.Drawing.Size(1228, 672);
            this.tabSanpham.TabIndex = 1;
            this.tabSanpham.SelectedIndexChanged += new System.EventHandler(this.tabSanpham_SelectedIndexChanged);
            // 
            // tabDssanpham
            // 
            this.tabDssanpham.BackColor = System.Drawing.SystemColors.Info;
            this.tabDssanpham.Controls.Add(this.groupBox1);
            this.tabDssanpham.Controls.Add(this.groupBox4);
            this.tabDssanpham.Controls.Add(this.groupBox3);
            this.tabDssanpham.Controls.Add(this.groupBox2);
            this.tabDssanpham.Location = new System.Drawing.Point(4, 25);
            this.tabDssanpham.Name = "tabDssanpham";
            this.tabDssanpham.Padding = new System.Windows.Forms.Padding(3);
            this.tabDssanpham.Size = new System.Drawing.Size(1220, 643);
            this.tabDssanpham.TabIndex = 0;
            this.tabDssanpham.Text = "Danh sách sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.dgvSanpham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(304, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 447);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AllowUserToAddRows = false;
            this.dgvSanpham.AllowUserToDeleteRows = false;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanpham.Location = new System.Drawing.Point(3, 18);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.ReadOnly = true;
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(907, 426);
            this.dgvSanpham.TabIndex = 0;
            this.dgvSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXuatexcel);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(304, 519);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 121);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnXuatexcel
            // 
            this.btnXuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatexcel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXuatexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatexcel.Image")));
            this.btnXuatexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatexcel.Location = new System.Drawing.Point(649, 37);
            this.btnXuatexcel.Name = "btnXuatexcel";
            this.btnXuatexcel.Size = new System.Drawing.Size(156, 46);
            this.btnXuatexcel.TabIndex = 10;
            this.btnXuatexcel.Text = "Xuất Excel";
            this.btnXuatexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatexcel.UseVisualStyleBackColor = true;
            this.btnXuatexcel.Click += new System.EventHandler(this.btnXuatexcel_Click);
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
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(247, 37);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 46);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(428, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 46);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTenlsp);
            this.groupBox3.Controls.Add(this.cbDvt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTensp);
            this.groupBox3.Controls.Add(this.txtMasp);
            this.groupBox3.Controls.Add(this.cbLsp);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTaikhoan);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtGiaban);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 568);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm";
            // 
            // txtTenlsp
            // 
            this.txtTenlsp.Enabled = false;
            this.txtTenlsp.Location = new System.Drawing.Point(140, 146);
            this.txtTenlsp.Name = "txtTenlsp";
            this.txtTenlsp.Size = new System.Drawing.Size(118, 22);
            this.txtTenlsp.TabIndex = 15;
            // 
            // cbDvt
            // 
            this.cbDvt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDvt.FormattingEnabled = true;
            this.cbDvt.Items.AddRange(new object[] {
            "Bộ",
            "Chiếc"});
            this.cbDvt.Location = new System.Drawing.Point(140, 283);
            this.cbDvt.Name = "cbDvt";
            this.cbDvt.Size = new System.Drawing.Size(90, 24);
            this.cbDvt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(39, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(140, 174);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(118, 22);
            this.txtTensp.TabIndex = 3;
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(140, 65);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(90, 22);
            this.txtMasp.TabIndex = 1;
            // 
            // cbLsp
            // 
            this.cbLsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLsp.FormattingEnabled = true;
            this.cbLsp.Location = new System.Drawing.Point(140, 118);
            this.cbLsp.Name = "cbLsp";
            this.cbLsp.Size = new System.Drawing.Size(118, 24);
            this.cbLsp.TabIndex = 2;
            this.cbLsp.SelectedIndexChanged += new System.EventHandler(this.cbLsp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(34, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.AutoSize = true;
            this.txtTaikhoan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTaikhoan.Location = new System.Drawing.Point(60, 286);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(70, 16);
            this.txtTaikhoan.TabIndex = 14;
            this.txtTaikhoan.Text = "Đơn vị tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(73, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Giá bán:";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(140, 226);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(118, 22);
            this.txtGiaban.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(34, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbSapxep);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1214, 69);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(724, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sắp xếp:";
            // 
            // cbSapxep
            // 
            this.cbSapxep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSapxep.FormattingEnabled = true;
            this.cbSapxep.Items.AddRange(new object[] {
            "Giá bán tăng dần",
            "Giá bán giảm dần"});
            this.cbSapxep.Location = new System.Drawing.Point(812, 25);
            this.cbSapxep.Name = "cbSapxep";
            this.cbSapxep.Size = new System.Drawing.Size(135, 24);
            this.cbSapxep.TabIndex = 4;
            this.cbSapxep.SelectedIndexChanged += new System.EventHandler(this.cbSapxep_SelectedIndexChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(567, 12);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(120, 46);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimkiem.Location = new System.Drawing.Point(176, 22);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(351, 27);
            this.txtTimkiem.TabIndex = 2;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(1004, 12);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(131, 46);
            this.btnLammoi.TabIndex = 11;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(84, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm:";
            // 
            // tabLoaisanpham
            // 
            this.tabLoaisanpham.BackColor = System.Drawing.SystemColors.Info;
            this.tabLoaisanpham.Controls.Add(this.groupBox5);
            this.tabLoaisanpham.Controls.Add(this.groupBox6);
            this.tabLoaisanpham.Controls.Add(this.groupBox7);
            this.tabLoaisanpham.Controls.Add(this.groupBox8);
            this.tabLoaisanpham.Location = new System.Drawing.Point(4, 25);
            this.tabLoaisanpham.Name = "tabLoaisanpham";
            this.tabLoaisanpham.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaisanpham.Size = new System.Drawing.Size(1220, 643);
            this.tabLoaisanpham.TabIndex = 1;
            this.tabLoaisanpham.Text = "Loại sản phẩm";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox5.Controls.Add(this.btnXoaLoai);
            this.groupBox5.Controls.Add(this.btnXuatexcelLoai);
            this.groupBox5.Controls.Add(this.btnSuaLoai);
            this.groupBox5.Controls.Add(this.btnThemLoai);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(305, 504);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(912, 136);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoaLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLoai.Image")));
            this.btnXoaLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLoai.Location = new System.Drawing.Point(435, 43);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Size = new System.Drawing.Size(131, 46);
            this.btnXoaLoai.TabIndex = 5;
            this.btnXoaLoai.Text = "Xóa";
            this.btnXoaLoai.UseVisualStyleBackColor = true;
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // btnXuatexcelLoai
            // 
            this.btnXuatexcelLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatexcelLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXuatexcelLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatexcelLoai.Image")));
            this.btnXuatexcelLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatexcelLoai.Location = new System.Drawing.Point(647, 43);
            this.btnXuatexcelLoai.Name = "btnXuatexcelLoai";
            this.btnXuatexcelLoai.Size = new System.Drawing.Size(156, 46);
            this.btnXuatexcelLoai.TabIndex = 6;
            this.btnXuatexcelLoai.Text = "Xuất Excel";
            this.btnXuatexcelLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatexcelLoai.UseVisualStyleBackColor = true;
            this.btnXuatexcelLoai.Click += new System.EventHandler(this.btnXuatexcelLoai_Click);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuaLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLoai.Image")));
            this.btnSuaLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLoai.Location = new System.Drawing.Point(254, 43);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Size = new System.Drawing.Size(131, 46);
            this.btnSuaLoai.TabIndex = 4;
            this.btnSuaLoai.Text = "Sửa";
            this.btnSuaLoai.UseVisualStyleBackColor = true;
            this.btnSuaLoai.Click += new System.EventHandler(this.btnSuaLoai_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThemLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoai.Image")));
            this.btnThemLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLoai.Location = new System.Drawing.Point(78, 43);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(131, 46);
            this.btnThemLoai.TabIndex = 3;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvLoaisanpham);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(305, 72);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(912, 568);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách loại sản phẩm";
            // 
            // dgvLoaisanpham
            // 
            this.dgvLoaisanpham.AllowUserToAddRows = false;
            this.dgvLoaisanpham.AllowUserToDeleteRows = false;
            this.dgvLoaisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaisanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaisanpham.Location = new System.Drawing.Point(3, 18);
            this.dgvLoaisanpham.Name = "dgvLoaisanpham";
            this.dgvLoaisanpham.ReadOnly = true;
            this.dgvLoaisanpham.RowHeadersWidth = 51;
            this.dgvLoaisanpham.RowTemplate.Height = 24;
            this.dgvLoaisanpham.Size = new System.Drawing.Size(906, 547);
            this.dgvLoaisanpham.TabIndex = 11;
            this.dgvLoaisanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaisanpham_CellClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbMancc);
            this.groupBox7.Controls.Add(this.txtTenncc);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.txtMaloai);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.txtTenloai);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(3, 72);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(302, 568);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin loại sản phẩm";
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(150, 93);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(107, 22);
            this.txtMaloai.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(16, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã loại sản phẩm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(14, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tên loại sản phẩm:";
            // 
            // txtTenloai
            // 
            this.txtTenloai.Location = new System.Drawing.Point(150, 158);
            this.txtTenloai.Name = "txtTenloai";
            this.txtTenloai.Size = new System.Drawing.Size(107, 22);
            this.txtTenloai.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.cbSapxepLoai);
            this.groupBox8.Controls.Add(this.btnTimkiemLoai);
            this.groupBox8.Controls.Add(this.txtTimkiemLoai);
            this.groupBox8.Controls.Add(this.btnLammoiLoai);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1214, 69);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(733, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Sắp xếp:";
            // 
            // cbSapxepLoai
            // 
            this.cbSapxepLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSapxepLoai.FormattingEnabled = true;
            this.cbSapxepLoai.ItemHeight = 16;
            this.cbSapxepLoai.Items.AddRange(new object[] {
            "Mã loại tăng dần",
            "Tên loại tăng dần",
            "Mã loại giảm dần",
            "Tên loại giảm dần"});
            this.cbSapxepLoai.Location = new System.Drawing.Point(821, 25);
            this.cbSapxepLoai.Name = "cbSapxepLoai";
            this.cbSapxepLoai.Size = new System.Drawing.Size(135, 24);
            this.cbSapxepLoai.TabIndex = 10;
            this.cbSapxepLoai.SelectedIndexChanged += new System.EventHandler(this.cbSapxepLoai_SelectedIndexChanged);
            // 
            // btnTimkiemLoai
            // 
            this.btnTimkiemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTimkiemLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemLoai.Image")));
            this.btnTimkiemLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiemLoai.Location = new System.Drawing.Point(567, 12);
            this.btnTimkiemLoai.Name = "btnTimkiemLoai";
            this.btnTimkiemLoai.Size = new System.Drawing.Size(120, 46);
            this.btnTimkiemLoai.TabIndex = 9;
            this.btnTimkiemLoai.Text = "Tìm kiếm";
            this.btnTimkiemLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiemLoai.UseVisualStyleBackColor = true;
            this.btnTimkiemLoai.Click += new System.EventHandler(this.btnTimkiemLoai_Click);
            // 
            // txtTimkiemLoai
            // 
            this.txtTimkiemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemLoai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimkiemLoai.Location = new System.Drawing.Point(176, 22);
            this.txtTimkiemLoai.Name = "txtTimkiemLoai";
            this.txtTimkiemLoai.Size = new System.Drawing.Size(351, 27);
            this.txtTimkiemLoai.TabIndex = 8;
            // 
            // btnLammoiLoai
            // 
            this.btnLammoiLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoiLoai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLammoiLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoiLoai.Image")));
            this.btnLammoiLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoiLoai.Location = new System.Drawing.Point(1005, 12);
            this.btnLammoiLoai.Name = "btnLammoiLoai";
            this.btnLammoiLoai.Size = new System.Drawing.Size(131, 46);
            this.btnLammoiLoai.TabIndex = 7;
            this.btnLammoiLoai.Text = "Làm mới";
            this.btnLammoiLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoiLoai.UseVisualStyleBackColor = true;
            this.btnLammoiLoai.Click += new System.EventHandler(this.btnLammoiLoai_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(84, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tìm kiếm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(23, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã nhà cung cấp:";
            // 
            // txtTenncc
            // 
            this.txtTenncc.Enabled = false;
            this.txtTenncc.Location = new System.Drawing.Point(150, 244);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(107, 22);
            this.txtTenncc.TabIndex = 9;
            // 
            // cbMancc
            // 
            this.cbMancc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMancc.FormattingEnabled = true;
            this.cbMancc.Location = new System.Drawing.Point(150, 216);
            this.cbMancc.Name = "cbMancc";
            this.cbMancc.Size = new System.Drawing.Size(107, 24);
            this.cbMancc.TabIndex = 10;
            this.cbMancc.SelectedIndexChanged += new System.EventHandler(this.cbMancc_SelectedIndexChanged);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1228, 672);
            this.Controls.Add(this.tabSanpham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLySanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            this.tabSanpham.ResumeLayout(false);
            this.tabDssanpham.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabLoaisanpham.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisanpham)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSanpham;
        private System.Windows.Forms.TabPage tabDssanpham;
        private System.Windows.Forms.TabPage tabLoaisanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDvt;
        private System.Windows.Forms.ComboBox cbLsp;
        private System.Windows.Forms.Label txtTaikhoan;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXuatexcel;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSapxep;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenloai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnXuatexcelLoai;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.Button btnSuaLoai;
        private System.Windows.Forms.Button btnXoaLoai;
        private System.Windows.Forms.Button btnLammoiLoai;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvLoaisanpham;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbSapxepLoai;
        private System.Windows.Forms.Button btnTimkiemLoai;
        private System.Windows.Forms.TextBox txtTimkiemLoai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtTenlsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.ComboBox cbMancc;
    }
}