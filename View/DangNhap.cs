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

namespace QuanLyCuaHangGiaDung
{
    public partial class DangNhap : Form
    {
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
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = '{txtTaikhoan.Text}' and MatKhau = '{ToMD5(txtMatkhau.Text)}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
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
            }catch (Exception ex)
            {
                MessageBox.Show("Loi: "+ex.Message);
            }
        }

        public string ToMD5(string str)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for(int i=0; i< buffer.Length; i++)
            {
                result += buffer[i].ToString("x2");
            }
            return result;
        }
    }
}
