using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseFunctions databaseFunctions = new DatabaseFunctions();
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM admin Where admin=@param1 and adminpassword=@param2",databaseFunctions.DatabaseOpen());
            sqlcommand.Parameters.AddWithValue("@param1",txtID.Text);
            sqlcommand.Parameters.AddWithValue("@param2",txtPassword.Text);
            SqlDataReader reader = sqlcommand.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı! Yönlendiriliyorsunuz","Giriş Başarılı!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(2000);
                StudentControl studentControl = new StudentControl();
                studentControl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şife hatalı!");
            }
        }
    }
}
