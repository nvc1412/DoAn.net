using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.Controller
{
    public class NhanVienController
    {
        public List<Model.NhanVien> getData()
        {
            try
            {
                List<Model.NhanVien> data = new List<Model.NhanVien>();

                SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
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
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return null;
        }

        public List<Model.TK> getDatacombo()
        {
            try
            {
                List<Model.TK> data = new List<Model.TK>();

                SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
                conn.Open();
                string Query = "SELECT TaiKhoan FROM TaiKhoan";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Model.TK obj = new Model.TK();
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
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

        public int ThemmoiNV(string Query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            int sl = cmd.ExecuteNonQuery();
            conn.Close();
            return sl;
        }
    }
}
