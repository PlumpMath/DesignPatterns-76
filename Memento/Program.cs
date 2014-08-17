using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    /*
    * Memento Pattern
    * 
    * Definition: Without violating encapsulation, capture and externalize an object's 
    * internal state so that the object can be restored to this state later
    */
    class Program
    {
        static void Main(string[] args)
        {
            var prospect = new SalesProspect
            {
                CustomerNumber = 1,
                Name = "Erno Perälä",
                Address = "<unknown>",
                CustomerType = "Lead"
            };

            Console.WriteLine("Start");
            Console.WriteLine("-----");
            Console.WriteLine("{0}", prospect.ToString());

            var careTaker = new CareTaker();
            careTaker.StoreState(prospect.SaveMemento());

            // change prospect data
            prospect.Address = "Ernolantie 6";
            careTaker.StoreState(prospect.SaveMemento());

            Console.WriteLine("After first change");
            Console.WriteLine("------------------");
            Console.WriteLine("{0}", prospect.ToString());

            // change prospect data again
            prospect.CustomerType = "Prospect";
            careTaker.StoreState(prospect.SaveMemento());

            Console.WriteLine("After second change");
            Console.WriteLine("------------");
            Console.WriteLine("{0}", prospect.ToString());


            // restore to previous state
            prospect.RestoreMemento(careTaker.GetMemento());

            Console.WriteLine("After first restore");
            Console.WriteLine("-------------------");
            Console.WriteLine("{0}", prospect.ToString());

            // restore to previous state
            prospect.RestoreMemento(careTaker.GetMemento());

            Console.WriteLine("After second restore");
            Console.WriteLine("-------------------");
            Console.WriteLine("{0}", prospect.ToString());

            Console.ReadLine();
        }
    }
}
