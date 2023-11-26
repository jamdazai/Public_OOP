using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_practice_1
{
    internal class FlightManager
    {
        protected int numFlights;
        protected int maxFlights;
        protected Flight[] flightList;

        public FlightManager (int max)
        {
            this.numFlights = 0;
            this.maxFlights = max;
            flightList = new Flight[max];
        }

        public int GenerateFlightID()
        {
            return 2000 + numFlights + 1;
        }

        public void AddFlight(string origin, string destination)
        {
            int newFlightID = GenerateUniqueFlightID();

            if (numFlights < maxFlights)
            {
                flightList[numFlights] = new Flight(newFlightID, origin, destination);
                numFlights++;
                Console.WriteLine("Flight added successfully.");
            }
            else
            {
                Console.WriteLine("Flight list is full. Cannot add more flights.");
            }
        }

        public int GenerateUniqueFlightID()
        {
            int newFlightID;
            do
            {
                newFlightID = GenerateFlightID();
            } while (FlightIDExists(newFlightID));

            return newFlightID;
        }

        public bool FlightIDExists(int flightID)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].flightID == flightID)
                {
                    return true; // Flight with the same ID already exists
                }
            }
            return false; // Flight with the given ID does not exist
        }

        public string ViewFlights()
        {
            if (numFlights == 0)
            {
                return "No flights available.";
            }
            string s = " === * LIST OF ALL FLIGHTS * === ";
            for (int i = 0; i < numFlights; i++)
            {
                s = s + "\n" + flightList[i].ToString();
                s = s + "\n";
            }
            return s;
        }

        public bool DeleteFlight(int flightID)
        {
            int flightIndex = -1;

            // Find the index of the flight with the specified ID
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].flightID == flightID)
                {
                    flightIndex = i;
                    break;
                }
            }

            // Check if the flight was found
            if (flightIndex == -1)
            {
                Console.WriteLine("Flight not found. Please provide a valid flight ID.");
                return false;
            }
            numFlights--;
            Console.WriteLine("Flight successfully deleted.");
            return true;
        }
        

        public string ViewParticularFlight(int flightID)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].flightID == flightID)
                {
                    return $"Flight Details:\n{flightList[i]}\n";
                }
            }
            return "Flight not found.";
        }
    }
}
