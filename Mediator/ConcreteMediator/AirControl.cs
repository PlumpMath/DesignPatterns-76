using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class AirControl : IAirControl
    {
        private readonly List<Aircraft> aircrafts = new List<Aircraft>();
        
        public void RegisterAircraftUnderGuidance(Aircraft airCraft)
        {
            if (!aircrafts.Contains(airCraft))
                aircrafts.Add(airCraft);
        }

        public void ReceiveAircraftAltitude(Aircraft airCraft)
        {
            foreach (Aircraft air in aircrafts.Where(x => x != airCraft))
            {
                if (Math.Abs(air.Altitude - airCraft.Altitude) < 500)
                    airCraft.Climb(airCraft.Altitude + 1000);
            }
        }
    }
}
