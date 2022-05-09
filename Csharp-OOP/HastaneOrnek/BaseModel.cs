using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.HastaneOrnek
{
    public class BaseModel // Basemodel de yer alanlar diğer sınıflar tarafından miras alınarak kullanılır.
                           
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Ad { get; set; }
    }
}
