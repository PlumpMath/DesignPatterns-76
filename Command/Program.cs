using Command.Commands;
using Command.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    /*
    * Command Pattern
    * 
    * Definition: Encapsulate a request as an object, thereby letting you parameterize 
    * clients with different requests, queue or log requests, and support undoable operations.
    */

    /// <summary>
    /// This program uses also Factory and NullObject patterns. Note: Invoker and receiver are omitted.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CommandFactory factory = new CommandFactory();

            ICommand command = factory.MakeCommand("CreateOrder");
            command.Execute();

            command = factory.MakeCommand("UpdateOrder");
            command.Execute();

            command = factory.MakeCommand("Diipadaa");
            command.Execute();

            Console.ReadLine();
        }
    }
}
