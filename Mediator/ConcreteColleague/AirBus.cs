using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class AirBus : Aircraft
    {
        public AirBus(string callSign, IAirControl airControl) : base(callSign, airControl)
        {

        }
    }
}
