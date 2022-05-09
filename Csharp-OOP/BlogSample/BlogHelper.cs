using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;

namespace Csharp_OOP.BlogSample
{
    public class BlogHelper
    {
        public static string companyName = "SiemensBlog";

        //Aşağıdaki metot dışarıdan bir metin alır ve metin içerisinde bulunan tüm kelimelerin ilk harfini büyültüp diğer harflerini küçültecek şekilde metni return eder.

        public static string TitleCapitalize(string title)
        {
            TextInfo myTI = new CultureInfo("tr-TR", false).TextInfo;
            return myTI.ToTitleCase(title);
        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
