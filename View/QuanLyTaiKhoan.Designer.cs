namespace QuanLyCuaHangGiaDung.View
{
    partial class QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabTaotk = new System.Windows.Forms.TabPage();
            this.lbThemthanhcong = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLm = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNlmk = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabDstk = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.rdTaiKhoan = new System.Windows.Forms.RadioButton();
            this.rdQuyen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTk = new System.Windows.Forms.TabControl();
            this.tabDmk = new System.Windows.Forms.TabPage();
            this.lbDoimatkhau = new System.Windows.Forms.Label();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLm2 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtNlmkmoi = new System.Windows.Forms.TextBox();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabTaotk.SuspendLayout();
            this.tabDstk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabTk.SuspendLayout();
            this.tabDmk.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTaotk
            // 
            this.tabTaotk.BackColor = System.Drawing.SystemColors.Info;
            this.tabTaotk.Controls.Add(this.lbThemthanhcong);
            this.tabTaotk.Controls.Add(this.chkShowPassword);
            this.tabTaotk.Controls.Add(this.btnLm);
            this.tabTaotk.Controls.Add(this.btnTao);
            this.tabTaotk.Controls.Add(this.cbQuyen);
            this.tabTaotk.Controls.Add(this.label1);
            this.tabTaotk.Controls.Add(this.txtNlmk);
            this.tabTaotk.Controls.Add(this.txtMk);
            this.tabTaotk.Controls.Add(this.txtTk);
            this.tabTaotk.Controls.Add(this.label4);
            this.tabTaotk.Controls.Add(this.label5);
            this.tabTaotk.Controls.Add(this.label6);
            this.tabTaotk.Location = new System.Drawing.Point(4, 25);
            this.tabTaotk.Name = "tabTaotk";
            this.tabTaotk.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaotk.Size = new System.Drawing.Size(974, 550);
            this.tabTaotk.TabIndex = 2;
            this.tabTaotk.Text = "Tạo tài khoản";
            // 
            // lbThemthanhcong
            // 
            this.lbThemthanhcong.AutoSize = true;
            this.lbThemthanhcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemthanhcong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbThemthanhcong.Location = new System.Drawing.Point(325, 23);
            this.lbThemthanhcong.Name = "lbThemthanhcong";
            this.lbThemthanhcong.Size = new System.Drawing.Size(0, 38);
            this.lbThemthanhcong.TabIndex = 18;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.Black;
            this.chkShowPassword.Location = new System.Drawing.Point(576, 201);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(184, 29);
            this.chkShowPassword.TabIndex = 17;
            this.chkShowPassword.Text = "Hiển thị mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnLm
            // 
            this.btnLm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLm.Image = ((System.Drawing.Image)(resources.GetObject("btnLm.Image")));
            this.btnLm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLm.Location = new System.Drawing.Point(509, 386);
            this.btnLm.Name = "btnLm";
            this.btnLm.Size = new System.Drawing.Size(154, 61);
            this.btnLm.TabIndex = 16;
            this.btnLm.Text = "Làm mới";
            this.btnLm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLm.UseVisualStyleBackColor = true;
            this.btnLm.Click += new System.EventHandler(this.btnLm_Click);
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            this.btnTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTao.Location = new System.Drawing.Point(261, 386);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(154, 61);
            this.btnTao.TabIndex = 15;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cbQuyen
            // 
            this.cbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "admin",
            "nhân viên"});
            this.cbQuyen.Location = new System.Drawing.Point(364, 299);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(396, 33);
            this.cbQuyen.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(146, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quyền:";
            // 
            // txtNlmk
            // 
            this.txtNlmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNlmk.Location = new System.Drawing.Point(364, 236);
            this.txtNlmk.Name = "txtNlmk";
            this.txtNlmk.PasswordChar = '*';
            this.txtNlmk.Size = new System.Drawing.Size(396, 30);
            this.txtNlmk.TabIndex = 11;
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(364, 165);
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '*';
            this.txtMk.Size = new System.Drawing.Size(396, 30);
            this.txtMk.TabIndex = 9;
            // 
            // txtTk
            // 
            this.txtTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(364, 97);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(396, 30);
            this.txtTk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(146, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(146, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(146, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên tài khoản:";
            // 
            // tabDstk
            // 
            this.tabDstk.BackColor = System.Drawing.SystemColors.Info;
            this.tabDstk.Controls.Add(this.groupBox1);
            this.tabDstk.Controls.Add(this.groupBox2);
            this.tabDstk.Location = new System.Drawing.Point(4, 25);
            this.tabDstk.Name = "tabDstk";
            this.tabDstk.Padding = new System.Windows.Forms.Padding(3);
            this.tabDstk.Size = new System.Drawing.Size(974, 550);
            this.tabDstk.TabIndex = 1;
            this.tabDstk.Text = "Danh sách tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTaikhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 404);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // dgvTaikhoan
            // 
            this.dgvTaikhoan.AllowUserToAddRows = false;
            this.dgvTaikhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaikhoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaikhoan.Location = new System.Drawing.Point(3, 18);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.ReadOnly = true;
            this.dgvTaikhoan.RowHeadersWidth = 51;
            this.dgvTaikhoan.RowTemplate.Height = 24;
            this.dgvTaikhoan.Size = new System.Drawing.Size(962, 383);
            this.dgvTaikhoan.TabIndex = 0;
            this.dgvTaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaikhoan_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.rdTaiKhoan);
            this.groupBox2.Controls.Add(this.rdQuyen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(793, 38);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(131, 46);
            this.btnLammoi.TabIndex = 7;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(416, 38);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(120, 46);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(619, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 46);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimkiem.Location = new System.Drawing.Point(128, 48);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(268, 27);
            this.txtTimkiem.TabIndex = 2;
            // 
            // rdTaiKhoan
            // 
            this.rdTaiKhoan.AutoSize = true;
            this.rdTaiKhoan.Checked = true;
            this.rdTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTaiKhoan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdTaiKhoan.Location = new System.Drawing.Point(52, 98);
            this.rdTaiKhoan.Name = "rdTaiKhoan";
            this.rdTaiKhoan.Size = new System.Drawing.Size(127, 22);
            this.rdTaiKhoan.TabIndex = 4;
            this.rdTaiKhoan.TabStop = true;
            this.rdTaiKhoan.Text = "Theo tài khoản";
            this.rdTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // rdQuyen
            // 
            this.rdQuyen.AutoSize = true;
            this.rdQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdQuyen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdQuyen.Location = new System.Drawing.Point(232, 98);
            this.rdQuyen.Name = "rdQuyen";
            this.rdQuyen.Size = new System.Drawing.Size(106, 22);
            this.rdQuyen.TabIndex = 5;
            this.rdQuyen.Text = "Theo quyền";
            this.rdQuyen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm:";
            // 
            // tabTk
            // 
            this.tabTk.Controls.Add(this.tabDstk);
            this.tabTk.Controls.Add(this.tabTaotk);
            this.tabTk.Controls.Add(this.tabDmk);
            this.tabTk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTk.Location = new System.Drawing.Point(0, 0);
            this.tabTk.Name = "tabTk";
            this.tabTk.SelectedIndex = 0;
            this.tabTk.Size = new System.Drawing.Size(982, 579);
            this.tabTk.TabIndex = 0;
            // 
            // tabDmk
            // 
            this.tabDmk.BackColor = System.Drawing.SystemColors.Info;
            this.tabDmk.Controls.Add(this.lbDoimatkhau);
            this.tabDmk.Controls.Add(this.txtMatkhaumoi);
            this.tabDmk.Controls.Add(this.label3);
            this.tabDmk.Controls.Add(this.btnLm2);
            this.tabDmk.Controls.Add(this.btnLuu);
            this.tabDmk.Controls.Add(this.txtNlmkmoi);
            this.tabDmk.Controls.Add(this.txtMatkhaucu);
            this.tabDmk.Controls.Add(this.txtTaikhoan);
            this.tabDmk.Controls.Add(this.label7);
            this.tabDmk.Controls.Add(this.label8);
            this.tabDmk.Controls.Add(this.label9);
            this.tabDmk.Location = new System.Drawing.Point(4, 25);
            this.tabDmk.Name = "tabDmk";
            this.tabDmk.Padding = new System.Windows.Forms.Padding(3);
            this.tabDmk.Size = new System.Drawing.Size(974, 550);
            this.tabDmk.TabIndex = 3;
            this.tabDmk.Text = "Đổi mật khẩu";
            // 
            // lbDoimatkhau
            // 
            this.lbDoimatkhau.AutoSize = true;
            this.lbDoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbDoimatkhau.Location = new System.Drawing.Point(330, 34);
            this.lbDoimatkhau.Name = "lbDoimatkhau";
            this.lbDoimatkhau.Size = new System.Drawing.Size(0, 38);
            this.lbDoimatkhau.TabIndex = 29;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhaumoi.Location = new System.Drawing.Point(402, 251);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(396, 30);
            this.txtMatkhaumoi.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(162, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // btnLm2
            // 
            this.btnLm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLm2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLm2.Image = ((System.Drawing.Image)(resources.GetObject("btnLm2.Image")));
            this.btnLm2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLm2.Location = new System.Drawing.Point(525, 406);
            this.btnLm2.Name = "btnLm2";
            this.btnLm2.Size = new System.Drawing.Size(154, 61);
            this.btnLm2.TabIndex = 26;
            this.btnLm2.Text = "Làm mới";
            this.btnLm2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLm2.UseVisualStyleBackColor = true;
            this.btnLm2.Click += new System.EventHandler(this.btnLm2_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(277, 406);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(154, 61);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNlmkmoi
            // 
            this.txtNlmkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNlmkmoi.Location = new System.Drawing.Point(402, 314);
            this.txtNlmkmoi.Name = "txtNlmkmoi";
            this.txtNlmkmoi.Size = new System.Drawing.Size(396, 30);
            this.txtNlmkmoi.TabIndex = 22;
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhaucu.Location = new System.Drawing.Point(402, 185);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(396, 30);
            this.txtMatkhaucu.TabIndex = 20;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(402, 117);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(396, 30);
            this.txtTaikhoan.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(162, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nhập lại mật khẩu mới:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(162, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mật khẩu cũ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(162, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên tài khoản:";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(982, 579);
            this.Controls.Add(this.tabTk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.tabTaotk.ResumeLayout(false);
            this.tabTaotk.PerformLayout();
            this.tabDstk.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabTk.ResumeLayout(false);
            this.tabDmk.ResumeLayout(false);
            this.tabDmk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabTaotk;
        private System.Windows.Forms.Button btnLm;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNlmk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabDstk;
        private System.Windows.Forms.TabControl tabTk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdQuyen;
        private System.Windows.Forms.RadioButton rdTaiKhoan;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TabPage tabDmk;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLm2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtNlmkmoi;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTaikhoan;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lbThemthanhcong;
        private System.Windows.Forms.Label lbDoimatkhau;
    }
}