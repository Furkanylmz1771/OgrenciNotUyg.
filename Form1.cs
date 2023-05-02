using Ogrenci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    public partial class Form1 : Ogrenci
    {
        private readonly object MessageBox;
        public Form1() {

            InitializeComponent();  // Nesneye  ait olan üye elemanlarla(button, label, textbox vs) ilgili ilk işlemler yapılır.

        }


        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        private void Form1.load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Furkan";
            ogr.SoyAdi = "Yılmaz";
            ogr.Alani = Alan.Sözel;


            Ders d = new Ders { Adi = "Matematik", Vize = 50, Final = 30 };
            Ders d2 = new Ders { Adi = "Kimya", Vize = 80,Final=40 };


            ogr.Dersler.Add(d);
            ogr.Dersler2.Add();
            int durum = (int)ogr.durum;


            switch (ogr.Durum)
            {
                case OgrenciDurum.Gecti:
                    MessageBox.Show("Sınıfı Geçtiniz");
                    break;

                case OgrenciDurum.Kaldı:
                    MessageBox.Show("Sınıfta kaldınız");
                    break;

                case OgrenciDurum.ŞartlıGecti:
                    MessageBox.Show("ŞartlıGeçtiniz");
                    break;

                case OgrenciDurum.Devamsız:
                    MessageBox.Show(" Devamsızlıktan kaldınız");
                    break;

                case OgrenciDurum.Tekrar:
                    MessageBox.Show("Tekrar");
                    break;
            }

        }


    }
  
}   