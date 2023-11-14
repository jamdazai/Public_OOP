using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    internal class Child : Customers
    {
        protected int childAge;

        public Child(string firstName, string lastName, string phone, int bookings, int chAge)
            : base(firstName, lastName, phone, bookings, chAge)
        {
            this.childAge = chAge;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s = s + "\nAge: " + childAge;
            s = s + "\nType: Child";
            return s;
        }
    }
}
