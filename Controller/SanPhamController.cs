using QuanLyCuaHangGiaDung.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.Controller
{
    public class SanPhamController
    {
        private string connect = @"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI";

        public List<SanPham> getDataSP()
        {
            try
            {
                List<SanPham> data = new List<SanPham>();

                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string Query = "SELECT * FROM SanPham";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham obj = new SanPham();
                    obj.MaSP = (string)dr["MaSP"];
                    obj.TenSP = (string)dr["TenSP"];
                    obj.Loai = (string)dr["Loai"];
                    obj.GiaBan = (double)dr["GiaBan"];
                    obj.DVT = (string)dr["DVT"];
                    data.Add(obj);
                }
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;
        }

        public List<LoaiSP> getDataLSP()
        {
            try
            {
                List<LoaiSP> data = new List<LoaiSP>();

                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string Query = "SELECT * FROM LoaiSP";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiSP obj = new LoaiSP();
                    obj.MaLoai = (string)dr["MaLoai"];
                    obj.TenLoai = (string)dr["TenLoai"];
                    data.Add(obj);
                }
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;
        }

        public int ThemSuaXoaLSP(string Query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                return sl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return 0;
        }

        public int getMaLoai(string maloai)
        {
            try
            {
                string Query = $"SELECT COUNT(*) FROM LoaiSP WHERE MaLoai = '{maloai}'";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                return sl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return 0;
        }

        public List<LoaiSP> TimLSP(string Query)
        {
            try
            {
                List<LoaiSP> data = new List<LoaiSP>();

                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiSP obj = new LoaiSP();
                    obj.MaLoai = (string)dr["MaLoai"];
                    obj.TenLoai = (string)dr["TenLoai"];
                    data.Add(obj);
                }
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;

        }

        public void ToExcel(DataGridView dataGridView1, string fileName)
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

        public List<LoaiSP> SapXepLSP (string sapxep)
        {
            try
            {
                List<LoaiSP> data = new List<LoaiSP>();

                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string Query = $"SELECT * FROM LoaiSP ORDER BY {sapxep}";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiSP obj = new LoaiSP();
                    obj.MaLoai = (string)dr["MaLoai"];
                    obj.TenLoai = (string)dr["TenLoai"];
                    data.Add(obj);
                }
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;
        }

        public List<LoaiSP> getDatacombo()
        {
            try
            {
                List<LoaiSP> data = new List<LoaiSP>();

                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string Query = "SELECT MaLoai FROM LoaiSP";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiSP obj = new LoaiSP();
                    obj.MaLoai = (string)dr["MaLoai"];
                    data.Add(obj);
                }
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;
        }

 //--------------Sản phẩm----------------------------------------------------------------------
        
        public int getMaSP(string masp)
        {
            try
            {
                string Query = $"SELECT COUNT(*) FROM SanPham WHERE Masp = N'{masp}'";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                return sl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return 0;
        }

        public string getTenLoai(string maloai)
        {
            string tenloai = "";
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string Query = $"SELECT TenLoai FROM LoaiSP WHERE MaLoai = N'{maloai}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tenloai = (string)dr["TenLoai"];
                }
                conn.Close();
                return tenloai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return tenloai;
        }

        public List<SanPham> TimSP(string Query)
        {
            try
            {
                List<SanPham> data = new List<SanPham>();

                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham obj = new SanPham();
                    obj.MaSP = (string)dr["MaSP"];
                    obj.TenSP = (string)dr["TenSP"];
                    obj.Loai = (string)dr["Loai"];
                    obj.GiaBan = (double)dr["GiaBan"];
                    obj.DVT = (string)dr["DVT"];
                    data.Add(obj);
                }
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;
        }

        public List<SanPham> SapXepSP(string sapxep)
        {
            try
            {
                List<SanPham> data = new List<SanPham>();

                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string Query = $"SELECT * FROM SanPham ORDER BY {sapxep}";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham obj = new SanPham();
                    obj.MaSP = (string)dr["MaSP"];
                    obj.TenSP = (string)dr["TenSP"];
                    obj.Loai = (string)dr["Loai"];
                    obj.GiaBan = (double)dr["GiaBan"];
                    obj.DVT = (string)dr["DVT"];
                    data.Add(obj);
                }
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;
        }
    }
}
