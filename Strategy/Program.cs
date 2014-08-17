using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Strategies;

namespace Strategy
{
    /*
    * Strategy Pattern
    * 
    * Definition: Define a family of algorithms, encapsulate each one, and make them interchangeable. 
    * Strategy lets the algorithm vary independently from clients that use it.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Roboto ropotti1 = new Roboto("Dalek");
            Roboto ropotti2 = new Roboto("Ruttunen");
            Roboto ropotti3 = new Roboto("Sähköhella-Ella");

            ropotti1.Strategy = new AggressiveStrategy();
            ropotti2.Strategy = new DefensiveStrategy();
            ropotti3.Strategy = new NormalStrategy();

            Console.WriteLine("{0} moves", ropotti1.Name);
            ropotti1.Move();
            Console.WriteLine("{0} moves", ropotti2.Name);
            ropotti2.Move();
            Console.WriteLine("{0} moves", ropotti3.Name);
            ropotti3.Move();

            Console.ReadLine();


            /*
            Wanha tapa tehdä asiat:
             
            Roboto ropotti = new Roboto("Dalek");
            
            if(ropotti.Name == "Dalek")
                Console.WriteLine("Exterminate");
            else if(ropotti.Name == "Ruttunen")
                Console.WriteLine("Olen ruttunen vain");
            */

        }
    }
}
