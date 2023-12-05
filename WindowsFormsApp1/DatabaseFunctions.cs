using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DatabaseFunctions
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = dePayens\\SQLEXPRESS; Initial Catalog = OgrenciYonetim; Integrated Security = True");
        public SqlConnection DatabaseOpen()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı." +  ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlConnection;
        }
    }
}
