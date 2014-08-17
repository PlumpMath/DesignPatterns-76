using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public interface IAirControl
    {
        void RegisterAircraftUnderGuidance(Aircraft airCraft);
        void ReceiveAircraftAltitude(Aircraft airCraft);
    }
}
