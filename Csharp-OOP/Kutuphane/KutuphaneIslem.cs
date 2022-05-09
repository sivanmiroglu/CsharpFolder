using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_OOP.Kutuphane;

namespace Csharp_OOP.Kutuphane
{
    public class KutuphaneIslem
    {
        List<KutuphaneKayit> kutuphanekayit = new List<KutuphaneKayit>();


        DateTime dt = DateTime.Now;

        public DateTime alisTarihi { get; set; }

        public DateTime iadeTarihi { get; set; }

        public TimeSpan ts { get; set; }

        public int cezaTutari { get; set; } = 0;



        public void kitapal(Uye uye, string kitapadi, DateTime date)
        {

            alisTarihi = date;


            KutuphaneKayit kitapalimkaydi = new KutuphaneKayit(uye, kitapadi, date);
            kutuphanekayit.Add(kitapalimkaydi);

        }


        public void kitapiade(Uye uye, string kitapadi, DateTime date)
        {
            iadeTarihi = date;

            KutuphaneKayit kitapiadekaydi = new KutuphaneKayit(uye, kitapadi, date);
            kutuphanekayit.Add(kitapiadekaydi);

            ts = iadeTarihi - alisTarihi;
            if (ts.Days > 7)
            {
                cezaTutari = (ts.Days - 7) * 5;
            }



        }
    }
}
