using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public class EndOfChain : Approver
    {
        public override Enums.ApprovalResponse ProcessRequest(Purchase purchase)
        {
            Console.WriteLine("WAY too big purchase to approve!! {0}", purchase.ToString());
            return Enums.ApprovalResponse.Denied;
        }

        public override void SetSuccessor(Approver successor)
        {
            throw new Exception("Can't set successor for the end-of-chain");
        }
    }
}
