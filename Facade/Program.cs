using Facade.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    /*
    * Facade Pattern
    * 
    * Definition: Provide a unified interface to a set of interfaces in a subsystem. 
    * Façade defines a higher-level interface that makes the subsystem easier to use.
    */
    class Program
    {
        static void Main(string[] args)
        {

            MortgageApplication facade = new MortgageApplication();
            Customer customer = new Customer { Name = "Risto Reipas" };
            var amount = 10000;

            var isEligible = facade.IsEligible(customer, amount);

            Console.WriteLine("{0} applies for amount: {1}. Approved: {2}", customer.Name, amount, isEligible);

            Console.ReadLine();
        }
    }
}
