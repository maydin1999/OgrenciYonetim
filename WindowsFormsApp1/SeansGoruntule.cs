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
    public partial class SeansGoruntule : Form
    {
        public SeansGoruntule()
        {
            InitializeComponent();
            OgrenciCek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOgrenciAdi.SelectedItem != null && cmbSeansTarih.SelectedItem != null) 
                {
                    // Fonksiyon Seans Notları,Ders Programı ve Sonraki Seansta Yapılacakları Çeker.
                    DatabaseFunctions databaseFunctions = new DatabaseFunctions();
                    SqlCommand cmdArama = new SqlCommand("SELECT seansNotlari,seansdersProgrami,seansSonraki FROM seans WHERE seansOgrenciAdi = @param1 and seansTarihi = @param2", databaseFunctions.DatabaseOpen());
                    cmdArama.Parameters.AddWithValue("@param1", cmbOgrenciAdi.SelectedItem.ToString());
                    cmdArama.Parameters.AddWithValue("@param2", Convert.ToDateTime(cmbSeansTarih.SelectedItem));
                    SqlDataReader aramaReader = cmdArama.ExecuteReader();
                    while (aramaReader.Read())
                    {
                        rchSeansNotlari.AppendText(aramaReader[0].ToString());
                        rchDersProgrami.AppendText(aramaReader[1].ToString());
                        rchSonrakiDers.AppendText(aramaReader[2].ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Seçtiğiniz bilgiler boş!");
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Hata bulundu:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OgrenciCek()
        {
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand sqlcommand = new SqlCommand("SELECT ogrenciAdi FROM ogrenciBilgi", databaseFunctions.DatabaseOpen());
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                cmbOgrenciAdi.Items.Add(reader[0]);
            }
        }

        private void cmbOgrenciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand command = new SqlCommand("SELECT seansTarihi From seans Where seansOgrenciAdi=@param1 ORDER BY seansTarihi", databaseFunctions.DatabaseOpen());
            command.Parameters.AddWithValue("@param1", cmbOgrenciAdi.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0] is DateTime)
                {
                    DateTime seansTarihi = (DateTime)reader[0];
                    cmbSeansTarih.Items.Add(seansTarihi);
                    cmbSeansTarih.FormatString = "dd/MM/yyyy";


                    // Gün, ay, yıl formatında biçimlendirme
                    //string formattedDate = seansTarihi.ToString("dd/MM/yyyy");

                    //cmbSeansTarih.Items.Add(formattedDate);

                    // Eğer bir varsayılan seçili değer istiyorsanız, bu satırı ekleyebilirsiniz
                    cmbSeansTarih.SelectedIndex = 0;
                }
            }
            ////////////////////////////////////////////////////////////
            /*SqlCommand command2 = new SqlCommand("SELECT ogrenciSinif From ogrenciBilgi Where ogrenciAdi=@param1", databaseFunctions.DatabaseOpen());
            command2.Parameters.AddWithValue("@param1", cmbOgrenciAdi.SelectedItem.ToString());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbOgrenciSinif.Items.Add(reader2[0]);
            }
            */
        }

        public static implicit operator SeansGoruntule(SeansOlustur v)
        {
            throw new NotImplementedException();
        }
    }
}
