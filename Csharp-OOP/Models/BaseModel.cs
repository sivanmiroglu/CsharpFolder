using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime AddDate { get; set; }



        protected virtual double CalcKDVPrice(double price)
        {
            return price * 1.18;
        }
    }
}
