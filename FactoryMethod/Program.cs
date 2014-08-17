using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FactoryMethod
{
    /*
    * Factory Method Pattern
    * 
    * Definition: Define an interface for creating an object, but let subclasses decide which class to instantiate. 
    * Factory Method lets a class defer instantiation to subclasses.
    */

    /// <summary>
    /// Note: Uses settings file for factory
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory autoFactory = LoadFactory();

            IAuto car = autoFactory.CreateAuto();

            car.TurnOn();
            car.TurnOff();

            Console.ReadLine();

        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;

            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
