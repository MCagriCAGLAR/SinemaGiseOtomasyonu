using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SinemaGiseOtomasyonu
{
    public partial class BiletSatis : Form
    {
        public BiletSatis()
        {
            InitializeComponent();
        }

        MySqlConnection baglan = new MySqlConnection("Database = sinemagisesi; DataSource = localhost; UserID = root;");

        public string seansSaatiAl;
        public string filmAdiAl;
        public string salonAdiAl;
        public double ucret;
        int filmID = 0;
        int salonID = 0;
        int seansID = 0;
        int musteriID = 0;
        public static string[] dizi = new string[40];

        ArrayList koltuklar = new ArrayList();
        ArrayList iptalKoltuk = new ArrayList();

        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            
            if (((Button)sender).BackColor == Color.Chartreuse)
            {
                ((Button)sender).BackColor = Color.Orange;
                if (!koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Add(((Button)sender).Text);
                }
                koltukYazdir();
            }

            else if (((Button)sender).BackColor == Color.Orange) 
            {
                ((Button)sender).BackColor = Color.Chartreuse;
                if (koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Remove(((Button)sender).Text);
                }
                koltukYazdir();
            }

            else 
            {
                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {
                    iptalKoltuk.Add(((Button)sender).Text);
                }
                else
                {
                    iptalKoltuk.Remove(((Button)sender).Text);
                }

                string koltuk = "";
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    koltuk += iptalKoltuk[i].ToString() + ",";
                }
                if (iptalKoltuk.Count >= 1)
                {
                    koltuk = koltuk.Remove(koltuk.Length - 1, 1);
                }
                tbKoltuk.Text = koltuk;
            }
        }

        private void koltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                koltuk += koltuklar[i].ToString() + ",";
            }
            if (koltuklar.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);
            }
            tbKoltuk.Text = koltuk;
        }

        private void biletAl()
        {
            baglan.Open();
            int i;
       
            for(i = 0; i < koltuklar.Count; i++)
            {
                MySqlCommand musteriEkle = new MySqlCommand("INSERT INTO musteri(musteriAdi, musteriSoyadi) VALUES('" + tbAd.Text.ToString() + "' , '" + tbSoyad.Text.ToString() + "') ", baglan);
                musteriEkle.ExecuteNonQuery();

                MySqlCommand komutMusteriID = new MySqlCommand("SELECT musteriID FROM musteri WHERE musteriAdi = '" + tbAd.Text.ToString() + "' AND musteriSoyadi = '" + tbSoyad.Text.ToString() + "' ", baglan);
                musteriID = Convert.ToInt16(komutMusteriID.ExecuteScalar());

                MySqlCommand komut = new MySqlCommand(" INSERT INTO bilet(filmID, salonID, seansID, biletTarih, biletSaat,  koltukNo, biletFiyat, musteriID) VALUES("+ filmID +" , "+ salonID +" , "+ seansID +" , '"+ tbTarih.Text.ToString() +"' , '"+ labelSaatNow.Text.ToString() +"' ,  '"+ koltuklar[i].ToString() +"' , '"+ labelTutar.Text +"' , "+ musteriID +") ", baglan);
                komut.ExecuteNonQuery();

                this.Controls.Find("buton" + koltuklar[i].ToString(), true)[0].BackColor = Color.Red;
            }

            MessageBox.Show("Biletiniz alınmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koltuklar.Clear();

            baglan.Close();
            
        }

       
        private void BiletSatis_Load(object sender, EventArgs e)
        {
            baglan.Open();

            int i = 0;

            MySqlCommand komutFilmID = new MySqlCommand("SELECT filmID FROM filmler WHERE filmAdi = '" + filmAdiAl + "' ", baglan);
            filmID = Convert.ToInt16(komutFilmID.ExecuteScalar());

            MySqlCommand komutSalonID = new MySqlCommand("SELECT salonID FROM salon WHERE salonAdi = '"+ salonAdiAl +"' ", baglan);
            salonID = Convert.ToInt16(komutSalonID.ExecuteScalar());

            MySqlCommand komutSeansID = new MySqlCommand("SELECT seansID FROM seans WHERE seansSaati = '"+ seansSaatiAl +"' ", baglan);
            seansID = Convert.ToInt16(komutSeansID.ExecuteScalar());

            MySqlCommand koltuk = new MySqlCommand("SELECT koltukNo FROM bilet WHERE salonID=" + salonID +" AND seansID ="+ seansID +" ", baglan);
            MySqlDataReader oku = koltuk.ExecuteReader();

            while(oku.Read())
            {
                dizi[i] = oku[0].ToString();
                i++;
            }
            
            tbSeans.Text = seansSaatiAl.ToString();
            tbSeans.Enabled = false;

            tbTarih.Text = DateTime.Now.ToShortDateString();
            tbTarih.Enabled = false;

            labelFilmAdi.Text = filmAdiAl.ToString();
            labelSalonAdi.Text = salonAdiAl.ToString();

         
            baglan.Close();


            for(i = 0; i < 40; i++)
            {
                string a = dizi[i];
               
                switch (a)
                {
                    case "A1":
                        butonA1.Enabled = false;
                        butonA1.BackColor = Color.Red;
                        break;
                    case "A2":
                        butonA2.Enabled = false;
                        butonA2.BackColor = Color.Red;
                        break;
                    case "A3":
                        butonA3.Enabled = false;
                        butonA3.BackColor = Color.Red;
                        break;
                    case "A4":
                        butonA4.Enabled = false;
                        butonA4.BackColor = Color.Red;
                        break;
                    case "A5":
                        butonA5.Enabled = false;
                        butonA5.BackColor = Color.Red;
                        break;
                    case "A6":
                        butonA6.Enabled = false;
                        butonA6.BackColor = Color.Red;
                        break;
                    case "B1":
                        butonB1.Enabled = false;
                        butonB1.BackColor = Color.Red;
                        break;
                    case "B2":
                        butonB2.Enabled = false;
                        butonB2.BackColor = Color.Red;
                        break;
                    case "B3":
                        butonB3.Enabled = false;
                        butonB3.BackColor = Color.Red;
                        break;
                    case "B4":
                        butonB4.Enabled = false;
                        butonB4.BackColor = Color.Red;
                        break;
                    case "B5":
                        butonB5.Enabled = false;
                        butonB5.BackColor = Color.Red;
                        break;
                    case "B6":
                        butonB6.Enabled = false;
                        butonB6.BackColor = Color.Red;
                        break;
                    case "C1":
                        butonC1.Enabled = false;
                        butonC1.BackColor = Color.Red;
                        break;
                    case "C2":
                        butonC2.Enabled = false;
                        butonC2.BackColor = Color.Red;
                        break;
                    case "C3":
                        butonC3.Enabled = false;
                        butonC3.BackColor = Color.Red;
                        break;
                    case "C4":
                        butonC4.Enabled = false;
                        butonC4.BackColor = Color.Red;
                        break;
                    case "D1":
                        butonD1.Enabled = false;
                        butonD1.BackColor = Color.Red;
                        break;
                    case "D2":
                        butonD2.Enabled = false;
                        butonD2.BackColor = Color.Red;
                        break;
                    case "D3":
                        butonD3.Enabled = false;
                        butonD3.BackColor = Color.Red;
                        break;
                    case "D4":
                        butonD4.Enabled = false;
                        butonD4.BackColor = Color.Red;
                        break;
                    case "E1":
                        butonE1.Enabled = false;
                        butonE1.BackColor = Color.Red;
                        break;
                    case "E2":
                        butonE2.Enabled = false;
                        butonE2.BackColor = Color.Red;
                        break;
                    case "E3":
                        butonE3.Enabled = false;
                        butonE3.BackColor = Color.Red;
                        break;
                    case "E4":
                        butonE4.Enabled = false;
                        butonE4.BackColor = Color.Red;
                        break;
                    case "E5":
                        butonE5.Enabled = false;
                        butonE5.BackColor = Color.Red;
                        break;
                    case "E6":
                        butonE6.Enabled = false;
                        butonE6.BackColor = Color.Red;
                        break;
                    case "F1":
                        butonF1.Enabled = false;
                        butonF1.BackColor = Color.Red;
                        break;
                    case "F2":
                        butonF2.Enabled = false;
                        butonF2.BackColor = Color.Red;
                        break;
                    case "F3":
                        butonF3.Enabled = false;
                        butonF3.BackColor = Color.Red;
                        break;
                    case "F4":
                        butonF4.Enabled = false;
                        butonF4.BackColor = Color.Red;
                        break;
                    case "F5":
                        butonF6.Enabled = false;
                        butonF6.BackColor = Color.Red;
                        break;
                    case "F6":
                        butonF6.Enabled = false;
                        butonF6.BackColor = Color.Red;
                        break;
                    case "G1":
                        butonG1.Enabled = false;
                        butonG1.BackColor = Color.Red;
                        break;
                    case "G2":
                        butonG2.Enabled = false;
                        butonG2.BackColor = Color.Red;
                        break;
                    case "G3":
                        butonG3.Enabled = false;
                        butonG3.BackColor = Color.Red;
                        break;
                    case "G4":
                        butonG4.Enabled = false;
                        butonG4.BackColor = Color.Red;
                        break;
                    case "H1":
                        butonH1.Enabled = false;
                        butonH1.BackColor = Color.Red;
                        break;
                    case "H2":
                        butonH2.Enabled = false;
                        butonH2.BackColor = Color.Red;
                        break;
                    case "H3":
                        butonH3.Enabled = false;
                        butonH3.BackColor = Color.Red;
                        break;
                    case "H4":
                        butonH4.Enabled = false;
                        butonH4.BackColor = Color.Red;
                        break;

                }
            }
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaatNow.Text = DateTime.Now.ToLongTimeString();
        }

        private void groupBox1BiletSatis_Enter(object sender, EventArgs e)
        {

        }

        private void cbTam_CheckedChanged(object sender, EventArgs e)
        {
            cbOgrenci.Enabled = false;
            ucret = Convert.ToDouble(labelTamUcret.Text.ToString());
            labelTutar.Text = ucret.ToString();

            if (cbTam.Checked == false)
            {
                cbOgrenci.Enabled = true;
                labelTutar.Text = "0.00";
            }
        }

        private void cbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            cbTam.Enabled = false;
            ucret = Convert.ToDouble(labelOgrenciUcret.Text.ToString());
            labelTutar.Text = ucret.ToString();

            if (cbOgrenci.Checked == false)
            {
                cbTam.Enabled = true;
                labelTutar.Text = "0.00";
            }

        }

        private void butonSatinAl_Click(object sender, EventArgs e)
        {

            if (tbTarih.Text != "" && tbSeans.Text != "" && tbAd.Text != "" && tbSoyad.Text != "" && tbKoltuk.Text != "")
            {
                biletAl();

                tbAd.Text = "";
                tbSoyad.Text = "";
                tbKoltuk.Text = "";

                cbOgrenci.Checked = false;
                cbTam.Checked = false;
            }
            else
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "UYARI !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

       
    }
}
