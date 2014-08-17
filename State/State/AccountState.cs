using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    /// <summary>
    /// Abstract state
    /// </summary>
    public abstract class AccountState
    {
        protected double lowerLimit;

        protected double upperLimit;

        public Account Account { get; set; }

        public double Balance { get; set; }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);

        public abstract void StateChangeCheck();

        public abstract string Name { get; }
    }
}

