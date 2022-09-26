using QuanLyCuaHangGiaDung.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class QuanLySanPham : Form
    {
        SanPhamController sp = new SanPhamController();
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            txtMasp.Focus();
            dgvSanpham.DataSource = sp.getDataSP();
        }

        private void tabSanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabSanpham.SelectedIndex == 0)
            {
                dgvSanpham.DataSource = sp.getDataSP();
                txtMasp.Focus();
            }
            else
            {
                dgvLoaisanpham.DataSource = sp.getDataLSP();
                txtMaloai.Focus();
            }
        }

        public void setNull()
        {
            txtMaloai.Text = null;
            txtTenloai.Text = null;
            txtTimkiemLoai.Text = null;
            dgvLoaisanpham.DataSource = sp.getDataLSP();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (txtMaloai.Text == "" || txtTenloai.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (sp.getMaLoai(txtMaloai.Text) > 0)
            {
                MessageBox.Show("Mã loại sản phẩm đã tồn tại!");
            }
            else
            {
                string Query = $"INSERT INTO LoaiSP(MaLoai, TenLoai) Values (N'{txtMaloai.Text}', N'{txtTenloai.Text}')";
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
            string Query = $"SELECT * FROM LoaiSP WHERE MaLoai LIKE N'%{txtTimkiemLoai.Text}%' OR TenLoai LIKE N'%{txtTimkiemLoai.Text}%' ";
            dgvLoaisanpham.DataSource = sp.TimLSP(Query);
        }

        private void dgvLoaisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row >= 0)
                {
                    txtMaloai.Text = (string)dgvLoaisanpham.Rows[row].Cells["MaLoai"].Value;
                    txtTenloai.Text = (string)dgvLoaisanpham.Rows[row].Cells["TenLoai"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}
