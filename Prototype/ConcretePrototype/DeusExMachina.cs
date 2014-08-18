using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.ConcretePrototype
{
    public class DeusExMachina : Machine
    {
        public override Machine Clone()
        {
            return (Machine)this.MemberwiseClone();
        }

        public override void DoAmazingStuff()
        {
            Console.WriteLine("Conquering the world and whole universe...");
        }
    }
}
