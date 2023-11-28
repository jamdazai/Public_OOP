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
        public int MaxSeats { get; set; } 
        public int PassengerCount { get; set; }

        public Flight(int flightID, string origin, string destination, int maxSeats)
        {
            this.flightID = flightID;
            this.flightOrigin = origin;
            this.flightDestination = destination;
            this.MaxSeats = maxSeats;
            this.PassengerCount = 0;                              // Initialize passenger count to 0
        }

        public override string ToString()                         // Method to show all the flight details thru string.
        {
            string flightFormattedID = flightID.ToString("D4");
            string s = "\nFlightID: " + flightFormattedID;
            s = s + "\nOrigin: " + flightOrigin;
            s = s + "\nDestination: " + flightDestination;
            s = s + "\nMax Seats: " + MaxSeats;
            s = s + "\nPassenger Count: " + PassengerCount;
            return s;
        }
    }
}
