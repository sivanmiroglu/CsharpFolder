using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.BankSample
{
    public class GiftCardAccount : BankAccount // İnheritance
    {
        public GiftCardAccount(string name, decimal initalBalance) : base(name, initalBalance)
        {

        }
    }
}
