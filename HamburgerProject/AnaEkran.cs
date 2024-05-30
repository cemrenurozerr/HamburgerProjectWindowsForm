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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        public static List<EkstraMalzeme> EkstraMalzemeler = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme()
            {
                Ad="Ketçap",
                Fiyat=10
            },
             new EkstraMalzeme()
            {
                Ad="Mayonez",
                Fiyat=10
            }
        };
        public static List<Menu> Menuler = new List<Menu>()   {
            new Menu()
            {
                Ad="Whopper",
                Fiyat=200
            },
             new Menu()
            {
                Ad="Big Chicken",
                Fiyat=180
            }
        };
        public static List<Siparis> Siparisler = new List<Siparis>();
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            EkranOlustur(new SiparisOlusturEkrani());

            //SiparisOlusturEkrani siparisOlusturEkrani = new SiparisOlusturEkrani();
            //EkranOlustur(siparisOlusturEkrani);
        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkranOlustur(new SiparisOlusturEkrani());
        }
        private void siparişleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkranOlustur(new TumSiparislerEkrani());
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkranOlustur(new MenuEklemeEkrani());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkranOlustur(new EkstraMalzemeEklemeEkrani());
        }

        private void EkranOlustur(Form form)
        {
            EkranlariKapat();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;

            this.Width = form.Width + 50;
            this.Height = form.Height + 100;

            form.Show();
        }

        private void EkranlariKapat()
        {
            Form[] cocukFormlar = this.MdiChildren;
            foreach (Form form in cocukFormlar)
            {
                form.Close();
            }
        }
    }
}
