using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_OOP.BlogSample;

namespace Csharp_OOP.NewsSample 
{
    public class AdminUser
    {
        string email = "";
        public string Email
        {
            get { return email.ToLower(); }
            set { email = value; }
        }
        string password = "";
        public string Password
        {
            get { return password.ToLower(); }
            set { password = BlogHelper.CreateMD5(value); }
        }
    }
}
