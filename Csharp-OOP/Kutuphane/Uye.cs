using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Kutuphane
{
    public class Uye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Adres { get; set; }
        public string TelNo { get; set; }

        public Uye(string ad, string soyad, string tcno, string adres, string telno)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.TcNo = tcno;
            this.Adres = adres;
            this.TelNo = telno;

        }
    }
}
