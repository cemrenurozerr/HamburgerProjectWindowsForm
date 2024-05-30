using HamburgerProject.Concrete;
using HamburgerProject.Utilities;
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
    public partial class EkstraMalzemeEklemeEkrani : Form
    {
        public EkstraMalzemeEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string malzemeAdi = txtAd.Text;
            decimal malzemeFiyat=nudFiyat.Value;

            if(string.IsNullOrEmpty(malzemeAdi)|| malzemeFiyat<=0 ) 
            {
                MessageBox.Show("Menu adı boş olamaz\n Fiyat 0 ya da daha az olamaz.");
                return;
            }
            
            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            ekstraMalzeme.Ad = malzemeAdi;
            ekstraMalzeme.Fiyat = malzemeFiyat;

            AnaEkran.EkstraMalzemeler.Add(ekstraMalzeme);

            Helper.Temizle(this.Controls);
        }
    }
}
