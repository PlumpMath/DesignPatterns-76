using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Strategies
{
    public class DefensiveStrategy : IStrategy
    {
        public void MoveCommand()
        {
            Console.WriteLine("Fall back, reinforce positions!");
        }
    }
}
