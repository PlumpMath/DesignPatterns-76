using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Subsystems
{
    public class Credit
    {
        public bool HasBadCredit(Customer customer)
        {
            Console.WriteLine("Credit check for customer {0}", customer.Name);
            return false;
        }
    }
}
