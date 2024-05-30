using HamburgerProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerProject.Concrete
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }
        public Menu Menu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public Boy boy { get; set; }
        public int Adet { get; set; }
        public decimal Toplam
        {
            get
            {
                decimal toplam = 0;
                if (boy == Boy.Orta)
                {
                    toplam += Menu.Fiyat * 1.1m;
                }
                else if (boy == Boy.Büyük)
                {
                    toplam += Menu.Fiyat * 1.2m;
                }
                else toplam = Menu.Fiyat;

                toplam += ToplamEkstraMalzemeFiyatiGetir();

                toplam *= Adet;

                return toplam;
            }
        }
        public override string ToString()
        {
            string bilgi = string.Empty;
            bilgi += Adet + " Adet " + Menu + " " + boy + " ";
            string ekstraMalzemeIsimleri = EkstraMalzemeleriGetir();
            bilgi += ekstraMalzemeIsimleri;

            bilgi += " => " + Toplam;
            return bilgi;
        }
        private string EkstraMalzemeleriGetir()
        {
            string ekstraMalzemeler = string.Empty;
            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                ekstraMalzemeler += ekstra.Ad + ",";
            }
            return ekstraMalzemeler;
        }

        public decimal ToplamEkstraMalzemeFiyatiGetir()
        {
            decimal toplam = 0;
            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                toplam += ekstra.Fiyat;
            }
            return toplam;
        }
    }
}
