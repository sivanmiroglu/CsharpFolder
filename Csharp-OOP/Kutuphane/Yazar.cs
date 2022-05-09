using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Kutuphane
{
    public class Yazar
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yazar(string ad, string soyad, string ulke)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Ulke = ulke;
        }
    }
}
