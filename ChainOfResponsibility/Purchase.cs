using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class Purchase
    {
        public int Number { get; set; }
        public Double Amount { get; set; }
        public string Purpose { get; set; }

        public override string ToString()
        {
            return "Number: " + Number + ", Amount: " + Amount + ", Purpose: " + Purpose;
        }
    }
}
