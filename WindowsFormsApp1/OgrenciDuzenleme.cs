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
    public partial class OgrenciDuzenleme : Form
    {
        public OgrenciDuzenleme()
        {
            InitializeComponent();
            OgrenciCekme();
        }
        
        private void OgrenciCekme()
        {
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand sqlcommand = new SqlCommand("SELECT ogrenciAdi FROM ogrenciBilgi", databaseFunctions.DatabaseOpen());
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                cmbOgrenciAd.Items.Add(reader[0]);
            }
        }

        private void cmbOgrenciAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand sqlcommand = new SqlCommand("SELECT ogrenciID,ogrenciSinif FROM ogrenciBilgi Where ogrenciAdi=@param1", databaseFunctions.DatabaseOpen());
            sqlcommand.Parameters.AddWithValue("@param1",cmbOgrenciAd.SelectedItem.ToString());
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                txtOgrenciID.Text = reader[0].ToString();
                cmbOgrenciSinif.SelectedItem = reader[1].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseFunctions databaseFunctions = new DatabaseFunctions();
                SqlCommand sqlcommand = new SqlCommand("UPDATE ogrenciBilgi SET ogrenciAdi=@param1, ogrenciSinif=@param2, ogrenciVeliAdi=@param3 Where ogrenciID=@param4", databaseFunctions.DatabaseOpen());
                sqlcommand.Parameters.AddWithValue("@param1", cmbOgrenciAd.Text);
                sqlcommand.Parameters.AddWithValue("@param2", cmbOgrenciSinif.Text);
                sqlcommand.Parameters.AddWithValue("@param3", txtOgrenciVeli.Text);
                sqlcommand.Parameters.AddWithValue("@param4", txtOgrenciID.Text);
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Düzenlendi!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata ile karşılaşıldı:",ex.Message);
            }
        }

        private void OgrenciDuzenleme_Load(object sender, EventArgs e)
        {

        }
    }
}
