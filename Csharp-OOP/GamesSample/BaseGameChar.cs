using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.GamesSample
{
    public class BaseGameChar
    {
        public BaseGameChar(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        protected string City { get; set; }

        public virtual void Hello()
        {
            Console.WriteLine("Hello!");
        }


        public virtual void Bye()
        {
            Console.WriteLine("By");
        }


        protected virtual double CalcPoint(double point)
        {
            double calcPoint = point * 1.18;

            return calcPoint;
        }
    }
}
