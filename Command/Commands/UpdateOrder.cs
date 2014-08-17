using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Commands
{
    public class UpdateOrder : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Order updated");
        }
    }
}
