using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State.ConcreteStates
{
    public class GreenState : AccountState
    {
        public GreenState(AccountState state)
        {
            Balance = state.Balance;
            Account = state.Account;

            upperLimit = 5000.0;
            lowerLimit = 0.0;
        }

        public GreenState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        public override void StateChangeCheck()
        {
            if (Balance < lowerLimit)
                Account.State = new RedState(this);
            else if (Balance > upperLimit)
                Account.State = new GoldState(this);
        }

        public override string Name
        {
            get { return "Green"; }
        }
    }
}
