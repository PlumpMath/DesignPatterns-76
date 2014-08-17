using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Strategies
{
    public class NullStrategy : IStrategy
    {
        public void MoveCommand()
        {
            Console.WriteLine("NULL!");
        }
    }
}
