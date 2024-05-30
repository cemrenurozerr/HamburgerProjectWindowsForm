using HamburgerProject.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerProject
{
    public partial class TumSiparislerEkrani : Form
    {
        public TumSiparislerEkrani()
        {
            InitializeComponent();
        }

        private void TumSiparislerEkrani_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal toplamEkstraMalzemeGeliri = 0;
            int toplamSatilanUrunAdedi = 0;
            foreach (Siparis siparis in AnaEkran.Siparisler)
            {
                lboxSiparisler.Items.Add(siparis);
                ciro += siparis.Toplam;
                toplamEkstraMalzemeGeliri += siparis.ToplamEkstraMalzemeFiyatiGetir();
                toplamSatilanUrunAdedi += siparis.Adet * siparis.EkstraMalzemeler.Count + siparis.Adet;
            }
            lblCiro.Text = ciro.ToString();

            lblToplamSiparis.Text = AnaEkran.Siparisler.Count.ToString();

            lblEkMalzemeGeliri.Text = toplamEkstraMalzemeGeliri.ToString();

            lblSatilanUrunAdedi.Text = toplamSatilanUrunAdedi.ToString();
        }
    }
}
