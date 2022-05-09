using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.BlogSample
{
    public class BlogComment : BlogBaseModel
    {
        public  BlogComment(string title,string content)
        {
            this.Title = title;
            this.Content = content;
        }

        public  BlogPost BlogPost { get; set; }

        public  User User { get; set; }

        public string Title { get; set; }

        public  string Content { get; set; }    
    }
}
