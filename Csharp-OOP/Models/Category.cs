using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Models
{
    //Category BaseModel den miras aldı. Böylelikle BaseModel de bulunan herşey category e geçti. Inheritance prensibi => OOP nin Inheritance
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
