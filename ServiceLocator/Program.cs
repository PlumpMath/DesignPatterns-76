using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.AddService(new LoggingClass());

            LoggingClass log = ServiceLocator.GetService<LoggingClass>();

            Console.Write("Logitetaan dataa...");

            log.Log("Rivi 1");
            log.Log("Rivi 2");
            log.Log("Rivi 3");

            Console.WriteLine("OK");

            Console.ReadLine();
        }
    }
}

