using QuanLyCuaHangGiaDung.ConnectDB;
using QuanLyCuaHangGiaDung.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.Controller
{
    public class TaiKhoanController
    {
        //private string connect = @"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI";
        Connect cn = new Connect();
        public List<TK> getData()
        {
            try
            {
                List<TK> data = new List<TK>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = "SELECT * FROM TaiKhoan";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TK obj = new TK();
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
                    obj.MatKhau = (string)dr["MatKhau"];
                    obj.Quyen = (string)dr["Quyen"];
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
        public int ThemSuaXoaTK(string Query)
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
        public string ToMD5(string str)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                result += buffer[i].ToString("x2");
            }
            return result;
        }
        public int getTK(string tk)
        {
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = N'{tk}'";
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

        public bool checkTK(string tk, string mk)
        {
            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = '{tk}' and MatKhau = '{ToMD5(mk)}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return false;
        }

        public List<TK> TimTK(string Query)
        {
            try
            {
                List<TK> data = new List<TK>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TK obj = new TK();
                    obj.TaiKhoan = (string)dr["TaiKhoan"];
                    obj.MatKhau = (string)dr["MatKhau"];
                    obj.Quyen = (string)dr["Quyen"];
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
