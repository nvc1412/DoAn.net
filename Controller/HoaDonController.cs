using QuanLyCuaHangGiaDung.ConnectDB;
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
    public class HoaDonController
    {
        //private string connect = @"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI";
        Connect cn = new Connect();
        public double getTongTien(string mahd)
        {
            try
            {
                double tongtien = 0;

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT HoaDon.*, CTHoaDon.MaSP, SanPham.TenSP, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.SoLuong*CTHoaDon.DonGia AS ThanhTien FROM HoaDon, CTHoaDon, SanPham WHERE HoaDon.MaHD = CTHoaDon.MaHD AND CTHoaDon.MaSP = SanPham.MaSP AND HoaDon.MaHD = '{mahd}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tongtien += (double)dr["ThanhTien"];
                }
                conn.Close();
                return tongtien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return 0;
        }

        public List<HoaDon> getDataHD(string mahd)
        {
            try
            {
                List<HoaDon> data = new List<HoaDon>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT HoaDon.*, CTHoaDon.MaSP, SanPham.TenSP, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.SoLuong*CTHoaDon.DonGia AS ThanhTien FROM HoaDon, CTHoaDon, SanPham WHERE HoaDon.MaHD = CTHoaDon.MaHD AND CTHoaDon.MaSP = SanPham.MaSP AND HoaDon.MaHD = '{mahd}'";
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

        public List<KhachHang> getDatacomboKH()
        {
            try
            {
                List<KhachHang> data = new List<KhachHang>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = "SELECT MaKH FROM KhachHang";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang obj = new KhachHang();
                    obj.MaKH = (string)dr["MaKH"];
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

        public List<SanPham> getDatacomboSP()
        {
            try
            {
                List<SanPham> data = new List<SanPham>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = "SELECT MaSP FROM SanPham";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham obj = new SanPham();
                    obj.MaSP = (string)dr["MaSP"];
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

        public List<HoaDon> getDatacomboHD()
        {
            try
            {
                List<HoaDon> data = new List<HoaDon>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = "SELECT MaHD FROM HoaDon";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HoaDon obj = new HoaDon();
                    obj.MaHD = (string)dr["MaHD"];
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

        public string getTenKH(string makh)
        {
            string tenkh = "";
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT TenKH FROM KhachHang WHERE MaKH = N'{makh}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tenkh = (string)dr["TenKH"];
                }
                conn.Close();
                return tenkh;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return tenkh;
        }

        public string getTenSP(string masp)
        {
            string tensp = "";
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT TenSP FROM SanPham WHERE MaSP = N'{masp}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tensp = (string)dr["TenSP"];
                }
                conn.Close();
                return tensp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return tensp;
        }

        public string getDVT(string masp)
        {
            string dvt = "";
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT DVT FROM SanPham WHERE MaSP = N'{masp}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dvt = (string)dr["DVT"];
                }
                conn.Close();
                return dvt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return dvt;
        }

        public string getDonGia(string masp)
        {
            string dongia = "";
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT GiaBan FROM SanPham WHERE MaSP = N'{masp}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dongia = dr["GiaBan"].ToString();
                }
                conn.Close();
                return dongia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return dongia;
        }

        public int ThemSuaXoaHD(string Query)
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

        public int getMaHD(string mahd)
        {
            try
            {
                string Query = $"SELECT COUNT(*) FROM HoaDon WHERE MaHD = N'{mahd}'";
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

        public int getMaSP(string masp, string mahd)
        {
            try
            {
                string Query = $"SELECT COUNT(*) FROM CTHoaDon WHERE MaSP = N'{masp}' AND MaHD = N'{mahd}' ";
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
    }
}
