using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangGiaDung.ConnectDB;

namespace QuanLyCuaHangGiaDung.View
{
    public partial class InHoaDon : Form
    {
        //private string connect = @"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI";
        Connect cn = new Connect();
        private string mahd;

        public InHoaDon(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = cn.ConnectDataBase();
                conn.Open();
                string Query = $"SELECT HoaDon.*, CTHoaDon.MaSP, SanPham.TenSP, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.SoLuong*CTHoaDon.DonGia AS ThanhTien " +
                    $"FROM HoaDon, CTHoaDon, SanPham WHERE HoaDon.MaHD = CTHoaDon.MaHD AND CTHoaDon.MaSP = SanPham.MaSP AND HoaDon.MaHD = '{mahd}'";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "HoaDon");
                

                conn.Close();

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangGiaDung.View.ReportHoaDon.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables["HoaDon"];
                this.reportViewer1.LocalReport.DataSources.Add(rds);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
