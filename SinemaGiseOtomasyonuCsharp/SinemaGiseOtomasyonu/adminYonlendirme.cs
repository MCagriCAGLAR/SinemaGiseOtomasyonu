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
    public partial class adminYonlendirme : Form
    {
        public adminYonlendirme()
        {
            InitializeComponent();
        }

        private void butonFSS_Click(object sender, EventArgs e)
        {
            adminPaneli FSSpanel = new adminPaneli();
            this.Hide();
            FSSpanel.Show();
        }

        private void butonCalisanEkleSil_Click(object sender, EventArgs e)
        {
            adminCalisanEkleSil calisanEkleSilPanel = new adminCalisanEkleSil();
            this.Hide();
            calisanEkleSilPanel.Show();
        }
    }
}
