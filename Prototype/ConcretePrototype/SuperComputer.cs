using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.ConcretePrototype
{
    public class SuperComputer : Machine
    {
        public override Machine Clone()
        {
            return (Machine)this.MemberwiseClone();
        }

        public override void DoAmazingStuff()
        {
            Console.WriteLine("Calculating prime numbers for 1000 years...");
        }
    }
}
