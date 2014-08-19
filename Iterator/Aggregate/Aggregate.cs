using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Aggregate
{
    abstract class Aggregate
    {
        public abstract Iterator.Iterator CreateIterator();
    }
}
