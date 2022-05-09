using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.HastaneOrnek
{
    public class Doktor : BaseModel // BaseModel miras alarak oradaki bilgileri Kullandık.
    { 
        // constructor alarak doktor sınıfına özellik ekledik.
        // Ad base modelden alındığı için property yani özellik vermedik 

        public Doktor(string ad, string soyad) 
        {                                        
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Doktor(string ad,string soyad, Poliklinik poliklinik)
        {
            this.Ad = ad;
            this.Soyad = soyad; // soyad property vermeseydik soyad kısmının altını kırmızı .çizerdi çünkü tanımlamamış olurduk.
            this.Poliklinik = poliklinik;
        }

        // propertyler vererek yukarıda constructor tanımladık.
        public string Soyad { get; set; }

        public string SicilNo { get; set; }

        public Poliklinik Poliklinik { get; set; } 

    }
}
