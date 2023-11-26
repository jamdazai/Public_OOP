using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_practice_1
{
    internal class Flight
    {
        public int flightID;
        public string flightOrigin;
        public string flightDestination;

        public Flight(int flightID, string origin, string destination)
        {
            this.flightID = flightID;
            this.flightOrigin = origin;
            this.flightDestination = destination;
        }

        public override string ToString()
        {
            string flightFormattedID = flightID.ToString("D4");
            string s = "\nFlightID: " + flightFormattedID;
            s = s + "\nOrigin: " + flightOrigin;
            s = s + "\nDestination: " + flightDestination;
            return s;
        }
    }
}
