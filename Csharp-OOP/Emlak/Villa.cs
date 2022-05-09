using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Emlak
{
    public class Villa : Ev
    {
        public Villa(string lokasyon, int odaSayisi) : base(lokasyon, odaSayisi)
        {

        }

        public bool HavuzVarMi { get; set; }
        public int BahceAlan { get; set; }
        public int GarajAlan { get; set; }

        
    }
}
