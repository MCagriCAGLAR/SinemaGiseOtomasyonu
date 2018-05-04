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
using WMPLib;
using AxWMPLib;

namespace SinemaGiseOtomasyonu
{
    public partial class musteriPaneli : Form
    {
        public musteriPaneli()
        {
            InitializeComponent();
        }
        1
        MySqlConnection baglan = new MySqlConnection("Database = sinemagisesi; DataSource = localhost; UserID = root;");

        string seansSaatiGonder;
        string filmAdiGonder;
        string salonAdiGonder;
        string fragmanGonder;
        private object resources;

        private void musteriPaneli_Load(object sender, EventArgs e)
        {

            baglan.Open();

            MySqlCommand komutFilm = new MySqlCommand("SELECT filmAdi from filmler", baglan);
            MySqlDataReader oku = komutFilm.ExecuteReader();

            while( oku.Read())
            {
                cbFilmlerListesi.Items.Add(oku.GetString(0).ToString());
            }

            baglan.Close();

            baglan.Open();

            MySqlCommand komutSalon = new MySqlCommand("SELECT salonAdi from salon", baglan);
            MySqlDataReader oku2 = komutSalon.ExecuteReader();

            while(oku2.Read())
            {
                cbSalonListesi.Items.Add( oku2.GetString(0).ToString() );
            }

            baglan.Close();


        }

        private void cbFilmlerListesi_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbSalonListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSeansSaatleri.Items.Clear();
            baglan.Open();

            MySqlCommand komutSeans = new MySqlCommand("SELECT seansSaati FROM seans", baglan);
            MySqlDataReader oku3 = komutSeans.ExecuteReader();

            while (oku3.Read())
            {
                lbSeansSaatleri.Items.Add(oku3.GetString(0).ToString());
            }

            baglan.Close();

            baglan.Open();

            MySqlCommand komutSalonNo = new MySqlCommand("SELECT salonID FROM salon WHERE salonAdi = '" + cbSalonListesi.Text.ToString() + "' ", baglan);
            MySqlCommand komutKapasite = new MySqlCommand("SELECT salonKapasite FROM salon WHERE salonAdi = '" + cbSalonListesi.Text.ToString() + "' ", baglan);

            int salonKapasite;
            int salonNo;
            salonNo = Convert.ToInt16(komutSalonNo.ExecuteScalar());
            salonKapasite = Convert.ToInt16(komutKapasite.ExecuteScalar());
            lbSalonNo.Text = salonNo.ToString();
            lbSalonKapasite.Text = salonKapasite.ToString();

            baglan.Close();

        }

        private void lbSeansSaatleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSeansSaati.Text = lbSeansSaatleri.SelectedItem.ToString();
        }

        
        private void butonBiletAl_Click(object sender, EventArgs e)
        {
            BiletSatis formBilet = new BiletSatis();

            seansSaatiGonder = lbSeansSaati.Text.ToString();
            filmAdiGonder = cbFilmlerListesi.Text.ToString();
            salonAdiGonder = cbSalonListesi.Text.ToString();

            formBilet.seansSaatiAl = seansSaatiGonder.ToString();
            formBilet.filmAdiAl = filmAdiGonder.ToString();
            formBilet.salonAdiAl = salonAdiGonder.ToString();
           
            this.Hide();
            formBilet.Show();

                      
        }

        private void Film1_Click(object sender, EventArgs e)
        {
            label8.Text = "Xmen";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void Film2_Click(object sender, EventArgs e)
        {
            label8.Text = "AngryBirds";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void Film3_Click(object sender, EventArgs e)
        {
            label8.Text = "KaptanAmerika";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void Film4_Click(object sender, EventArgs e)
        {
            label8.Text = "DehsetTreni";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void Film5_Click(object sender, EventArgs e)
        {
            label8.Text = "ColKralicesi";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void Film6_Click(object sender, EventArgs e)
        {
            label8.Text = "AnkaraYazi";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void film7_Click(object sender, EventArgs e)
        {
            label8.Text = "BatmanVSuperman";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void film8_Click(object sender, EventArgs e)
        {
            label8.Text = "Kolpacino";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }

        private void film9_Click(object sender, EventArgs e)
        {
            label8.Text = "Magi";
            fragmanGonder = label8.Text.ToString();
            fragman.fragmanAl = fragmanGonder.ToString();

            fragman fragmanPanel = new fragman();
            fragmanPanel.Show();
        }
    }
}
