using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    /*
    * MediatorPattern
    * 
    * Definition: Define an object that encapsulates how a set of objects interact. 
    * Mediator promotes loose coupling by keeping objects from referring to each 
    * other explicitly, and it lets you vary their interaction independently.
    */
    class Program
    {
        static void Main(string[] args)
        {
            IAirControl airCommand = new AirControl();

            Aircraft boeing1 = new Boeing("BOING-1", airCommand);
            Aircraft boeing2 = new Boeing("BOING-2", airCommand);
            Aircraft airBus1 = new AirBus("AIR-1", airCommand);

            Console.WriteLine("BOING-1 takes off");
            Console.WriteLine("BOING-2 takes off");
            Console.WriteLine("AIR-1 takes off");

            
            boeing1.Altitude = 1000;
            boeing2.Altitude = 1200;
            airBus1.Altitude = 2200;

            Console.ReadLine();
        }
    }
}

