using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregator.EventClasses
{
    public class OrderSaved
    {
        public Order Order { get; set; }
    }
}
