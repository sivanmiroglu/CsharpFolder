using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.OkulOrnek
{
    public class Ogrenci
    {
        public Ogrenci()
        {

        }
        public Ogrenci(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public string Ad { get; set; }
        public string  Soyad { get; set; }
        public string No { get; set; }
        public Bolum Bolum { get; set; }
    }
}
