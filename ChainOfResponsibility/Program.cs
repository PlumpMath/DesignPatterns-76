using ChainOfResponsibility.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    /*
    * Chain Of Responsibility Pattern
    * 
    * Definition: Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. 
    * Chain the receiving objects and pass the request along the chain until an object handles it.
    */

    /// <summary>
    /// Simple expense approval program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Approver larry = new MiddleManager();
            Approver bob = new VicePresident();
            Approver joe = new President();
            Approver end = new EndOfChain();

            larry.SetSuccessor(bob);
            bob.SetSuccessor(joe);
            joe.SetSuccessor(end);

            Purchase purchase1 = new Purchase { Amount = 100, Number = 1, Purpose = "R&D (Rest&Darts)" };
            Purchase purchase2 = new Purchase { Amount = 5000, Number = 2, Purpose = "Moose hunting" };
            Purchase purchase3 = new Purchase { Amount = 1000000, Number = 3, Purpose = "Bribery" };

            Console.WriteLine("Response for {0}: {1}", purchase1.ToString(), larry.ProcessRequest(purchase1));
            Console.WriteLine("Response for {0}: {1}", purchase2.ToString(), larry.ProcessRequest(purchase2));
            Console.WriteLine("Response for {0}: {1}", purchase3.ToString(), larry.ProcessRequest(purchase3));

            Console.ReadLine();
        }
    }
}
