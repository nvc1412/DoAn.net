using QuanLyCuaHangGiaDung.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class QuanLyKhachHang : Form
    {
        KhachHangController kh = new KhachHangController();
        Regex isValidInput = new Regex(@"^\d{9,11}$");
        Regex number = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            txtMakh.Focus();
            dgvKhachhang.DataSource = kh.getData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void setNull()
        {
            txtTimkiem.Text = null;
            txtMakh.Text = null;
            txtTenkh.Text = null;
            txtDiachi.Text = null;
            txtSdt.Text = null;
            cbSapxep.Text = null;
            dgvKhachhang.DataSource = kh.getData();
            btnThem.Enabled = true;
            btnXuatexcel.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMakh.Enabled = true;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            setNull();
            txtMakh.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMakh.Text == "" || txtTenkh.Text == "" || txtDiachi.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (kh.getMaKH(txtMakh.Text) > 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
            }
            else if (!isValidInput.IsMatch(txtSdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
            else
            {
                string Query = $"INSERT INTO KhachHang(MaKH, TenKH, DiaChi, Sdt) Values(N'{txtMakh.Text}', N'{txtTenkh.Text}', N'{txtDiachi.Text}', N'{txtSdt.Text}')";
                int sl = kh.ThemSuaXoaKH(Query);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMakh.Text == "" || txtTenkh.Text == "" || txtDiachi.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (!isValidInput.IsMatch(txtSdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
            else
            {
                string Query = $"UPDATE KhachHang SET TenKH=N'{txtTenkh.Text}', DiaChi=N'{txtDiachi.Text}', Sdt=N'{txtSdt.Text}' WHERE MaKH=N'{txtMakh.Text}'";
                int sl = kh.ThemSuaXoaKH(Query);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Query = $"DELETE FROM KhachHang WHERE MaKH=N'{txtMakh.Text}'";
            int sl = kh.ThemSuaXoaKH(Query);
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
                kh.ToExcel(dgvKhachhang, saveFileDialog1.FileName);
            }
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnXuatexcel.Enabled = false;
            txtMakh.Enabled = false;
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row >= 0)
                {
                    txtMakh.Text = (string)dgvKhachhang.Rows[row].Cells["MaKH"].Value;
                    txtTenkh.Text = (string)dgvKhachhang.Rows[row].Cells["TenKH"].Value;
                    txtDiachi.Text = (string)dgvKhachhang.Rows[row].Cells["DiaChi"].Value;
                    txtSdt.Text = (string)dgvKhachhang.Rows[row].Cells["Sdt"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string Query = $"SELECT * FROM KhachHang WHERE MaKH LIKE N'%{txtTimkiem.Text}%' OR TenKH LIKE N'%{txtTimkiem.Text}%'" +
                $" OR DiaChi LIKE N'%{txtTimkiem.Text}%' OR Sdt LIKE N'%{txtTimkiem.Text}%'";
            dgvKhachhang.DataSource = kh.TimKH(Query);
        }

        private void cbSapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapxep = "MaKH";
            switch (cbSapxep.SelectedIndex)
            {
                case 0: sapxep = "MaKH"; break;
                case 1: sapxep = "MaKH DESC"; break;
                default: sapxep = "MaKH"; break;
            }
            dgvKhachhang.DataSource = kh.SapXepKH(sapxep);
        }
    }
}
