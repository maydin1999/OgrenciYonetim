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
    public partial class SeansOlustur : Form
    {
        public SeansOlustur()
        {
            InitializeComponent();
            OgrenciCek();
        }
        private void cmbOgrenciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOgrenciSinif.Items.Clear();
            cmbOgrenciSinif.Text = string.Empty;
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand sqlcommand2 = new SqlCommand("SELECT ogrenciID,ogrenciSinif FROM ogrenciBilgi Where ogrenciAdi=@param1", databaseFunctions.DatabaseOpen());
            sqlcommand2.Parameters.AddWithValue("@param1",cmbOgrenciAdi.Text);
            SqlDataReader reader2 = sqlcommand2.ExecuteReader();
            while (reader2.Read())
            {
                cmbOgrenciID.Items.Add(reader2[0]);
                cmbOgrenciID.SelectedItem = reader2[0];
                cmbOgrenciSinif.Items.Add(reader2[1]);
                cmbOgrenciSinif.SelectedItem = reader2[1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseFunctions dbFunctions = new DatabaseFunctions();
            SqlCommand sqlcommand3 = new SqlCommand("INSERT INTO seans (seansOgrenciID,seansOgrenciAdi,seansNo,seansNotlari,seansdersProgrami,seansSonraki,seansTarihi,ogrenciSinif) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)", dbFunctions.DatabaseOpen());
            sqlcommand3.Parameters.AddWithValue("@param1", cmbOgrenciID.SelectedItem.ToString());
            sqlcommand3.Parameters.AddWithValue("@param2", cmbOgrenciAdi.SelectedItem.ToString());
            sqlcommand3.Parameters.AddWithValue("@param3", txtSeansNo.Text);
            sqlcommand3.Parameters.AddWithValue("@param4", rchSeansNot.Text);
            sqlcommand3.Parameters.AddWithValue("@param5", rchDersProgrami.Text);
            sqlcommand3.Parameters.AddWithValue("@param6", rchDigerSeans.Text);
            sqlcommand3.Parameters.AddWithValue("@param7", dtSeansTarihi.Value);
            sqlcommand3.Parameters.AddWithValue("@param8", cmbOgrenciSinif.SelectedItem.ToString());
            //sqlcommand3.ExecuteNonQuery();
            //MessageBox.Show("Seans Notları Eklendi.");
            int affectedRows = sqlcommand3.ExecuteNonQuery();
            if (affectedRows > 0)
            {
                MessageBox.Show("Veri başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Veri eklenemedi.");
            }
        }


        public void OgrenciCek()
        {
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand sqlcommand = new SqlCommand("SELECT ogrenciAdi,ogrenciSinif FROM ogrenciBilgi", databaseFunctions.DatabaseOpen());
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                cmbOgrenciAdi.Items.Add(reader[0]);
            }
        }
    }
}
