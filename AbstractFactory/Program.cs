using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AbstractFactory
{
    /*
    * Abstract Factory Pattern
    * 
    * Definition: Provide an interface for creating families of 
    * related or dependent objects without specifying their concrete classes
    */

    /// <summary>
    /// Note: Uses settings file for factory
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory = LoadFactory();
            IAuto car;

            car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine("----------------------------------");
            
            car = factory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine("----------------------------------");
                        
            car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine("----------------------------------");
                        
            Console.ReadLine();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;

            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
