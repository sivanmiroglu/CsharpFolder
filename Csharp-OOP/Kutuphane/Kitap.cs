using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Kutuphane
{
    public class Kitap
    {
        public string Ad { get; set; }
        public DateTime DateTime { get; set; }  
        List<Yazar> Yazarlar { get; set; }
        public Tur TurClass { get; set; }
        public Yayinevi YayıneviClass { get; set; }
        public string ISBBNO { get; } = Guid.NewGuid().ToString();
        public string aciklama { get; set; }

        public Kitap(string ad,DateTime dateTime,Tur Tur,Yayinevi yayinevi,string aciklama)
        {
            this.Ad = ad;
            this.DateTime = dateTime;
            this.TurClass = Tur;
            this.YayıneviClass = yayinevi;
            this.aciklama = aciklama;
        }
    }
}
