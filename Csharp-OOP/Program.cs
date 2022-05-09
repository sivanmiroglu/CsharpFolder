using System;
using Csharp_OOP.BlogSample;
using Csharp_OOP.HastaneOrnek;
using Csharp_OOP.Models;
using Csharp_OOP.BankSample;
using Csharp_OOP.Games;
using Csharp_OOP.GamesSample;
namespace Csharp_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 
            //WebUser webUser = new WebUser();


            //Console.WriteLine(webUser);
            //Console.Read();


            //Sovalye sovalye = new Sovalye("Abdullah");

            //Sovalye sovalye = new Sovalye();
            //sovalye.Hello();

            //Console.Read();

            //Batman batman = new Batman("Çağatay", "Erzurum");
            //Batman batman1 = new Batman();


            //Ninject ninject = new Ninject();
            //ninject.Hello();
            #endregion



            #region Models
            //Instance aldım!

            //Category category = new Category();
            //category.Id = 3;
            //category.Name = "Sport";
            //category.Description = "Sport products";

            //Supplier supplier = new Supplier();
            //supplier.Country = "iran";
            //supplier.CompanyName = "Siemens";
            //supplier.ContactName = "Alp";


            //Product product = new Product();
            //product.Name = "IPhone";
            //product.UnitPrice = 55;
            //product.Category = category; //boxing
            //product.Supplier = supplier; //boxing


            //Yukarıda instance alınan product ın categorysinin adını console a yazdır
            /* Console.WriteLine(product.Category.Name);*/ //unboxing

           /* Yukarıda instance alınan product ın suppler ının companyName console a yazdır*/
            /* Console.WriteLine(product.Supplier.CompanyName);*/ //unboxing

            //Console.WriteLine(product);
            //Console.ReadLine();
            #endregion


            #region News
            //News news = new News();

            //Console.Write(news.SubContent);
            #endregion


            #region HastaneOrnek
            // birer birer tanımladığımız nesneleri buradan çağırdık ve ekrana yazdırdık.
            // tanımladığımız nesneleri kullandık.
            //Poliklinik poliklinik=new Poliklinik("Ortopedi",2000);

            //Doktor doktor = new Doktor("Ali","Baran", poliklinik);

            //Hasta hasta = new Hasta();
            //hasta.Ad = "Mert";
            //hasta.Soyad = "Çetin";
            //hasta.DogumTarih = new DateTime(2022,1,1);
            //hasta.Tcno = "223344838392";

            //Islem islem = new Islem();
            //islem.Doktor = doktor;
            //islem.Hasta = hasta;
            //islem.IslemTarihi = DateTime.Now;
            //islem.Not = "Dizlerimde Ağrı Var";

            // bu islemin yapıldığı poliklink adı nedir
            //Console.WriteLine(islem.Doktor.Poliklinik.Ad);
            //// bu islemde doktorun adı nedir
            //Console.WriteLine(islem.Doktor.Ad);
            //// bu islem de hastanın adı nedir
            //Console.WriteLine(islem.Hasta.Ad);
            //// hastanın şikayeti
            //Console.WriteLine(islem.Not);

            //Console.WriteLine("Hasta Adı Soyadı :  " +islem.Hasta.Ad+islem.Hasta.Soyad);

            //Console.WriteLine("Hasta Tcno : " + islem.Hasta.Tcno);

            //Console.WriteLine("Hastanın Şikayeti : " + islem.Not);

            //Console.WriteLine("Başvurduğu Poliklinik  : " + islem.Doktor.Poliklinik.Ad);

            //Console.WriteLine("Muayene Eden Doktor : " + islem.Doktor.Ad + islem.Doktor.Soyad);


            #endregion


            #region BankAccountSample

            //BankAccount bankAccount = new BankAccount("Çağatay", 1000);


            //while (true)
            //{
            //    Console.WriteLine("Lütfen işlem tutarını giriniz.");
            //    decimal amount = Convert.ToDecimal(Console.ReadLine());

            //    Console.WriteLine("Lütfen işlem notunu giriniz");
            //    string note = Console.ReadLine();

            //    Console.WriteLine("İşleminiz para yatırma ise D çekme ise W tuşuna basıp entera basınız!");

            //    string operation = Console.ReadLine().ToLower();

            //    if (operation == "d")
            //    {
            //        bankAccount.MakeDeposit(amount, DateTime.Now, note);
            //    }
            //    else if (operation == "w")
            //    {
            //        bankAccount.MakeWithdrawal(amount, DateTime.Now, note);
            //    }
            //    else
            //    {
            //        break;
            //    }

            //    Console.WriteLine("İşlem sonrasın mevcut bakiyeniz: " + bankAccount.Balance);

            //}
            #endregion


        }
    }
}
