﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void butonAdmin_Click(object sender, EventArgs e)
        {
            adminGirisi adminForm = new adminGirisi();
            adminForm.Show();
            this.Hide();
        }

        private void butonMusteri_Click(object sender, EventArgs e)
        {
            calisanPaneli formCalisanPanel = new calisanPaneli();
            formCalisanPanel.Show();
            this.Hide();
        }

        private void butonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
