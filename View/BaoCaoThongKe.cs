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
    public partial class BaoCaoThongKe : Form
    {
        BaoCaoThongKeController bctk = new BaoCaoThongKeController();
        Regex number = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
        CultureInfo culture = new CultureInfo("vi-VN");
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        public void setkhoa()
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            txtMabl.Enabled = false;
            txtSongaylam.Text = null;
            txtThuong.Text = null;
            txtPhat.Text = null;
            txtPhucap.Text = null;
            cbManv.Enabled = false;
            dgvBangLuong.DataSource = bctk.getDataBL(txtMabl.Text);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (rdThang.Checked == true)
            {
                if(cbThang.Text == "")
                {
                    MessageBox.Show("Không được để trống!");
                }
                else
                {
                    dgvThongke.DataSource = bctk.getDataThang(cbThang.Text);
                    lbDoanhthu.Text = bctk.getDoanhThuThang(cbThang.Text).ToString("c", culture) + " VNĐ";
                }
            }
            else
            {
                if (dateNgay.Text == "")
                {
                    MessageBox.Show("Không được để trống!");
                }
                else
                {
                    dgvThongke.DataSource = bctk.getDataNgay(dateNgay.Text);
                    lbDoanhthu.Text = bctk.getDoanhThuNgay(dateNgay.Text).ToString("c", culture) + " VNĐ";
                }
            }
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThang.Checked == true)
            {
                dateNgay.Enabled = false;
                cbThang.Enabled = true;
            }
            else
            {
                dateNgay.Enabled = true;
                cbThang.Enabled = false;
            }
        }

        private void btnXuatexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dgvNhanvien và filename từ SaveFileDialog
                bctk.ToExcel(dgvThongke, saveFileDialog1.FileName);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            dgvThongke.DataSource = null;
        }

        private void tabBaocaothongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabBaocaothongke.SelectedIndex == 0)
            {
                dgvThongke.DataSource = null;
            }
            else
            {
                txtMabl.Focus();
                cbManv.DisplayMember = "MaNV";
                cbManv.DataSource = bctk.getDatacomboNV();

                cbMabl.DisplayMember = "MaLuong";
                cbMabl.DataSource = bctk.getDatacomboBL();
            }
        }

        private void cbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTennv.Text = bctk.getTenNV(cbManv.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMabl.Text == "" || cbManv.Text == "" || cbThangluong.Text == "" || txtSongaylam.Text == "" || txtThuong.Text == "" || txtPhat.Text == "" || txtPhucap.Text == "" )
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (!number.IsMatch(txtSongaylam.Text) || !number.IsMatch(txtThuong.Text) || !number.IsMatch(txtPhat.Text) || !number.IsMatch(txtPhucap.Text))
            {
                MessageBox.Show("Định dạng các trường phải là số!");
            }
            else if (bctk.getMaBL(txtMabl.Text) > 0)
            {
                MessageBox.Show("Mã bảng lương đã tồn tại!");
            }
            else
            {
                string Query = $"INSERT INTO BangLuong(MaLuong, MaNV) Values(N'{txtMabl.Text}', N'{cbManv.Text}')" +
                    $"INSERT INTO CTBangLuong(Thang, MaLuong, SoNgayLam, Thuong, Phat, PhuCap) Values(N'{cbThangluong.Text}', N'{txtMabl.Text}', N'{txtSongaylam.Text}', N'{txtThuong.Text}', N'{txtPhat.Text}', N'{txtPhucap.Text}')";
                int sl = bctk.ThemSuaXoaBL(Query);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtMabl.Text = cbMabl.Text;
            setkhoa();
        }

        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row >= 0)
                {
                    cbThangluong.Text = (string)dgvBangLuong.Rows[row].Cells["Thang"].Value;
                    txtSongaylam.Text = dgvBangLuong.Rows[row].Cells["SoNgayLam"].Value.ToString();
                    txtThuong.Text = dgvBangLuong.Rows[row].Cells["Thuong"].Value.ToString();
                    txtPhat.Text = dgvBangLuong.Rows[row].Cells["Phat"].Value.ToString();
                    txtPhucap.Text = dgvBangLuong.Rows[row].Cells["PhuCap"].Value.ToString();
                    lbThuclinh.Text = string.Format("{0:0,0 VNĐ}", Convert.ToInt32(dgvBangLuong.Rows[row].Cells["ThucLinh"].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMabl.Text == "" || cbManv.Text == "" || cbThangluong.Text == "" || txtSongaylam.Text == "" || txtThuong.Text == "" || txtPhat.Text == "" || txtPhucap.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (!number.IsMatch(txtSongaylam.Text) || !number.IsMatch(txtThuong.Text) || !number.IsMatch(txtPhat.Text) || !number.IsMatch(txtPhucap.Text))
            {
                MessageBox.Show("Định dạng các trường phải là số!");
            }
            else if (bctk.getThang(cbThangluong.Text) > 0)
            {
                MessageBox.Show("Đã có bảng lương nhân viên của tháng này!");
            }
            else
            {
                string Query = $"INSERT INTO CTBangLuong(Thang, MaLuong, SoNgayLam, Thuong, Phat, PhuCap) Values(N'{cbThangluong.Text}', N'{txtMabl.Text}', N'{txtSongaylam.Text}', N'{txtThuong.Text}', N'{txtPhat.Text}', N'{txtPhucap.Text}')";
                int sl = bctk.ThemSuaXoaBL(Query);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Query = $"DELETE FROM CTBangLuong WHERE MaLuong = N'{txtMabl.Text}' AND Thang = {cbThangluong.Text}";
            int sl = bctk.ThemSuaXoaBL(Query);
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

        private void btnLammoiBL_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtMabl.Enabled = true;
            cbManv.DataSource = bctk.getDatacomboNV();
            cbMabl.DataSource = bctk.getDatacomboBL();
            txtSongaylam.Text = null;
            txtThuong.Text = null;
            txtPhat.Text = null;
            txtPhucap.Text = null;
            txtMabl.Text = null;
            cbManv.Enabled = true;
            dgvBangLuong.DataSource = null;
            lbThuclinh.Text = "0 đ";
            txtMabl.Focus();
        }

        private void btnXoabl_Click(object sender, EventArgs e)
        {
            if (cbMabl.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (bctk.getMaBL(cbMabl.Text) <= 0)
            {
                MessageBox.Show("Mã bảng lương không tồn tại!");
            }
            else
            {
                string Query = $"DELETE FROM BangLuong WHERE MaLuong = N'{cbMabl.Text}'";
                int sl = bctk.ThemSuaXoaBL(Query);
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
