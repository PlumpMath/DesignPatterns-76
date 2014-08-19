using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Subsystems
{
    public class Loan
    {
        public bool HasBadLoans(Customer customer)
        {
            Console.WriteLine("Loan check for customer {0}", customer.Name);
            return false;
        }
    }
}
