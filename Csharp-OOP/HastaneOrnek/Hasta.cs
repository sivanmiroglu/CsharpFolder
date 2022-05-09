using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.HastaneOrnek
{
    public class Hasta : BaseModel // BaseModel den miras aldık oradaki değerleri kullanabiliriz.
    {
        public string  Soyad { get; set; }

        public DateTime DogumTarih { get; set; }

        public string Tcno { get; set; }
            
    }
}
