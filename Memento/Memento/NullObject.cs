using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class NullObject : IMemento
    {
        public object State
        {
            get
            {
                throw new Exception("Can't get null object's State");
            }
            set
            {
                throw new Exception("Can't set null object's State");
            }
        }
    }
}
