using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OgrenciOlustur : Form
    {
        public OgrenciOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseFunctions databaseFunctions = new DatabaseFunctions();
                SqlCommand command = new SqlCommand("INSERT INTO ogrenciBilgi (ogrenciAdi,ogrenciSinif,ogrenciVeliAdi) VALUES (@param1,@param2,@param3)", databaseFunctions.DatabaseOpen());
                command.Parameters.AddWithValue("@param1", txtOgrenciAdi.Text);
                command.Parameters.AddWithValue("@param2", cmbOgrenciSinif.Text);
                command.Parameters.AddWithValue("@param3", txtOgrenciVeli.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Öğrenci başarıyla oluşturuldu!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Öğrenci oluşturulamadı!" + ex.Message);
            }

        }
    }
}
