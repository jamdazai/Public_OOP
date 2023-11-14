using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    internal class Customers
    {
        private string customerID;
        public string customerFirstName;
        public string customerLastName;
        public string customerPhone;
        protected int bookings;
        protected int customerAge;

        public Customers(string customerFirstName, string customerLastName, string customerPhone, int bookings, int cAge)
        {
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.customerPhone = customerPhone;
            this.bookings = bookings;
            this.customerAge = cAge;
        }


        public override string ToString()
        {
            string s = "\nCustomer's ID: " + customerID;
            s = s + "\nCustomer's Full name: " + customerFirstName + " " + customerLastName;
            s = s + "\nPhone #: " + customerPhone;
            s = s + "\nBookings: " + bookings;
            return s;
        }
    }
}
