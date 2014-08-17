using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class Boeing : Aircraft
    {
        public Boeing(string callSign, IAirControl airControl)
            : base(callSign, airControl)
        {

        }
    }
}
