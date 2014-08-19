using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.ConcreteAggregate
{
    class ConcreteAggregate : Aggregate.Aggregate
    {
        private ArrayList items = new ArrayList();

        public override Iterator.Iterator CreateIterator()
        {
            return new ConcreteIterator.ConcreteIterator(this);
        }

        // Property 
        public int Count
        {
            get { return items.Count; }
        }

        // Indexer 
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
