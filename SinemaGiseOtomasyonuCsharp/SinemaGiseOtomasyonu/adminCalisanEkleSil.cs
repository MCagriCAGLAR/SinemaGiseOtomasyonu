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
    public partial class adminCalisanEkleSil : Form
    {
        public adminCalisanEkleSil()
        {
            InitializeComponent();
        }

        MySqlConnection baglan = new MySqlConnection("Database = sinemagisesi; DataSource = localhost; UserID = root");

        private void calisanEkle()
        {
            baglan.Open();


            if ( tbCalisanAdi.Text == "" || tbCalisanSoyadi.Text == "" || tbKullaniciAdi.Text == "" || tbSifre.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Lutfen bos alan bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MySqlCommand komut = new MySqlCommand("INSERT INTO calisan(calisanAdi, calisanSoyadi, calisanLoginID, calisanPassword, calisanDTarihi) VALUES('"+ tbCalisanAdi.Text.ToString() +"' , '"+ tbCalisanSoyadi.Text.ToString() +"' , '"+ tbKullaniciAdi.Text.ToString() +"' , '"+ tbSifre.Text.ToString() +"' , '"+ dateTimePicker1.Text.ToString() +"') ", baglan);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Calisan bilgileri basariyla veritabanına eklendi...", "BAŞARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("kayit veritabanına eklenemedi...", "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbCalisanAdi.Text = "";
            tbCalisanSoyadi.Text = "";
            tbKullaniciAdi.Text = "";
            tbSifre.Text = "";
            dateTimePicker1.Text = "";

            baglan.Close();
            
        }

        private void calisanSil()
        {
            baglan.Open();

            MySqlCommand komut = new MySqlCommand("DELETE FROM calisan WHERE calisanID = '"+ tbCalisanSil.Text.ToString() +"' ", baglan);

            if (komut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kayit başarıyla veritabanından silindi...", "BAŞARI !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Calisan veritabanından silinemedi... Yanlış Çalışan ID girildi.!", "HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            tbCalisanSil.Text = "";

            baglan.Close();
        }

        private void calisanGoster()
        {
            baglan.Open();
            listViewCalisan.Items.Clear();

            MySqlCommand komut = new MySqlCommand("SELECT * FROM calisan", baglan);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["calisanID"].ToString();
                ekle.SubItems.Add(oku["calisanAdi"].ToString());
                ekle.SubItems.Add(oku["calisanSoyadi"].ToString());
                ekle.SubItems.Add(oku["calisanLoginID"].ToString());
                ekle.SubItems.Add(oku["calisanDTarihi"].ToString());

                listViewCalisan.Items.Add(ekle);
            }

            baglan.Close();
        }

        private void adminCalisanEkleSil_Load(object sender, EventArgs e)
        {
            groupBoxCalisan2.Visible = false;
            groupBoxCalisan2.Enabled = false;
            groupBoxCalisan.Enabled = false;
        }

        private void butonCalisanEkle_Click(object sender, EventArgs e)
        {
            groupBoxCalisan2.Visible = false;
            groupBoxCalisan2.Enabled = false;
            groupBoxCalisan.Visible = true;
            groupBoxCalisan.Enabled = true;
          
        }

        private void butonCalisanSil_Click(object sender, EventArgs e)
        {
            groupBoxCalisan2.Visible = true;
            groupBoxCalisan2.Enabled = true;
            groupBoxCalisan.Visible = false;
            groupBoxCalisan.Enabled = false;

        }

        private void butonCalisanKaydet_Click(object sender, EventArgs e)
        {
            calisanEkle();
        }

        private void butonCalisanCikar_Click(object sender, EventArgs e)
        {
            calisanSil();
        }

        private void butonCalisanGoster_Click(object sender, EventArgs e)
        {
            calisanGoster();
        }
    }
}
