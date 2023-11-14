using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    internal class CustomerManager
    {
        private int numCustomer;
        private int maxCustomer;
        private Customers[] customerList;

        public CustomerManager(int max)
        {
            this.numCustomer = 0;
            this.maxCustomer = max;
            customerList = new Customers[max];
        }


        private bool CustomerExists(string firstName, string lastName, string phone)
        {
            // Making sure if we already have existing firstname, lastname and phone for our customers.
            foreach (var customer in customerList)
            {
                if (customer != null &&
                    customer.customerFirstName == firstName &&
                    customer.customerLastName == lastName && 
                    customer.customerPhone == phone)
                {
                    return true;
                }
            }
            return false;
        }


        public bool AddCustomer(string firstName, string lastName, string phone, int customerAge)
        {
            // Check if customer already exists with the same first name, last name, and phone
            if (CustomerExists(firstName, lastName, phone))
            {
                Console.WriteLine("Customer already exists. Cannot duplicate records!");
                return false; // Customer addition failed
            }

            // Check if the customer list is already full.
            if (numCustomer >= maxCustomer)
            {
                Console.WriteLine("Customer list is full! Cannot add more customers.");
                return false;
            }


            Customers newCustomer;
            int customerID = GenerateCustomerID();
            if (customerAge >= 60)
            {
                newCustomer = new SeniorCitizen(customerID, firstName, lastName, phone, customerAge);
            }
            else if (customerAge >= 18)
            {
                newCustomer = new Adult(customerID, firstName, lastName, phone, customerAge);
            }
            else if (customerAge >= 5)
            {
                newCustomer = new Child(customerID, firstName, lastName, phone, customerAge);
            }
            else
            {
                newCustomer = new Infant(customerID, firstName, lastName, phone, customerAge);
            }
            customerList[numCustomer] = newCustomer; // Add the new customer to the array                   
            numCustomer++;                           // Increment the customer count
            Console.WriteLine("Customer was successfully added!");
            return true; // Customer addition succeeded

        }


        public int GenerateCustomerID()
        {
            return 1000 + numCustomer + 1;
        }

        public string ViewCustomers()
        {
            string s = " === * LIST OF ALL CUSTOMERS * === ";
            for(int i = 0; i < numCustomer; i++)
            {
                s = s +"\n" + customerList[i].ToString();
                s = s + "\n";
            }return s;
        }
    }
}
