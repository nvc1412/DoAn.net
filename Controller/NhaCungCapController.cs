﻿using QuanLyCuaHangGiaDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangGiaDung.ConnectDB;

namespace QuanLyCuaHangGiaDung.Controller
{
    public class NhaCungCapController
    {
        //private string connect = @"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI";
        Connect cn = new Connect();
        public List<NhaCungCap> getData()
        {
            try
            {
                List<NhaCungCap> data = new List<NhaCungCap>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = "SELECT * FROM NhaCungCap";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhaCungCap obj = new NhaCungCap();
                    obj.MaNCC = (string)dr["MaNCC"];
                    obj.TenNCC = (string)dr["TenNCC"];
                    obj.DiaChi = (string)dr["DiaChi"];
                    obj.Sdt = (string)dr["Sdt"];
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

        public int getMaNCC(string mancc)
        {
            try
            {
                string Query = $"SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = N'{mancc}'";
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

        public int ThemSuaXoaNCC(string Query)
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
        public List<NhaCungCap> TimNCC(string Query)
        {
            try
            {
                List<NhaCungCap> data = new List<NhaCungCap>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhaCungCap obj = new NhaCungCap();
                    obj.MaNCC = (string)dr["MaNCC"];
                    obj.TenNCC = (string)dr["TenNCC"];
                    obj.DiaChi = (string)dr["DiaChi"];
                    obj.Sdt = (string)dr["Sdt"];
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
        public List<NhaCungCap> SapXepNCC(string sapxep)
        {
            try
            {
                List<NhaCungCap> data = new List<NhaCungCap>();

                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT * FROM NhaCungCap ORDER BY {sapxep}";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhaCungCap obj = new NhaCungCap();
                    obj.MaNCC = (string)dr["MaNCC"];
                    obj.TenNCC = (string)dr["TenNCC"];
                    obj.DiaChi = (string)dr["DiaChi"];
                    obj.Sdt = (string)dr["Sdt"];
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
