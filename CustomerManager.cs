using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_practice_1
{
    internal class CustomerManager
    {
        protected int numCustomer;
        protected int maxCustomer;
        protected Customers[] customerList;

        public CustomerManager(int max)
        {
            this.numCustomer = 0;
            this.maxCustomer = max;
            customerList = new Customers[max];
        }

        // Method to identify if we already have an existing customer.
        public bool CustomerExists(string firstName, string lastName, string phone)
        {
            // Check if a customer with the same first name, last name, and phone already exists
            for (int i = 0; i < numCustomer; i++)
            {
                if (customerList[i].customerFirstName == firstName &&
                    customerList[i].customerLastName == lastName &&
                    customerList[i].customerPhone == phone)
                {
                    return true;  // Customer exists.
                }
            }
            return false; // Customer does not exist.
        }


        // Method to add a customer.
        public bool AddCustomer(string firstName, string lastName, string phone, int customerAge)
        {
            // Check if customer already exists with the same first name, last name, and phone
            if (CustomerExists(firstName, lastName, phone))
            {
                Console.WriteLine("\nCustomer already exists. Cannot duplicate records!");
                return false;       // Customer addition failed
            }

            // Check if the customer list is already full.
            if (numCustomer >= maxCustomer)
            {
                Console.WriteLine("Customer list is full! Cannot add more customers.");
                return false;
            }

            // Determine what kind of customer are we registering.
            // We have division for infant, child, adult or senior citizen.
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
            return true; // Customer addition succeeded
        }


        // Method to allow us generate unique ID for customers.
        // Preferably customer IDs starts with 1000
        public int GenerateCustomerID()
        {
            return 1000 + numCustomer + 1;
        }

        // Method for us to delete a customer.
        public bool DeleteCustomer(string firstName, string lastName, string phone)
        {
            // Check if a customer with the specified details exists.
            bool customerExists = CustomerExists(firstName, lastName, phone);

            // If customer is existing, proceed to deletion process.
            if (customerExists)
            {
                // Customer found, prompt for confirmation.
                Console.WriteLine($"\n\nExisting record for this customer has found: {GetCustomerInfo(firstName, lastName, phone)}\n");
                Console.Write("Are you sure you want to delete this record? (Y/N): ");
                char confirmation = Console.ReadKey().KeyChar;

                if (confirmation == 'Y' || confirmation == 'y')
                {

                    // Find the index of the customer and shift remaining elements.
                    int index = -1;
                    for (int i = 0; i < numCustomer; i++)
                    {
                        if (customerList[i].customerFirstName == firstName &&
                            customerList[i].customerLastName == lastName &&
                            customerList[i].customerPhone == phone)
                        {
                            index = i; // Customer found, set the index.
                            break;
                        }
                    }

                    if (index != -1)
                    {
                        for (int i = index; i < numCustomer - 1; i++)
                        {
                            customerList[i] = customerList[i + 1];
                        }
                        numCustomer--; // Decrease the customer count in our table.
                        return true;   // Customer deletion succeeded.
                    }
                    else
                    {
                        Console.WriteLine("Error: customer doesn't exists.");
                        return false; // Customer deletion failed.
                    }
                }
                else if (confirmation == 'N' || confirmation == 'n')
                {
                    // User canceled deletion
                    Console.WriteLine("\nCustomer Deletion CANCELLED!");
                    return false; // Customer deletion canceled.
                }
                else
                {
                    // Invalid input
                    Console.WriteLine("\nInvalid input. Returning to Customer's Menu.");
                    return false; // Customer deletion canceled.
                }
            }
            else
            {
                // Customer not found
                Console.WriteLine("\nCustomer not found. Deletion canceled.");
                return false; // Customer not found, deletion canceled.
            }
        }

        // Method to allow us to identify if there's a record for our customer.
        // We are using this as connection to deleting a customer.
        private string GetCustomerInfo(string firstName, string lastName, string phone)
        {
            // Get customer information as a string
            for (int i = 0; i < numCustomer; i++)
            {
                if (customerList[i].customerFirstName == firstName &&
                    customerList[i].customerLastName == lastName &&
                    customerList[i].customerPhone == phone)
                {
                    return customerList[i].ToString(); // Return customer information
                }
            }
            return "Customer not found";
        }

        // Method to view all existing customers in our record.
        public string ViewCustomers()
        {
            string s = " === * LIST OF ALL CUSTOMERS * === ";
            for (int i = 0; i < numCustomer; i++)
            {
                s = s + "\n" + customerList[i].ToString();
                s = s + "\n";
            }
            return s;
        }
    }
}
