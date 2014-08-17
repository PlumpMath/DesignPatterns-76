using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Handler
    /// </summary>
    public abstract class Approver
    {
        protected Approver _successor;

        public virtual void SetSuccessor(Approver successor)
        {
            _successor = successor;
        }

        /// <summary>
        /// HandleRequest
        /// </summary>
        public abstract Enums.ApprovalResponse ProcessRequest(Purchase purchase);
    }
}
