using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.HastaneOrnek
{
    public class Poliklinik : BaseModel
    {
        public Poliklinik()
        {
            // constructor
        }

        public Poliklinik(string ad,int yil)
        {
            this.KurulusYil = yil;
            this.Ad = ad;
        }
        public int KurulusYil { get; set; } 
    }
}
