using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.BankSample
{
    public class BankAccount
    {
        // İşlem Listesi 
        List<Transaction> transactions = new List<Transaction>();

        // Banka Hesap Numarası
        public string Number { get; } = Guid.NewGuid().ToString();

        // Hesap Sahibi
        public string Owner { get; set; }

        // Bakiye
        public decimal Balance {
            get
            {
                decimal balance = 0;

                foreach (var item in transactions)
                {
                    balance = balance + item.Amount;
                }

                return balance;
            }
        }
        public BankAccount(string name, decimal initalBalance)
        {
            this.Owner = name;

            MakeDeposit(initalBalance, DateTime.Now, "first deposit!");
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            Transaction depositTransaction = new Transaction(amount, date, note);
            transactions.Add(depositTransaction);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            Transaction withdrawalTransaction = new Transaction(-amount, date, note);
            transactions.Add(withdrawalTransaction);
        }

    }
}
