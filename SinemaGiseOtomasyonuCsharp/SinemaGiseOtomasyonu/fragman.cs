using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace SinemaGiseOtomasyonu
{
    public partial class fragman : Form
    {
        public fragman()
        {
            InitializeComponent();
        }

        public static string fragmanAl;

        private void fragman_Load(object sender, EventArgs e)
        {
            string a = fragmanAl.ToString();

            switch (a)
            {
                case "Xmen":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\Xmen.mp4";
                    break;
                case "AngryBirds":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\AngryBirds.mp4";
                    break;
                case "KaptanAmerika":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\KaptanAmerika.mp4";
                    break;
                case "DehsetTreni":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\DehsetTreni.mp4";
                    break;
                case "ColKralicesi":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\ColKralicesi.mp4";
                    break;
                case "AnkaraYazi":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\AnkaraYazi.mp4";
                    break;
                case "BatmanVSuperman":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\BatmanVsuperman.mp4";
                    break;
                case "Kolpacino":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\Kolpacino.mp4";
                    break;
                case "Magi":
                    WMPfilm.URL = "C:\\Users\\W1nchester\\Desktop\\zfragmans\\Magi.mp4";
                    break;

            }
        }
    }
}
