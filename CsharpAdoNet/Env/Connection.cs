using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdoNet.Env
{
    // kullanacığımız sql veri tabanın bağlantısını buraya yazdık.
    // kullanacağımız veri tabanı adresimiz ConnectionString olarak yazılacak
    public class Connection
    {
        public static string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=Northwind; Trusted_Connection = True "; // trusted connection güvenilir bağlantı !
    }
}
