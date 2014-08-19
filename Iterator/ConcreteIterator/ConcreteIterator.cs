using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.ConcreteIterator
{
    class ConcreteIterator : Iterator.Iterator
    {
        private ConcreteAggregate.ConcreteAggregate aggregate;
        private int current = 0;

        // Constructor 
        public ConcreteIterator(ConcreteAggregate.ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (current < aggregate.Count - 1)
            {
                ret = aggregate[++current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }
    }
}
