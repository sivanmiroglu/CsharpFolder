using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.BankSample
{
    public class Transaction
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Notes { get; set; }


        //Constructor üzerinden property leri SET ETMEK
        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }
    }
}
