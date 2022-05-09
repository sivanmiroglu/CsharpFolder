using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Games
{
    public class Batman : GameCharacter
    {
        //Yapıcı, ayağa kaldırıcı metot!! Constructor metot
        public Batman()
        {

        }
        public Batman(string name, string city)
        {
            this.Name = name; // name gamecharacter tarafında tanımlandığı için burada tanıtmaya gerek kalmadan kullanabildik.
            this.City = city;
        }
        public string City { get; set; }

        public string Country { get; set; }


    }
}
