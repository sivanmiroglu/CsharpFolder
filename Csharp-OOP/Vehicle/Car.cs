using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Vehicle
{
    public class Car : Vehicle
    {
        public int VisaDate
        {
            get
            {
                return base.CalcVisaDate(ReleaseYear);
            }
        }
    }
}
