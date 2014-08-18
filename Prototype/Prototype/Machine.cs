using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Prototype
{
    public abstract class Machine
    {
        public abstract Machine Clone();

        public abstract void DoAmazingStuff();

        public string Name { get; set; }
    }
}
