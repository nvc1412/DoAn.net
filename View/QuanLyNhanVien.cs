using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            try
            {
                List<Model.NhanVien> data = new List<Model.NhanVien>();

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = "SELECT * FROM NhanVien";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Model.NhanVien obj = new Model.NhanVien();
                    obj.MaNV = (string)dr["MaNV"];
                    obj.TenNV = (string)dr["TenNV"];
                    obj.NgaySinh = (DateTime)dr["NgaySinh"];
                    obj.GioiTinh = (string)dr["GioiTinh"];
                    obj.DiaChi = (string)dr["DiaChi"];
                    obj.Sdt = (string)dr["Sdt"];
                    obj.HeSoLuong = (double)dr["HeSoLuong"];
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
                    data.Add(obj);
                }
                conn.Close();
                dgvNhanvien.DataSource = data;
            }catch (Exception ex)
            {
                MessageBox.Show("Loi: "+ex.Message);
            }
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
            getData();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtManv.Text == "" || txtTennv.Text == "" || dateNgaysinh.Text == "" || cbGioitinh.Text == ""
                    || txtDiachi.Text == "" || txtSdt.Text == "" || txtHesoluong.Text == "" || cbTaikhoan.Text == "")
                {
                    MessageBox.Show("Không được để trống !!!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                    conn.Open();
                    string Query = $"INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Sdt, HeSoLuong, TaiKhoan)" +
                        $" Values('{txtManv.Text}', '{txtTennv.Text}', '{dateNgaysinh.Text}', '{cbGioitinh.Text}', '{txtDiachi.Text}', '{txtSdt.Text}', '{txtHesoluong.Text}', '{cbTaikhoan.Text}')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    int sl = cmd.ExecuteNonQuery();
                    conn.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Model.NhanVien> data = new List<Model.NhanVien>();

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = $"SELECT * FROM NhanVien WHERE MaNV LIKE '%{txtTimkiem.Text}%' OR TenNV LIKE '%{txtTimkiem.Text}%' " +
                    $"OR NgaySinh LIKE '%{txtTimkiem.Text}%' OR GioiTinh LIKE '%{txtTimkiem.Text}%' OR DiaChi LIKE '%{txtTimkiem.Text}%' " +
                    $"OR Sdt LIKE '%{txtTimkiem.Text}%' OR HeSoLuong LIKE '%{txtTimkiem.Text}%' OR TaiKhoan LIKE '%{txtTimkiem.Text}%'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Model.NhanVien obj = new Model.NhanVien();
                    obj.MaNV = (string)dr["MaNV"];
                    obj.TenNV = (string)dr["TenNV"];
                    obj.NgaySinh = (DateTime)dr["NgaySinh"];
                    obj.GioiTinh = (string)dr["GioiTinh"];
                    obj.DiaChi = (string)dr["DiaChi"];
                    obj.Sdt = (string)dr["Sdt"];
                    obj.HeSoLuong = (double)dr["HeSoLuong"];
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
                    data.Add(obj);
                }
                conn.Close();
                dgvNhanvien.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void cbSapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapxep = "MaNV";
            try
            {
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

                List<Model.NhanVien> data = new List<Model.NhanVien>();

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = $"SELECT * FROM NhanVien ORDER BY {sapxep}";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Model.NhanVien obj = new Model.NhanVien();
                    obj.MaNV = (string)dr["MaNV"];
                    obj.TenNV = (string)dr["TenNV"];
                    obj.NgaySinh = (DateTime)dr["NgaySinh"];
                    obj.GioiTinh = (string)dr["GioiTinh"];
                    obj.DiaChi = (string)dr["DiaChi"];
                    obj.Sdt = (string)dr["Sdt"];
                    obj.HeSoLuong = (double)dr["HeSoLuong"];
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
                    data.Add(obj);
                }
                conn.Close();
                dgvNhanvien.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: "+ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = $"UPDATE NhanVien SET TenNV='{txtTennv.Text}', NgaySinh='{dateNgaysinh.Text}'," +
                    $" GioiTinh='{cbGioitinh.Text}', DiaChi='{txtDiachi.Text}', Sdt='{txtSdt.Text}', HeSoLuong='{txtHesoluong.Text}'," +
                    $" TaiKhoan='{cbTaikhoan.Text}' WHERE MaNV='{txtManv.Text}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-08FCIFR\SQLEXPRESS;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = $"DELETE FROM NhanVien WHERE MaNV='{txtManv.Text}'";
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

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý học sinh";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnXuatexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgvNhanvien, saveFileDialog1.FileName);
            }
        }
    }
}
