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
    }
}
