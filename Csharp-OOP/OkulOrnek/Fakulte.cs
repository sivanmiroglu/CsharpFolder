using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.OkulOrnek
{
    public class Fakulte
    {
        public Fakulte()
        {

        }
        public Fakulte(string ad)
        {
            this.Ad = ad;
        }
        string _ad = "";

        public string Ad
        {

            get
            {
                return _ad.ToUpper();
            }



            set
            {
                _ad = value;
            }
        }
        public int KurulusYil { get; set; }
    }
}
