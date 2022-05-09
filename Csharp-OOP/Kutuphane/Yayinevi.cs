using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Kutuphane
{
    public class Yayinevi
    {
        public string Ad { get; set; }
        public int KurulusYili { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yayinevi(string ad, int kurulusTarihi)
        {
            Ad = ad;
            KurulusYili = kurulusTarihi;
        }
    }
}
