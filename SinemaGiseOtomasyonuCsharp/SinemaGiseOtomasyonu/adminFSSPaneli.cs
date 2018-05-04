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
    public partial class adminPaneli : Form
    {
        public adminPaneli()
        {
            InitializeComponent();
        }
      
        MySqlConnection baglan = new MySqlConnection("Database = sinemagisesi; DataSource = localhost; UserID = root;");
       
        public void filmKayitGoster()
        {
            baglan.Open();
          
            MySqlCommand komut = new MySqlCommand("SELECT * FROM filmler", baglan);
            MySqlDataReader oku = komut.ExecuteReader();

            while( oku.Read() )
            {
                ListViewItem ekle = new ListViewItem();
               

                ekle.Text = oku["filmID"].ToString();
                ekle.SubItems.Add(oku["filmAdi"].ToString());
                ekle.SubItems.Add(oku["filmTuru"].ToString());
                ekle.SubItems.Add(oku["film3D"].ToString());
                ekle.SubItems.Add(oku["filmSure"].ToString() + " dk.");
                ekle.SubItems.Add(oku["filmYerli"].ToString());
                

                lwFilm.Items.Add(ekle);

            }

            baglan.Close();
        }
        
        public void filmEkle()
        {
            baglan.Open();
           
            if ( tbFilmAdi.Text == "" || cbFilmTuru.Text == ""|| tbFilmSuresi.Text == "" || cb3D.Text == "" || cbYapimci.Text == "" )
            {
                MessageBox.Show("Lütfen yanlış ve boş bilgi girmeyiniz", "HATA !!!", MessageBoxButtons.OK);           
            }
            else
            {
                MySqlCommand komut = new MySqlCommand("INSERT INTO filmler(filmAdi, filmTuru, film3D, filmSure, filmYerli) VALUES('" + tbFilmAdi.Text.ToString() + "' , '" + cbFilmTuru.Text.ToString() + "' , '" + cb3D.Text.ToString() + "' , '" + tbFilmSuresi.Text.ToString() + "' ,  '" + cbYapimci.Text.ToString() + "') ", baglan);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Film başarıyla veritabanına kaydedildi...", "BAŞARI !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Film veritabanına kaydedilemedi...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbFilmAdi.Text = "";
            cbFilmTuru.Text = "";
            tbFilmSuresi.Text = "";
            cb3D.Text = "";
            cbYapimci.Text = "";

            baglan.Close();
           
        }

        private void filmSil()
        {
            baglan.Open();

            MySqlCommand komut = new MySqlCommand("DELETE FROM filmler WHERE filmID = (" + tbFilmSil.Text.ToString() + ") ", baglan);

            if (komut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kayit Basariyla veritabanından silindi...", "BAŞARI !!!", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("kayit silinemedi...", "HATA !!!", MessageBoxButtons.OK);

            tbFilmSil.Text = "";

            baglan.Close();

        }

        public void salonKayitGoster()
        {
            baglan.Open();          

            MySqlCommand komut = new MySqlCommand("SELECT * FROM salon", baglan);
            MySqlDataReader oku = komut.ExecuteReader();

            while ( oku.Read() )
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["salonID"].ToString();
                ekle.SubItems.Add(oku["salonAdi"].ToString());
                ekle.SubItems.Add(oku["salonKapasite"].ToString());

                lwFilm.Items.Add(ekle);

            }

            baglan.Close();
        }

        public void salonEkle()
        {
            baglan.Open();

            if( tbSalonAdi.Text == "" || tbKapasite.Text == "")
            {
                MessageBox.Show("Lütfen yanlış ve boş bilgi girmeyiniz...", "UYARI !!!", MessageBoxButtons.OK);
            }
            else
            {
                MySqlCommand komut = new MySqlCommand("INSERT INTO salon(salonAdi, salonKapasite) VALUES('" + tbSalonAdi.Text.ToString() + "' , '" + tbKapasite.Text.ToString() + "') ", baglan);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Salon başarıyla veritabanına kaydedildi...", "BAŞARI !!!", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("salon kaydı veritabanına kaydedilemedi...", "HATA !!!", MessageBoxButtons.OK);
                               
            }

            baglan.Close();

            tbSalonAdi.Text = "";
            tbKapasite.Text = "";

            baglan.Close();

        }

        private void salonSil()
        {
            baglan.Open();

            MySqlCommand komut = new MySqlCommand("DELETE FROM salon WHERE salonID = "+ tbSalonSil.Text.ToString() +" ", baglan);
            komut.ExecuteNonQuery();

            if (komut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("kayit veritabanından silinemedi", "HATA !!!", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Salon başarıyla veritabanından silindi...", "BAŞARI !!!", MessageBoxButtons.OK);

            tbSalonSil.Text = "";
               
            baglan.Close();
        }

        public void seansKayitGoster()
        {
            baglan.Open();

            MySqlCommand komut = new MySqlCommand("SELECT seansSaati FROM seans", baglan);
            MySqlDataReader oku = komut.ExecuteReader();

            while ( oku.Read() )
            {
                ListViewItem ekle = new ListViewItem();


                ekle.Text = oku["seansSaati"].ToString();
                

                lwFilm.Items.Add(ekle);
            }

            baglan.Close();
        }

        public void seansEkle()
        {
            baglan.Open();

         
            if( tbSeansSaati.Text == "" )
            {
                MessageBox.Show("Lütfen boş bırakmayınız...", "HATA !!!", MessageBoxButtons.OK);
            }
            else
            {
                MySqlCommand komut = new MySqlCommand("INSERT INTO seans(seansSaati) VALUES('" + tbSeansSaati.Text.ToString() + "') ", baglan);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("seans bilgisi veritabanına kayıt edildi...", "BAŞARI !!!", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("kayıt veritabanına kaydedilemedi...", "HATA !!!", MessageBoxButtons.OK);
            }

            tbSeansSaati.Text = "";

            baglan.Close();
            
        }

        public void seansSil()
        {
            baglan.Open();

            MySqlCommand komut = new MySqlCommand("DELETE FROM seans WHERE seansID = "+ tbSeansSil.Text.ToString() +" ", baglan);
            komut.ExecuteNonQuery();

            if( komut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("HATA !! seans kaydı silinemedi...");
            }
            else
                MessageBox.Show("seans kaydi başarıyla veritabanından silindi...");

            tbSeansSil.Text = "";

            baglan.Close();
        }
      
       
        private void butonFilm_Click(object sender, EventArgs e)
        {
            groupBoxFilm.Enabled = true;
            groupBoxFilm2.Visible = false;
            groupBoxFilm2.Enabled = false;
            groupBoxSalon.Enabled = false;
            groupBoxSalon2.Enabled = false;
            groupBoxSeans.Enabled = false;
            groupBoxSeans2.Enabled = false;
            
        }

        private void butonSalon_Click(object sender, EventArgs e)
        {
            groupBoxSalon.Enabled = true;
            groupBoxSalon2.Visible = false;
            groupBoxSalon2.Enabled = false;
            groupBoxFilm.Enabled = false;
            groupBoxFilm2.Enabled = false;
            groupBoxSeans.Enabled = false;
            groupBoxSeans2.Enabled = false;
        }

        private void butonSeans_Click(object sender, EventArgs e)
        {
            groupBoxSeans.Enabled = true;
            groupBoxSeans2.Visible = false;
            groupBoxSeans2.Enabled = false;
            groupBoxFilm.Enabled = false;
            groupBoxFilm2.Enabled = false;
            groupBoxSalon.Enabled = false;
            groupBoxSalon2.Enabled = false;
        }

        private void butonFilmGoster_Click(object sender, EventArgs e)
        {
            lwFilm.Visible = true;
            lwFilm.Items.Clear();

            columnHeader1.Text = "Film Kodu";
            columnHeaderFilmAdi.Text = "Filmin Adı";
            columnHeaderFilmTuru.Text = "Filmin Türü";
            columnHeader3D.Text = "Film 3D mi ?";
            columnHeaderSure.Text = "Filmin Süresi";
            columnHeaderYapimci.Text = "Filmin Yapımcısı";
         
            filmKayitGoster();
 
        }

        private void butonSalonGoster_Click(object sender, EventArgs e)
        {
            lwFilm.Visible = true;
            lwFilm.Items.Clear();

            columnHeader1.Text = "Salon ID";
            columnHeaderFilmAdi.Text = "Salonun Adı";
            columnHeaderFilmTuru.Text = "Salonun Kapasitesi";
            columnHeader3D.Text = "";
            columnHeaderSure.Text = "";
            columnHeaderYapimci.Text = "";
           
            salonKayitGoster();

        }

        private void butonSeansGoster_Click(object sender, EventArgs e)
        {
            lwFilm.Visible = true;
            lwFilm.Items.Clear();

            columnHeader1.Text = "Seans Saatleri";
            columnHeaderFilmAdi.Text = "";
            columnHeaderFilmTuru.Text = "";
            columnHeader3D.Text = "";
            columnHeaderSure.Text = "";
            columnHeaderYapimci.Text = "";
         
            seansKayitGoster();
        }

        private void adminPaneli_Load(object sender, EventArgs e)
        {
            groupBoxFilm.Enabled = false;
            groupBoxFilm2.Enabled = false;
            groupBoxFilm2.Visible = false;
            groupBoxSalon.Enabled = false;
            groupBoxSalon2.Enabled = false;
            groupBoxSalon2.Visible = false;
            groupBoxSeans.Enabled = false;
            groupBoxSeans2.Enabled = false;
            groupBoxSeans2.Visible = false;
          
        }

        private void butonFilmKaydet_Click(object sender, EventArgs e)
        {
            filmEkle();
        }

        private void butonSalonKaydet_Click(object sender, EventArgs e)
        {
            salonEkle();
        }

        private void butonSeansKaydet_Click(object sender, EventArgs e)
        {
            seansEkle();
        }

        private void butonFilmSil_Click(object sender, EventArgs e)
        {       
            groupBoxFilm2.Visible = true;
            groupBoxFilm2.Enabled = true;
            groupBoxSalon.Enabled = false;
            groupBoxSalon2.Enabled = false;
            groupBoxSeans.Enabled = false;
            groupBoxSeans2.Enabled = false;        

        }

        private void butonSalonSil_Click(object sender, EventArgs e)
        {
            groupBoxSalon2.Visible = true;
            groupBoxSalon2.Enabled = true;
            groupBoxFilm.Enabled = false;
            groupBoxFilm2.Enabled = false;
            groupBoxSeans.Enabled = false;
            groupBoxSeans2.Enabled = false;
        }

        private void butonSeansSil_Click(object sender, EventArgs e)
        {
            groupBoxSeans2.Visible = true;
            groupBoxSeans2.Enabled = true;
            groupBoxFilm.Enabled = false;
            groupBoxFilm2.Enabled = false;
            groupBoxSalon.Enabled = false;
            groupBoxSalon2.Enabled = false;
        }

        private void bFilmSil_Click(object sender, EventArgs e)
        {
            filmSil();
        }

        private void bSalonSil_Click(object sender, EventArgs e)
        {
            salonSil();
        }

        private void bSeansSil_Click(object sender, EventArgs e)
        {
            seansSil();
        }

        private void groupBoxFilm2_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
