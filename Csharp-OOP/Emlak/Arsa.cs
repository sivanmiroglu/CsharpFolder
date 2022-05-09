using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Emlak
{
    public class Arsa : Emlak
    {
        public Arsa(string lokasyon) : base(lokasyon)
        {

        }

        public bool ImaraAcikMİ { get; set; }
        public bool KopekVarMi { get; set; }
    }
}
