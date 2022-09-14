using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            try
            {
                List<Model.TK> data = new List<Model.TK>();

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = "SELECT * FROM TaiKhoan";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Model.TK obj = new Model.TK();
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
                    obj.MatKhau = (string)dr["MatKhau"];
                    obj.Quyen = (string)dr["Quyen"];
                    data.Add(obj);
                }
                conn.Close();
                dgvTaikhoan.DataSource = data;
            }catch (Exception ex)
            {
                MessageBox.Show("Loi: "+ex.Message);
            }
        }

        public void setNull()
        {
            txtTimkiem.Text = null;

            txtTk.Text = null;
            txtMk.Text = null;
            txtNlmk.Text = null;
            cbQuyen.Text = null;

            txtTaikhoan.Text = null;
            txtMatkhaucu.Text = null;
            txtMatkhaumoi.Text = null;
            txtNlmkmoi.Text = null;

            getData();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTk.Text == "" || txtMk.Text == "" || cbQuyen.Text=="" || txtNlmk.Text=="")
                {
                    MessageBox.Show("Không được để trống !!!");
                }else if(txtMk.Text != txtNlmk.Text)
                {
                    MessageBox.Show("Mật khẩu sai !!!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                    conn.Open();
                    string Query = $"INSERT INTO TaiKhoan(TaiKhoan, MatKhau, Quyen) Values('{txtTk.Text}', '{ToMD5(txtMk.Text)}', '{cbQuyen.Text}')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    int sl = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (sl > 0)
                    {
                        lbThemthanhcong.Text = "Thêm mới thành công!";
                        setNull();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại!");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        public string ToMD5(string str)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                result += buffer[i].ToString("x2");
            }
            return result;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtMk.PasswordChar = '\0';
                txtNlmk.PasswordChar = '\0';
            }
            else
            {
                txtMk.PasswordChar = '*';
                txtNlmk.PasswordChar = '*';
            }
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void btnLm_Click(object sender, EventArgs e)
        {
            setNull();
            lbThemthanhcong.Text = null;
        }

        private void btnLm2_Click(object sender, EventArgs e)
        {
            setNull();
            lbDoimatkhau.Text = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaikhoan.Text == "" || txtMatkhaucu.Text == "" || txtMatkhaumoi.Text == "" || txtNlmkmoi.Text == "")
                {
                    MessageBox.Show("Không được để trống !!!");
                }
                else if (checkTK(txtTaikhoan.Text, txtMatkhaucu.Text) == false)
                {
                    MessageBox.Show("Mật khẩu cũ sai !!!");
                }
                else if (txtMatkhaumoi.Text != txtNlmkmoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới sai !!!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                    conn.Open();
                    string Query = $"UPDATE TaiKhoan SET MatKhau='{ToMD5(txtMatkhaumoi.Text)}' WHERE TaiKhoan='{txtTaikhoan.Text}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    int sl = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (sl > 0)
                    {
                        lbDoimatkhau.Text = "Đổi mật khẩu thành công!";
                        setNull();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        public bool checkTK(string tk, string mk)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = '{tk}' and MatKhau = '{ToMD5(mk)}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }

            return false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Model.TK> data = new List<Model.TK>();

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query;
                if (rdTaiKhoan.Checked == true)
                {
                    Query = $"SELECT * FROM TaiKhoan WHERE TaiKhoan LIKE '%{txtTimkiem.Text}%'";
                }
                else
                {
                    Query = $"SELECT * FROM TaiKhoan WHERE Quyen LIKE '{txtTimkiem.Text}%'";
                }
                
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Model.TK obj = new Model.TK();
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
                    obj.MatKhau = (string)dr["MatKhau"];
                    obj.Quyen = (string)dr["Quyen"];
                    data.Add(obj);
                }
                conn.Close();
                dgvTaikhoan.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }


        string Taikhoan;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = $"DELETE FROM TaiKhoan WHERE TaiKhoan='{Taikhoan}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                if (sl > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    setNull();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void dgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row >= 0)
            {
                Taikhoan = (string)dgvTaikhoan.Rows[row].Cells["TaiKhoan"].Value;
            }
        }
    }
}
