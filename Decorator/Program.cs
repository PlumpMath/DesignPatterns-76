using Decorator.Component;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    /*
    * Decorator Pattern
    * 
    * Definition: Attach additional responsibilities to an object dynamically. 
    * Decorators provide a flexible alternative to subclassing for extending functionality.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Mecha heavy = new HeavyMecha();
            heavy = new AutoCannon(heavy);
            heavy = new HeavyLaser(heavy);

            Console.WriteLine("{0} {1} cr", heavy.GetDescription(), heavy.CalculateCost());

            Console.ReadLine();
        }
    }
}
