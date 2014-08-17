using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State.ConcreteStates;

namespace State
{
    /// <summary>
    /// Context
    /// </summary>
    public class Account
    {
        private string _owner;       

        public Account(string owner)
        {
            _owner = owner;
            // set default state
            State = new GreenState(0.0, this);
        }

        public AccountState State { get; set; }

        public void Deposit(double amount)
        {
            Console.WriteLine("\nDeposited {0} cr", amount);
            State.Deposit(amount);
            Console.WriteLine("Balance is now: {0} cr", State.Balance);
            Console.WriteLine("Current account state is: {0}", State.Name);
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("\nWithdrawn {0} cr", amount);
            State.Withdraw(amount);
            Console.WriteLine("Balance is now: {0} cr", State.Balance);
            Console.WriteLine("Current account state is: {0}", State.Name);
        }

    }
}
