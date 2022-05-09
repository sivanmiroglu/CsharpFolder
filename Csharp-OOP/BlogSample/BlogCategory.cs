using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.BlogSample
{
    public class BlogCategory : BlogBaseModel
    {
        public string Name { get; set; } = "Comolokko";

        public string Description { get; set; }
    }
}
