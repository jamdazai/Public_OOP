using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    internal abstract class Customers
    {
        public int customerID;
        public string customerFirstName;
        public string customerLastName;
        public string customerPhone;
        public int customerAge;

        public Customers(int customerID,string customerFirstName, string customerLastName, string customerPhone, int cAge)
        {
            this.customerID = customerID;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.customerPhone = customerPhone;
            this.customerAge = cAge;
        }



        public override string ToString()
        {
            string formattedID = customerID.ToString("D4");
            string s = "\nCustomer's ID: " + formattedID;
            s = s + "\nCustomer's Full name: " + customerFirstName + " " + customerLastName;
            s = s + "\nPhone #: " + customerPhone;
            //s = s + "\nBookings: " + bookings;
            return s;
        }
    }
}
