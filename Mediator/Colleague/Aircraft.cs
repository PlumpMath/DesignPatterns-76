using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public abstract class Aircraft
    {
        private readonly IAirControl _airControl;
        private int _altitude;

        public string CallSign { get; private set; }

        public int Altitude
        {
            get
            {
                return _altitude;
            }
            set
            {
                Console.WriteLine("Aircraft {0} new altitude is {1}.", CallSign, value);
                _altitude = value;
                _airControl.ReceiveAircraftAltitude(this);
            }
        }

        protected Aircraft(string callSign, IAirControl airControl)
        {
            CallSign = callSign;
            _airControl = airControl;
            _airControl.RegisterAircraftUnderGuidance(this);
        }

        public void Climb(int newAltitude)
        {
            Console.WriteLine("Aircraft {0} sets altitude from {1} to {2}.", CallSign, Altitude, newAltitude);
            Altitude = newAltitude;            
        }
    }
}
