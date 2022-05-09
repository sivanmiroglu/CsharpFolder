using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Vehicle
{
    public class Brand
    {
        public Brand(string name)
        {
            this.Name = name;
        }


        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
