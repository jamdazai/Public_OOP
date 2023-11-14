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
                if (customer.customerFirstName == firstName &&
                    customer.customerLastName == lastName && 
                    customer.customerPhone == phone)
                {
                    return true;
                }
            }
            return false;
        }


        public bool AddCustomer(string firstName, string lastName, string phone, int bookings, int customerAge)
        {

            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("\nEnter Last Name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("\nEnter Phone Number: ");
            phone = Console.ReadLine();

            // Check if customer already exists with the same first name, last name, and phone
            if (CustomerExists(firstName, lastName, phone))
            {
                Console.WriteLine("Customer already exists. Cannot duplicate records!");
                return false; // Customer addition failed
            }
            else
            {
                // Check if the array is not full before adding a new customer
                if (numCustomer < maxCustomer)
                {
                    // Choose the appropriate customer type based on age
                    Customers newCustomer;
                    int customerID = GenerateCustomerID();
                    if (customerAge >= 60)
                    {
                        newCustomer = new SeniorCitizen(firstName, lastName, phone, bookings, customerAge);
                    }
                    else if (customerAge >= 18)
                    {
                        newCustomer = new Adult(firstName, lastName, phone, bookings, customerAge);
                    }
                    else if (customerAge >= 5)
                    {
                        newCustomer = new Child(firstName, lastName, phone, bookings, customerAge);
                    }
                    else
                    {
                        newCustomer = new Infant(firstName, lastName, phone, bookings, customerAge);
                    }

                    // Add the new customer to the array
                    customerList[numCustomer] = newCustomer;

                    // Increment the customer count
                    numCustomer++;

                    Console.WriteLine("Customer was successfully added!");
                    return true; // Customer addition succeeded
                }
                else
                {
                    // Inform the user that the list is full.
                    Console.WriteLine("Customer list is full. Cannot add more customers.");
                    return false; // Customer addition failed
                }
            }
        }


        private int GenerateCustomerID()
        {
            return numCustomer + 1 ;
        }

        public string ViewCustomers()
        {
            string s = "\n* LIST OF ALL CUSTOMERS *";
            for(int i = 0; i < numCustomer; i++)
            {
                s = s +"\n" + customerList[i].ToString();
                s = s + "\n";
            }return s;
        }
    }
}
