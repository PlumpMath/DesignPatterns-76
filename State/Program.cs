using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Risto Reipas");
            acc.Deposit(10000);
            acc.Withdraw(11000);
            acc.Withdraw(1000000);
            acc.Deposit(2000);

            Console.ReadLine();
        }
    }
}
