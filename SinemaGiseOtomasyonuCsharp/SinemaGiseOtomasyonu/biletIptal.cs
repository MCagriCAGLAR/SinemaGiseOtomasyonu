using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SinemaGiseOtomasyonu
{
    public partial class biletIptal : Form
    {
        public biletIptal()
        {
            InitializeComponent();
        }

        public int getFilmID;
        public int getSalonID;
        public int getSeansID;
        public int getMusterID;


        MySqlConnection baglan = new MySqlConnection("Database = sinemagisesi; DataSource = localhost; UserID = root;");

        private void biletSil()
        {
            baglan.Open();

            MySqlCommand komut = new MySqlCommand("DELETE FROM bilet WHERE biletID = ( '" + tbBiletSil.Text.ToString() + "' ) ", baglan);

            if (komut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Biletiniz iptal edilmiştir. İyi günler...", "BAŞARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("HATA !!! Bilet iptal edilemedi...", "UYARI ..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            baglan.Close();
        }
       

        private void biletIptal_Load(object sender, EventArgs e)
        {
            
        }

        private void butonBiletİptal_Click(object sender, EventArgs e)
        {
            biletSil();
        }
    }
}
