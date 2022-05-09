using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Emlak
{
    public class Ev : Emlak
    {

        public Ev(string lokasyon, int odaSayisi) : base(lokasyon)  //  emlak lokasyon istediği için base de lokasyon girilir. base de yukarı yani miras aldığımız kısım ne istiyorsa onu base gireriz. GENEL DE!
        {
            OdaSayisi = odaSayisi;  // Constructor almak !!!  evdeki oda saysını zorunlu tuttsun..!!
        }


        public int OdaSayisi { get; set; }
        public int Kat { get; set; }
        public bool EbeveynBanyoVarMi
        {
            get
            {
                return LuksMu;
            }

        }
        public bool LuksMu { get; set; }


    }
}