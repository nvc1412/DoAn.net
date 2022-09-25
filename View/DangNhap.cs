using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using QuanLyCuaHangGiaDung.Controller;

namespace QuanLyCuaHangGiaDung
{
    public partial class DangNhap : Form
    {
        DangNhapController  dn = new DangNhapController();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string Query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = '{txtTaikhoan.Text}' and MatKhau = '{dn.ToMD5(txtMatkhau.Text)}'";
            int sl = dn.DangNhap(Query);
            if (sl == 1)
            {
                View.HeThong frm = new View.HeThong(txtTaikhoan.Text);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
            }
        }
    }
}
