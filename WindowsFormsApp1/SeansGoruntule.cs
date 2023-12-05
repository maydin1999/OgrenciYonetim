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
            lblSeansTarih.Visible = true;
            cmbSeansTarih.Visible = true;
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand command = new SqlCommand("SELECT seansTarihi From seans Where seansOgrenciAdi=@param1 ORDER BY seansTarihi", databaseFunctions.DatabaseOpen());
            command.Parameters.AddWithValue("@param1", cmbOgrenciAdi.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0] is DateTime)
                {
                    DateTime seansTarihi = (DateTime)reader[0];

                    // Gün, ay, yıl formatında biçimlendirme
                    string formattedDate = seansTarihi.ToString("dd/MM/yyyy");

                    cmbSeansTarih.Items.Add(formattedDate);

                    // Eğer bir varsayılan seçili değer istiyorsanız, bu satırı ekleyebilirsiniz
                    cmbSeansTarih.SelectedIndex = 0;
                }
            }
            //while (reader.Read())
            //{
            //    cmbSeansTarih.Items.Add(reader[0]);
            //    cmbSeansTarih.SelectedItem = reader[0];
            //}
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
    }
}
