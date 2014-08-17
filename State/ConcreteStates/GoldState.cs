using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State.ConcreteStates
{
    public class GoldState : AccountState
    {
        
        public GoldState(AccountState state)
        {
            Balance = state.Balance;
            Account = state.Account;

            //upperLimit = 5000.0;
            lowerLimit = 5000.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            //StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        public override void StateChangeCheck()
        {
            if (Balance < 0)
                Account.State = new RedState(this);
            else if (Balance < upperLimit)
                Account.State = new GreenState(this);
        }

        public override string Name
        {
            get { return "Gold"; }
        }
    }
}
