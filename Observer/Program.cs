using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /*
    * Observer Pattern
    * 
    * Definition: Define a one-to-many dependency between objects so that when one object changes state, 
    * all its dependents are notified and updated automatically.
    */
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker subject = new StockTicker();

            GoogleObserver gobs = new GoogleObserver(subject);
            MicrosoftObserver mobs = new MicrosoftObserver(subject);
            NokiaObserver nobs = new NokiaObserver(subject);

            foreach (var s in SampleData.getNext())
                subject.Stock = s;

            Console.ReadLine();
        }
    }
}
