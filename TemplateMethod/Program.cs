using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.AbstractClass;
using TemplateMethod.ConcreteClasses;

namespace TemplateMethod
{
    /*
    * Template Method Pattern
    * 
    * Definition: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. 
    * Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure
    */
    class Program
    {
        static void Main(string[] args)
        {
            InstantMessage plainTextMessage = new PlainTextMessage();
            InstantMessage videoMessage = new VideoMessage();

            plainTextMessage.ProcessMessage();
            videoMessage.ProcessMessage();

            Console.ReadLine();
        }
    }
}
