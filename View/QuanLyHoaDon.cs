using QuanLyCuaHangGiaDung.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class QuanLyHoaDon : Form
    {
        HoaDonController hd = new HoaDonController();
        Regex number = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");

        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        public void setkhoa()
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            txtMahd.Enabled = false;
            cbMasp.DataSource = hd.getDatacomboSP();
            txtSoluong.Text = null;
            cbManv.Enabled = false;
            cbMakh.Enabled = false;
            dateNgayban.Enabled = false;
            dgvHoadon.DataSource = hd.getDataHD(txtMahd.Text);

            CultureInfo culture = new CultureInfo("vi-VN");
            lbTongtien.Text = hd.getTongTien(txtMahd.Text).ToString("c", culture);
        }

        private void cbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTennv.Text = hd.getTenNV(cbManv.Text);
        }

        private void cbMakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenkh.Text = hd.getTenKH(cbMakh.Text);
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            cbManv.DisplayMember = "MaNV";
            cbManv.DataSource = hd.getDatacomboNV();

            cbMakh.DisplayMember = "MaKH";
            cbMakh.DataSource = hd.getDatacomboKH();

            cbMasp.DisplayMember = "MaSP";
            cbMasp.DataSource = hd.getDatacomboSP();

            cbMahd.DisplayMember = "Mahd";
            cbMahd.DataSource = hd.getDatacomboHD();
        }

        private void cbMasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTensp.Text = hd.getTenSP(cbMasp.Text);
            txtDvt.Text = hd.getDVT(cbMasp.Text);
            txtDongia.Text = hd.getDonGia(cbMasp.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMahd.Text == "" || dateNgayban.Text == "" || cbManv.Text == "" || txtSoluong.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (!number.IsMatch(txtSoluong.Text))
            {
                MessageBox.Show("Số lượng phải là số!");
            }
            else if (hd.getMaHD(txtMahd.Text) > 0)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!");
            }
            else
            {
                string Query = $"INSERT INTO HoaDon(MaHD, NgayBan, MaNV, MaKH) Values(N'{txtMahd.Text}', N'{dateNgayban.Text}', N'{cbManv.Text}', N'{cbMakh.Text}')" +
                    $"INSERT INTO CTHoaDon(MaHD, MaSP, SoLuong, DonGia) Values(N'{txtMahd.Text}', N'{cbMasp.Text}', N'{txtSoluong.Text}', N'{txtDongia.Text}')";
                int sl = hd.ThemSuaXoaHD(Query);
                if (sl > 0)
                {
                    MessageBox.Show("Thêm mới thành công!");
                    setkhoa();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMahd.Text == "" || dateNgayban.Text == "" || cbManv.Text == "" || txtSoluong.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (!number.IsMatch(txtSoluong.Text))
            {
                MessageBox.Show("Số lượng phải là số!");
            }
            else if (hd.getMaSP(cbMasp.Text, txtMahd.Text) > 0)
            {
                MessageBox.Show("Mã sản phẩm đã được thêm!");
            }
            else
            {
                string Query = $"INSERT INTO CTHoaDon(MaHD, MaSP, SoLuong, DonGia) Values(N'{txtMahd.Text}', N'{cbMasp.Text}', N'{txtSoluong.Text}', N'{txtDongia.Text}')";
                int sl = hd.ThemSuaXoaHD(Query);
                if (sl > 0)
                {
                    MessageBox.Show("Thêm mới thành công!");
                    setkhoa();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtMahd.Enabled = true;
            cbMasp.DataSource = hd.getDatacomboSP();
            cbManv.DataSource = hd.getDatacomboNV();
            cbMahd.DataSource = hd.getDatacomboHD();
            txtSoluong.Text = null;
            txtMahd.Text = null;
            cbManv.Enabled = true;
            cbMakh.Enabled = true;
            dateNgayban.Enabled = true;
            dgvHoadon.DataSource = null;
            lbTongtien.Text = "0 đ";
            txtMahd.Focus();
        }

        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row >= 0)
                {
                    txtMahd.Text = (string)dgvHoadon.Rows[row].Cells["MaHD"].Value;
                    dateNgayban.Text = dgvHoadon.Rows[row].Cells["NgayBan"].Value.ToString();
                    cbManv.Text = (string)dgvHoadon.Rows[row].Cells["MaNV"].Value;
                    cbMasp.Text = (string)dgvHoadon.Rows[row].Cells["MaSP"].Value;
                    txtSoluong.Text = dgvHoadon.Rows[row].Cells["SoLuong"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Query = $"DELETE FROM CTHoaDon WHERE MaHD = N'{txtMahd.Text}' AND MaSP = N'{cbMasp.Text}'";
            int sl = hd.ThemSuaXoaHD(Query);
            if (sl > 0)
            {
                MessageBox.Show("Xóa thành công!");
                setkhoa();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            View.InHoaDon frm = new View.InHoaDon(txtMahd.Text);
            frm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtMahd.Text = cbMahd.Text;
            dgvHoadon.DataSource = hd.getDataHD(cbMahd.Text);
            CultureInfo culture = new CultureInfo("vi-VN");
            lbTongtien.Text = hd.getTongTien(cbMahd.Text).ToString("c", culture);
            setkhoa();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if(cbMahd.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (hd.getMaHD(cbMahd.Text) <= 0)
            {
                MessageBox.Show("Mã hóa đơn không tồn tại!");
            }
            else
            {
                string Query = $"DELETE FROM HoaDon WHERE MaHD = N'{cbMahd.Text}'";
                int sl = hd.ThemSuaXoaHD(Query);
                if (sl > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    setkhoa();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }
    }
}
