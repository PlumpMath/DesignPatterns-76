using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Subsystems
{
    public class Bank
    {
        public bool IsTroublesomeCustomer(Customer customer)
        {
            Console.WriteLine("Bank check for customer {0}", customer.Name);
            return false;
        }
    }
}
