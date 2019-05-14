using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Chiken : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Chiken says\t: Kukuruyuk");
        }
    }
}