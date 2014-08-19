using Flyweight.ConcreteFlyweights;
using Flyweight.Factory;
using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    /*
    * Flyweight Pattern
    * 
    * Definition: Use sharing to support large numbers of fine-grained objects efficiently.
    */
    class Program
    {
        static void Main(string[] args)
        {
            StarFactory factory = new StarFactory();

            for (int i = 0; i < 20; i++)
            {
                IStar red = factory.GetStar("Red");
                Console.WriteLine("Red star created");

                IStar green = factory.GetStar("Green");
                Console.WriteLine("Green star created");
            }

            Console.WriteLine("RedStar objects created: {0}", RedStar.objectCount);
            Console.WriteLine("GreenStar objects created: {0}", GreenStar.objectCount);

            Console.ReadLine();
        }
    }
}
