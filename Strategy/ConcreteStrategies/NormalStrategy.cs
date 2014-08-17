using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Strategies
{
    public class NormalStrategy : IStrategy
    {
        public void MoveCommand()
        {
            Console.WriteLine("If enemy is weaker we attack, otherwise defend.");
        }
    }
}
