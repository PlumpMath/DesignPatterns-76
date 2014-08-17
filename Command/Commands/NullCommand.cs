using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Commands
{
    public class NullCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Can't execute NULL command!");
        }
    }
}
