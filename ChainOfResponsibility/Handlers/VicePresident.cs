using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Concrete Handler
    /// </summary>
    class VicePresident : Approver
    {
        public override Enums.ApprovalResponse ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 5000)
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
