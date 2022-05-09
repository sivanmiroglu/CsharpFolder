using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.BlogSample
{
    public class BlogPost : BlogBaseModel
    {
        //Blog yazısı başlığındaki kelimeler her zaman büyük harf olmak zorunda.

        private string title = "";
        public string Title
        { get
            {
                return BlogHelper.TitleCapitalize(title);
            }
            set
            {
                title = value;
            }
        }
        public string Content { get; set; }

        public DateTime AddDate { get; set; } = DateTime.Now;

        public BlogCategory BlogCategory { get; set; }
    }
}
