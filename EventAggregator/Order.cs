using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregator
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "Number: " + OrderNumber + ", Description: " + Description;
        }
    }
}
