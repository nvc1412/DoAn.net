using QuanLyCuaHangGiaDung.Model;
using QuanLyCuaHangGiaDung.ConnectDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.Controller
{
    public class BaoCaoThongKeController
    {
        //private string connect = @"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI";
        Connect cn = new Connect();
        public List<HoaDon> getDataThang(string thang)
        {
            try
            {
                List<HoaDon> data = new List<HoaDon>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT HoaDon.*, CTHoaDon.MaSP, SanPham.TenSP, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.SoLuong*CTHoaDon.DonGia AS ThanhTien FROM HoaDon, CTHoaDon, SanPham WHERE HoaDon.MaHD = CTHoaDon.MaHD AND CTHoaDon.MaSP = SanPham.MaSP AND MONTH(HoaDon.NgayBan) = {thang}";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HoaDon obj = new HoaDon();
                    obj.MaHD = (string)dr["MaHD"];
                    obj.NgayBan = (DateTime)dr["NgayBan"];
                    obj.MaNV = (string)dr["MaNV"];
                    obj.MaSP = (string)dr["MaSP"];
                    obj.TenSP = (string)dr["TenSP"];
                    obj.SoLuong = (int)dr["SoLuong"];
                    obj.DonGia = (double)dr["DonGia"];
                    obj.ThanhTien = (double)dr["ThanhTien"];
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

        public List<HoaDon> getDataNgay(string ngay)
        {
            try
            {
                List<HoaDon> data = new List<HoaDon>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT HoaDon.*, CTHoaDon.MaSP, SanPham.TenSP, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.SoLuong*CTHoaDon.DonGia AS ThanhTien FROM HoaDon, CTHoaDon, SanPham WHERE HoaDon.MaHD = CTHoaDon.MaHD AND CTHoaDon.MaSP = SanPham.MaSP AND HoaDon.NgayBan = '{ngay}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HoaDon obj = new HoaDon();
                    obj.MaHD = (string)dr["MaHD"];
                    obj.NgayBan = (DateTime)dr["NgayBan"];
                    obj.MaNV = (string)dr["MaNV"];
                    obj.MaSP = (string)dr["MaSP"];
                    obj.TenSP = (string)dr["TenSP"];
                    obj.SoLuong = (int)dr["SoLuong"];
                    obj.DonGia = (double)dr["DonGia"];
                    obj.ThanhTien = (double)dr["ThanhTien"];
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

        public double getDoanhThuThang(string thang)
        {
            try
            {
                double doanhthu = 0;

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT HoaDon.*, CTHoaDon.MaSP, SanPham.TenSP, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.SoLuong*CTHoaDon.DonGia AS ThanhTien FROM HoaDon, CTHoaDon, SanPham WHERE HoaDon.MaHD = CTHoaDon.MaHD AND CTHoaDon.MaSP = SanPham.MaSP AND MONTH(HoaDon.NgayBan) = {thang}";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    doanhthu += (double)dr["ThanhTien"];
                }
                conn.Close();
                return doanhthu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return 0;
        }

        public double getDoanhThuNgay(string ngay)
        {
            try
            {
                double doanhthu = 0;

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT HoaDon.*, CTHoaDon.MaSP, SanPham.TenSP, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.SoLuong*CTHoaDon.DonGia AS ThanhTien FROM HoaDon, CTHoaDon, SanPham WHERE HoaDon.MaHD = CTHoaDon.MaHD AND CTHoaDon.MaSP = SanPham.MaSP AND HoaDon.NgayBan = '{ngay}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    doanhthu += (double)dr["ThanhTien"];
                }
                conn.Close();
                return doanhthu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return 0;
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

        public List<NhanVien> getDatacomboNV()
        {
            try
            {
                List<NhanVien> data = new List<NhanVien>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = "SELECT MaNV FROM NhanVien";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien obj = new NhanVien();
                    obj.MaNV = (string)dr["MaNV"];
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

        public string getTenNV(string manv)
        {
            string tennv = "";
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT TenNV FROM NhanVien WHERE MaNV = N'{manv}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tennv = (string)dr["TenNV"];
                }
                conn.Close();
                return tennv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return tennv;
        }

        public int getMaBL(string mabl)
        {
            try
            {
                string Query = $"SELECT COUNT(*) FROM BangLuong WHERE MaLuong = N'{mabl}'";
                SqlConnection conn = cn.ConnectDataBase();
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

        public int getThang(string thang)
        {
            try
            {
                string Query = $"SELECT COUNT(*) FROM CTBangLuong WHERE Thang = {thang}";
                SqlConnection conn = cn.ConnectDataBase();
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

        public List<BangLuong> getDataBL(string mabl)
        {
            try
            {
                List<BangLuong> data = new List<BangLuong>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT CTBangLuong.Thang, BangLuong.*, NhanVien.TenNV, NhanVien.HeSoLuong, CTBangLuong.SoNgayLam, CTBangLuong.Thuong, CTBangLuong.Phat," +
                    $" CTBangLuong.PhuCap, (((NhanVien.HeSoLuong * 1000) + CTBangLuong.PhuCap) / 26) * CTBangLuong.SoNgayLam + CTBangLuong.Thuong - CTBangLuong.Phat AS ThucLinh" +
                    $" FROM BangLuong, CTBangLuong, NhanVien" +
                    $" WHERE BangLuong.MaLuong = CTBangLuong.MaLuong AND BangLuong.MaNV = NhanVien.MaNV AND CTBangLuong.MaLuong = BangLuong.MaLuong AND BangLuong.MaLuong = '{mabl}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BangLuong obj = new BangLuong();
                    obj.Thang = (string)dr["Thang"];
                    obj.MaLuong = (string)dr["MaLuong"];
                    obj.MaNV = (string)dr["MaNV"];
                    obj.TenNV = (string)dr["TenNV"];
                    obj.HeSoLuong = (double)dr["HeSoLuong"];
                    obj.SoNgayLam = (int)dr["SoNgayLam"];
                    obj.Thuong = (double)dr["Thuong"];
                    obj.Phat = (double)dr["Phat"];
                    obj.PhuCap = (double)dr["PhuCap"];
                    obj.ThucLinh = (double)dr["ThucLinh"];
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

        public int ThemSuaXoaBL(string Query)
        {
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
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

        public List<BangLuong> getDatacomboBL()
        {
            try
            {
                List<BangLuong> data = new List<BangLuong>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = "SELECT MaLuong FROM BangLuong";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BangLuong obj = new BangLuong();
                    obj.MaLuong = (string)dr["MaLuong"];
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
