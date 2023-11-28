using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_practice_1
{
    internal class Booking
    {
        public string BookingDate { get; }
        public int BookingNumber { get; }
        public Flight BookedFlight { get; }
        public Customers BookedCustomer { get; }

        public Booking(int bookingNumber, Flight bookedFlight, Customers bookedCustomer)
        {
            BookingDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            BookingNumber = bookingNumber;
            BookedFlight = bookedFlight;
            BookedCustomer = bookedCustomer;
        }

        public override string ToString()                       // Method to make a booking details into a string
        {
            string s = $"\nBooking Number: {BookingNumber}";
            s += $"\nBooking Date: {BookingDate}\n\n";
            s += $"FLIGHT DETAILS: {BookedFlight}\n\n";
            s += $"CUSTOMER DETAILS: {BookedCustomer}\n";
            s += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*";
            return s;
        }
    }
}
