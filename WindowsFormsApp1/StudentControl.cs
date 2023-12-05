using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentControl : Form
    {
        public StudentControl()
        {
            InitializeComponent();
        }

        private void btnOgrenciOlustur_Click(object sender, EventArgs e)
        {
            OgrenciOlustur ogrenciOlustur = new OgrenciOlustur();
            ogrenciOlustur.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeansOlustur seansOlustur = new SeansOlustur();
            seansOlustur.Show();
        }

        private void btnSeansGor_Click(object sender, EventArgs e)
        {

        }
    }
}
