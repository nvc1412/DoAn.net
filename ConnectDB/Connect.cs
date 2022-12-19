using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGiaDung.ConnectDB
{
    public class Connect
    {
        public SqlConnection conn = null;
        public SqlConnection ConnectDataBase()
        {
            try
            {
                string connect = @"Data Source=localhost;Initial Catalog=CuaHangGiaDungKimNgan;Integrated Security=SSPI";
                conn = new SqlConnection(connect);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi CSDL: " + ex.Message);
                return null;
            }
        }
    }
}
