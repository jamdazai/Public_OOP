using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    internal class Infant : Customers
    {
        protected int infantAge;

        public Infant(string firstName, string lastName, string phone, int bookings, int iAge)
            : base(firstName, lastName, phone, bookings, iAge)
        {
            this.infantAge = iAge;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s = s + "\nAge: " + infantAge;
            s = s + "\nType: Infant";
            return s;
        }
    }
}
