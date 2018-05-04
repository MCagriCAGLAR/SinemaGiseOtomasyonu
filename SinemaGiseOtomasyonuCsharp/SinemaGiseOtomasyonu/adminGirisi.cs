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
using System.IO;

namespace SinemaGiseOtomasyonu
{
    public partial class adminGirisi : Form
    {
        public adminGirisi()
        {
            InitializeComponent();
        }

        private string kullaniciAdi;
        private string sifre;

        

        MySqlConnection baglan = new MySqlConnection("Database = sinemagisesi; DataSource = localhost; UserID = root;");

        private void adminGiris()
        {
            baglan.Open();

            MySqlCommand komut = new MySqlCommand("SELECT adminUserID FROM admin WHERE adminID = '1' ", baglan);
            kullaniciAdi = komut.ExecuteScalar().ToString();

            MySqlCommand komut2 = new MySqlCommand("SELECT adminPassword FROM admin WHERE adminID = '1' ", baglan);       
            sifre = komut2.ExecuteScalar().ToString();

            if (tbKullaniciAdi.Text == kullaniciAdi && tbSifre.Text == sifre)
            {
                adminYonlendirme formYonlendirme = new adminYonlendirme();
                this.Hide();
                formYonlendirme.Show();
            }

            else if( tbKullaniciAdi.Text == "" || tbSifre.Text == "")
            {
                MessageBox.Show("Lutfen bos alan bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
                MessageBox.Show("Yanlış kullanıcı adi veya şifre...", "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

       
            baglan.Close();

        }
       

        private void adminGirisi_Load(object sender, EventArgs e)
        {

        }

        private void butonAdminGiris_Click(object sender, EventArgs e)
        {
            adminGiris();
            
        }
    }
}
