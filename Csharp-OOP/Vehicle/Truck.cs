using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Vehicle
{
    public class Truck : Vehicle // vehicle yani araçlar clasından  miras aldık.
    {

        public int VisaDate
        {
            get
            {
                return CalcVisaDate(ReleaseYear);
            }
        }


        public override bool isRefilOil
        {
            get
            {
                return isRefillOil(OilLevel - 10);
            }
        }


        protected override int CalcVisaDate(int releaseYear)
        {
            return releaseYear + 20;
        }
    }
}
