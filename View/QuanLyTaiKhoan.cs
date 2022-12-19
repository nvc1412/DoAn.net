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
using QuanLyCuaHangGiaDung.Controller;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class QuanLyTaiKhoan : Form
    {
        TaiKhoanController tk = new TaiKhoanController();

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaikhoan.DataSource = tk.getData();
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

            dgvTaikhoan.DataSource = tk.getData();
        }

        

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTk.Text == "" || txtMk.Text == "" || cbQuyen.Text=="" || txtNlmk.Text=="")
                {
                    MessageBox.Show("Không được để trống !!!");
                }
                else if(txtMk.Text != txtNlmk.Text)
                {
                    MessageBox.Show("Mật khẩu sai !!!");
                }
                else if (tk.getTK(txtTk.Text) > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
                else
                {
                    string Query = $"INSERT INTO TaiKhoan(TaiKhoan, MatKhau, Quyen) Values('{txtTk.Text}', '{tk.ToMD5(txtMk.Text)}', '{cbQuyen.Text}')";

                    int sl = tk.ThemSuaXoaTK(Query);
                    if (sl > 0)
                    {
                        lbThemthanhcong.Text = "Thêm mới thành công!";
                        MessageBox.Show("Thêm mới thành công!");
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
                else if (tk.checkTK(txtTaikhoan.Text, txtMatkhaucu.Text) == false)
                {
                    MessageBox.Show("Mật khẩu cũ sai !!!");
                }
                else if (txtMatkhaumoi.Text != txtNlmkmoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới sai !!!");
                }
                else
                {
                    string Query = $"UPDATE TaiKhoan SET MatKhau='{tk.ToMD5(txtMatkhaumoi.Text)}' WHERE TaiKhoan='{txtTaikhoan.Text}'";
                    int sl = tk.ThemSuaXoaTK(Query);
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string Query;
            if (rdTaiKhoan.Checked == true)
            {
                Query = $"SELECT * FROM TaiKhoan WHERE TaiKhoan LIKE '%{txtTimkiem.Text}%'";
            }
            else
            {
                Query = $"SELECT * FROM TaiKhoan WHERE Quyen LIKE '{txtTimkiem.Text}%'";
            }
            dgvTaikhoan.DataSource = tk.TimTK(Query);
        }


        string Taikhoan;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = $"DELETE FROM TaiKhoan WHERE TaiKhoan='{Taikhoan}'";
                int sl = tk.ThemSuaXoaTK(Query);
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
