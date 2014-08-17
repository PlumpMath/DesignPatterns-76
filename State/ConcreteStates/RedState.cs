using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State.ConcreteStates
{
    public class RedState : AccountState
    {
        public RedState(AccountState state)
        {
            Balance = state.Balance;
            Account = state.Account;

            upperLimit = 5000.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("Can't withdraw! Account already below zero!");
        }

        public override void StateChangeCheck()
        {
            if (Balance > upperLimit)
                Account.State = new GoldState(this);
            else if (Balance > 0)
                Account.State = new GreenState(this);
        }

        public override string Name
        {
            get { return "Red"; }
        }
    }
}
