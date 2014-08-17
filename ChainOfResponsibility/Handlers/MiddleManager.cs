using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Concrete Handler
    /// </summary>
    public class MiddleManager : Approver
    {
        public override Enums.ApprovalResponse ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 1000)
            {
                return Enums.ApprovalResponse.Approved;
            }
            else
            {
                return _successor.ProcessRequest(purchase);
            }
        }
    }
}
