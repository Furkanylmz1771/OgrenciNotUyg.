using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci
{
    class Ogrenci
    {
        public Ogrenci()
        {
            Dersler = new List<Ders>();
        }
        public string Adi
        {
            get; set;

        }
        public string SoyAdi { get; set; }

        public Alan Alani { get; set; }

        public List<Ders> Dersler { get; set; }       
        
        public decimal Ortalama
        {
            get
            {
                decimal toplam = 0;
                foreach (Ders not in Dersler)
                {
                    toplam += not.Ortalama;
                }
                return toplam / Dersler.Count();
            }
        }
    }

    public OgrenciDurum Durum
    {
        get
        {
            if (Ortalama >= 70)
            {
                return OgrenciDurum.Gecti;
            }else if(Ortalama >= 50)
            {
                return OgrenciDurum.ŞartlıGecti;
            }
            else
            {
                return OgrenciDurum.Kaldı;
            }
        }
    }


    struct Ders 
    {

        public string Adi
        {
            get; set;
        }

        public decimal Vize
        {
            get; set;
        }
        public decimal Final { get; set; }

        public decimal Ortalama
        {
            get
            {
                return Vize * 0.4m + Final * 0.6m;  // Decimal için m
            }
        }
    
    }

    enum OgrenciDurum           // enum bir seçenek listesidir. Programcının nesne ile ilgili durumları kontrol etmesini sağlar.
    {
        Gecti,
        Kaldı,
        ŞartlıGecti,
        Devamsız,
        Tekrar
    }

    enum Alan
    {
        Sayisal,
        Sözel,
        EşitAgırlık,
        Dil

    }


}