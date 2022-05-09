using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP.Games
{
    public class Ninject : GameCharacter
    {
        public string KindOfSword { get; set; }

        public override void Hello()
        {
            Console.WriteLine("Hello! I am a Ninject!! Bir problem mi var");
        }
    }
}
