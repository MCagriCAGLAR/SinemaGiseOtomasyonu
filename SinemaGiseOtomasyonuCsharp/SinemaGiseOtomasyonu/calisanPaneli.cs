using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaGiseOtomasyonu
{
    public partial class calisanPaneli : Form
    {
        public calisanPaneli()
        {
            InitializeComponent();
        }

        private void butonBiletIptal_Click(object sender, EventArgs e)
        {
            biletIptal formBiletIptal = new biletIptal();
            formBiletIptal.Show();
            this.Hide();
        }

        private void butonBiletSat_Click(object sender, EventArgs e)
        {
            musteriPaneli formMusteriPanel = new musteriPaneli();
            formMusteriPanel.Show();
            this.Hide();
        }
    }
}
