using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Roboto
    {
        public string Name { get; set; }
        public IStrategy Strategy { get; set; }

        public Roboto(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Strategy.MoveCommand();
        }
    }
}
