using QuanLyCuaHangGiaDung.Controller;
using QuanLyCuaHangGiaDung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class QuanLyNhanVien : Form
    {
        NhanVienController nv = new NhanVienController();
        Regex isValidInput = new Regex(@"^\d{9,11}$");
        Regex number = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            txtManv.Focus();
            dgvNhanvien.DataSource = nv.getData();
            cbTaikhoan.DisplayMember = "TaiKhoan";
            cbTaikhoan.DataSource = nv.getDatacombo();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void setNull()
        {
            txtTimkiem.Text = null;
            txtManv.Text = null;
            txtTennv.Text = null;
            dateNgaysinh.Text = null;
            cbGioitinh.Text = null;
            txtDiachi.Text = null;
            txtSdt.Text = null;
            txtHesoluong.Text = null;
            cbTaikhoan.Text = null;
            cbSapxep.Text = null;
            dgvNhanvien.DataSource = nv.getData();
            btnThem.Enabled = true;
            btnXuatexcel.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtManv.Enabled = true;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            setNull();
            txtManv.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "" || txtTennv.Text == "" || dateNgaysinh.Text == "" || cbGioitinh.Text == "" || 
                txtDiachi.Text == "" || txtSdt.Text == "" || txtHesoluong.Text == "" || cbTaikhoan.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (nv.getMaNV(txtManv.Text)>0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
            }
            else if (!isValidInput.IsMatch(txtSdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
            else if (!number.IsMatch(txtHesoluong.Text))
            {
                MessageBox.Show("Hệ số lương phải là số!");
            }
            else
            {
                string Query = $"INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Sdt, HeSoLuong, TaiKhoan)" +
                           $" Values(N'{txtManv.Text}', N'{txtTennv.Text}', '{dateNgaysinh.Text}', N'{cbGioitinh.Text}'," +
                           $" N'{txtDiachi.Text}', N'{txtSdt.Text}', '{txtHesoluong.Text}', N'{cbTaikhoan.Text}')";
                int sl = nv.ThemSuaXoaNV(Query);
                if (sl > 0)
                {
                    MessageBox.Show("Thêm mới thành công!");
                    setNull();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string Query = $"SELECT * FROM NhanVien WHERE MaNV LIKE N'%{txtTimkiem.Text}%' OR TenNV LIKE N'%{txtTimkiem.Text}%' " +
                    $"OR NgaySinh LIKE '%{txtTimkiem.Text}%' OR GioiTinh LIKE N'%{txtTimkiem.Text}%' OR DiaChi LIKE N'%{txtTimkiem.Text}%' " +
                    $"OR Sdt LIKE N'%{txtTimkiem.Text}%' OR HeSoLuong LIKE '%{txtTimkiem.Text}%' OR TaiKhoan LIKE N'%{txtTimkiem.Text}%'";
            dgvNhanvien.DataSource = nv.TimNV(Query);
        }

        private void cbSapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapxep = "MaNV";
            switch (cbSapxep.SelectedIndex)
            {
                case 0: sapxep = "MaNV"; break;
                case 1: sapxep = "TenNV"; break;
                case 2: sapxep = "HeSoLuong"; break;
                case 3: sapxep = "MaNV DESC"; break;
                case 4: sapxep = "TenNV DESC"; break;
                case 5: sapxep = "HeSoLuong DESC"; break;
                default: sapxep = "MaNV"; break;
            }
            dgvNhanvien.DataSource = nv.SapXepNV(sapxep);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "" || txtTennv.Text == "" || dateNgaysinh.Text == "" || cbGioitinh.Text == "" ||
                txtDiachi.Text == "" || txtSdt.Text == "" || txtHesoluong.Text == "" || cbTaikhoan.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (!isValidInput.IsMatch(txtSdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
            else if (!number.IsMatch(txtHesoluong.Text))
            {
                MessageBox.Show("Hệ số lương phải là số!");
            }
            else
            {
                string Query = $"UPDATE NhanVien SET TenNV=N'{txtTennv.Text}', NgaySinh='{dateNgaysinh.Text}'," +
                    $" GioiTinh=N'{cbGioitinh.Text}', DiaChi=N'{txtDiachi.Text}', Sdt=N'{txtSdt.Text}', HeSoLuong='{txtHesoluong.Text}'," +
                    $" TaiKhoan=N'{cbTaikhoan.Text}' WHERE MaNV=N'{txtManv.Text}'";
                int sl = nv.ThemSuaXoaNV(Query);
                if (sl > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    setNull();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnXuatexcel.Enabled = false;
            txtManv.Enabled = false;
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row >= 0)
                {
                    txtManv.Text = (string)dgvNhanvien.Rows[row].Cells["MaNV"].Value;
                    txtTennv.Text = (string)dgvNhanvien.Rows[row].Cells["TenNV"].Value;
                    dateNgaysinh.Text = dgvNhanvien.Rows[row].Cells["NgaySinh"].Value.ToString();
                    cbGioitinh.Text = (string)dgvNhanvien.Rows[row].Cells["GioiTinh"].Value;
                    txtDiachi.Text = (string)dgvNhanvien.Rows[row].Cells["DiaChi"].Value;
                    txtSdt.Text = (string)dgvNhanvien.Rows[row].Cells["Sdt"].Value;
                    txtHesoluong.Text = dgvNhanvien.Rows[row].Cells["HeSoLuong"].Value.ToString();
                    cbTaikhoan.Text = (string)dgvNhanvien.Rows[row].Cells["TaiKhoan"].Value;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Loi: "+ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Query = $"DELETE FROM NhanVien WHERE MaNV=N'{txtManv.Text}'";
            int sl = nv.ThemSuaXoaNV(Query);
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

        private void btnXuatexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dgvNhanvien và filename từ SaveFileDialog
                nv.ToExcel(dgvNhanvien, saveFileDialog1.FileName);
            }
        }
    }
}
