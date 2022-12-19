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
    public partial class QuanLySanPham : Form
    {
        SanPhamController sp = new SanPhamController();
        Regex number = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");

        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            txtMasp.Focus();
            dgvSanpham.DataSource = sp.getDataSP();

            cbLsp.DisplayMember = "MaLoai";
            cbLsp.DataSource = sp.getDatacombo();

            cbMancc.DisplayMember = "MaNCC";

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnSuaLoai.Enabled = false;
            btnXoaLoai.Enabled = false;
        }

        private void tabSanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabSanpham.SelectedIndex == 0)
            {
                dgvSanpham.DataSource = sp.getDataSP();
                txtMasp.Focus();
                cbLsp.DataSource = sp.getDatacombo();
            }
            else
            {
                dgvLoaisanpham.DataSource = sp.getDataLSP();
                txtMaloai.Focus();
                cbMancc.DataSource = sp.getDatacomboNCC();
            }
        }

        public void setNull()
        {
            txtMaloai.Text = null;
            txtTenloai.Text = null;
            txtTimkiemLoai.Text = null;
            cbMancc.DataSource = sp.getDatacomboNCC();
            dgvLoaisanpham.DataSource = sp.getDataLSP();
            btnSuaLoai.Enabled = false;
            btnXoaLoai.Enabled = false;
            btnThemLoai.Enabled = true;
            txtMaloai.Enabled = true;
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (txtMaloai.Text == "" || txtTenloai.Text == "" || cbMancc.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (sp.getMaLoai(txtMaloai.Text) > 0)
            {
                MessageBox.Show("Mã loại sản phẩm đã tồn tại!");
            }
            else
            {
                string Query = $"INSERT INTO LoaiSP(MaLoai, TenLoai, MaNCC) Values (N'{txtMaloai.Text}', N'{txtTenloai.Text}', N'{cbMancc.Text}')";
                int sl = sp.ThemSuaXoaLSP(Query);
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

        private void btnLammoiLoai_Click(object sender, EventArgs e)
        {
            setNull();
            txtMaloai.Focus();
        }

        private void btnTimkiemLoai_Click(object sender, EventArgs e)
        {
            string Query = $"SELECT * FROM LoaiSP WHERE MaLoai LIKE N'%{txtTimkiemLoai.Text}%' " +
                $"OR TenLoai LIKE N'%{txtTimkiemLoai.Text}%' OR MaNCC LIKE N'%{txtTimkiemLoai.Text}%' ";
            dgvLoaisanpham.DataSource = sp.TimLSP(Query);
        }

        private void dgvLoaisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaLoai.Enabled = true;
            btnXoaLoai.Enabled = true;
            btnThemLoai.Enabled = false;
            txtMaloai.Enabled = false;
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row >= 0)
                {
                    txtMaloai.Text = (string)dgvLoaisanpham.Rows[row].Cells["MaLoai"].Value;
                    txtTenloai.Text = (string)dgvLoaisanpham.Rows[row].Cells["TenLoai"].Value;
                    cbMancc.Text = (string)dgvLoaisanpham.Rows[row].Cells["MaNCC"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            if (txtMaloai.Text == "" || txtTenloai.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else
            {
                string Query = $"UPDATE LoaiSP SET TenLoai= N'{txtTenloai.Text}', MaNCC= N'{cbMancc.Text}' WHERE MaLoai=N'{txtMaloai.Text}'";
                int sl = sp.ThemSuaXoaLSP(Query);
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

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            string Query = $"DELETE FROM LoaiSP WHERE MaLoai=N'{txtMaloai.Text}'";
            int sl = sp.ThemSuaXoaLSP(Query);
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

        private void btnXuatexcelLoai_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dgvNhanvien và filename từ SaveFileDialog
                sp.ToExcel(dgvLoaisanpham, saveFileDialog1.FileName);
            }
        }

        private void cbSapxepLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapxep = "MaLoai";
            switch (cbSapxepLoai.SelectedIndex)
            {
                case 0: sapxep = "MaLoai"; break;
                case 1: sapxep = "TenLoai"; break;
                case 2: sapxep = "MaLoai DESC"; break;
                case 3: sapxep = "TenLoai DESC"; break;
                default: sapxep = "MaLoai"; break;
            }
            dgvLoaisanpham.DataSource = sp.SapXepLSP(sapxep);
        }

        private void cbMancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenncc.Text = sp.getTenNCC(cbMancc.Text);
        }

        // -------------------------Sản Phẩm---------------------------------------------------------------------------------

        public void setNullSP()
        {
            txtMasp.Text = null;
            txtTensp.Text = null;
            txtGiaban.Text = null;
            cbLsp.Text = null;
            txtTensp.Text = null;
            cbDvt.Text = null;
            dgvSanpham.DataSource = sp.getDataSP();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMasp.Enabled = true;
            cbLsp.DataSource = sp.getDatacombo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMasp.Text == "" || txtTensp.Text == "" || txtGiaban.Text == "" || cbLsp.Text == "" || cbDvt.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (sp.getMaSP(txtMasp.Text) > 0)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
            }
            else if (!number.IsMatch(txtGiaban.Text))
            {
                MessageBox.Show("Giá bán phải là số!");
            }
            else
            {
                string Query = $"INSERT INTO SanPham(MaSP, TenSP, Loai, GiaBan, DVT) " +
                    $"Values(N'{txtMasp.Text}', N'{txtTensp.Text}', N'{cbLsp.Text}', '{txtGiaban.Text}', N'{cbDvt.Text}')";
                int sl = sp.ThemSuaXoaLSP(Query);
                if (sl > 0)
                {
                    MessageBox.Show("Thêm mới thành công!");
                    setNullSP();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            setNullSP();
            txtMasp.Focus();
        }

        private void cbLsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenlsp.Text = sp.getTenLoai(cbLsp.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMasp.Text == "" || txtTensp.Text == "" || txtGiaban.Text == "" || cbLsp.Text == "" || cbDvt.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else
            {
                string Query = $"UPDATE SanPham SET TenSP=N'{txtTensp.Text}', Loai=N'{cbLsp.Text}', " +
                    $"GiaBan='{txtGiaban.Text}', DVT=N'{cbDvt.Text}' WHERE MaSP=N'{txtMasp.Text}'";
                int sl = sp.ThemSuaXoaLSP(Query);
                if (sl > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    setNullSP();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            txtMasp.Enabled = false;
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row >= 0)
                {
                    txtMasp.Text = (string)dgvSanpham.Rows[row].Cells["MaSP"].Value;
                    txtTensp.Text = (string)dgvSanpham.Rows[row].Cells["TenSP"].Value;
                    cbLsp.Text = (string)dgvSanpham.Rows[row].Cells["Loai"].Value;
                    txtGiaban.Text = dgvSanpham.Rows[row].Cells["GiaBan"].Value.ToString();
                    cbDvt.Text = (string)dgvSanpham.Rows[row].Cells["DVT"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Query = $"DELETE FROM SanPham WHERE MaSP=N'{txtMasp.Text}'";
            int sl = sp.ThemSuaXoaLSP(Query);
            if (sl > 0)
            {
                MessageBox.Show("Xóa thành công!");
                setNullSP();
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
                sp.ToExcel(dgvSanpham, saveFileDialog1.FileName);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string Query = $"SELECT * FROM SanPham WHERE MaSP LIKE N'%{txtTimkiem.Text}%' " +
                $"OR TenSP LIKE N'%{txtTimkiem.Text}%' OR Loai LIKE N'%{txtTimkiem.Text}%' " +
                $"OR GiaBan LIKE N'%{txtTimkiem.Text}%' OR DVT LIKE N'%{txtTimkiem.Text}%' ";
            dgvSanpham.DataSource = sp.TimSP(Query);
        }

        private void cbSapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapxep = "GiaBan";
            switch (cbSapxep.SelectedIndex)
            {
                case 0: sapxep = "GiaBan"; break;
                case 1: sapxep = "GiaBan DESC"; break;
                default: sapxep = "GiaBan"; break;
            }
            dgvSanpham.DataSource = sp.SapXepSP(sapxep);
        }
    }
}
