using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Emlak
{
    public class Emlak
    {
        protected Emlak(string lokasyon)
        {
            Lokasyon = lokasyon ; // Constractor  almak. Emlak sınıfımda lokasyon a contractor almak
        }

        public string Lokasyon { get; set; }
        public int Alan { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal KiraFiyat { get; set; }
        public decimal SatisVergi { get { return HesaplaSatis(SatisFiyati); } }
        public decimal KiraVergi { get { return HesaplaKira(KiraFiyat); } }

        public decimal HesaplaSatis(decimal satisfiyat) { return (satisfiyat * 0.012M); }

        public decimal HesaplaKira(decimal kirafiyat) { return (kirafiyat * 0.05M); }

    }
}
