using System.Numerics;

namespace Project_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
                CustomerManager customersManager = new CustomerManager(200);

                while (true)
                {
                    Console.WriteLine("Customer's Menu:");
                    Console.WriteLine("1. Add Customer");
                    Console.WriteLine("2. View Customers");
                    Console.WriteLine("3. Delete Customer");
                    Console.WriteLine("4. Back to Main Menu\n");

                    Console.WriteLine("Kindly, enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    string firstName, lastName, phone;
                    int customerAge;

                    switch (choice)
                    {
                        case 1:
                        Console.Clear();
                        Console.WriteLine("Enter First Name: ");
                        firstName = Console.ReadLine();

                        Console.WriteLine("\nEnter Last Name: ");
                        lastName = Console.ReadLine();

                        Console.WriteLine("\nEnter Phone Number: ");
                        phone = Console.ReadLine();

                        Console.WriteLine("\nEnter age: ");
                        customerAge = Convert.ToInt32(Console.ReadLine());

                        customersManager.AddCustomer(firstName, lastName, phone, customerAge);
                        Console.Clear();
                        break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine(customersManager.ViewCustomers());
                            break;
                        case 3:
                            // Implement delete customer logic
                            break;
                        case 4:
                            // Exit the loop or go back to the main menu
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    // Add logic to exit the loop or go back to the main menu based on user input
                }
            
        }
    }
}