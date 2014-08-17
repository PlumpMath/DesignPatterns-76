using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Memento : IMemento
    {
        public object State { get; set; }
    }
}
