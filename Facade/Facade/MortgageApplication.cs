using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Facade
{
    public class MortgageApplication
    {
        private Bank _bank = new Bank();
        private Credit _credit = new Credit();
        private Loan _loan = new Loan();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("Customer {0} applies for amount: {1}", customer.Name, amount);

            if(_bank.IsTroublesomeCustomer(customer) || _credit.HasBadCredit(customer) || _loan.HasBadLoans(customer))
                return false;
            else
                return true;
        }
    }
}
