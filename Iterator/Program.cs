using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        /*
         * Iterator Pattern
         * 
         * Definition: Provide a way to access the elements of an aggregate object 
         * sequentially without exposing its underlying representation.
         */
        static void Main(string[] args)
        {
            ConcreteAggregate.ConcreteAggregate a = new ConcreteAggregate.ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate 
            ConcreteIterator.ConcreteIterator i = new ConcreteIterator.ConcreteIterator(a);

            Console.WriteLine("Iterating over collection:");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadLine();
        }
    }
}
