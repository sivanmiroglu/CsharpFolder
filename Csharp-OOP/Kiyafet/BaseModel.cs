using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Kiyafet
{
    public class BaseModel
    {
        public string ID { get; set; }

        public DateTime Datetime { get; set; }

        public string Renk { get; set; }

        public int Fiyat { get; set; } = 0;

        public decimal KDVFiyat { get => (decimal)(Fiyat * 0.18); }
    }
}
