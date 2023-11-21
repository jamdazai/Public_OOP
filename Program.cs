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
                Console.WriteLine("* == XYZ Airlines Limited == *\n");
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Flights");
                Console.WriteLine("3. Bookings");
                Console.WriteLine("4. Exit\n");

                Console.WriteLine("Enter your choice: ");
                int mainChoice = Convert.ToInt32(Console.ReadLine());

                switch (mainChoice)
                {
                    case 1:
                        RunCustomerMenu(customersManager);
                        break;
                    case 2:
                        // Implement Flights menu logic
                        break;
                    case 3:
                        // Implement Bookings menu logic
                        break;
                    case 4:
                        // Exit the program
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static void RunCustomerMenu(CustomerManager customersManager)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("* == XYZ Airlines Limited == *\n");
                Console.WriteLine("CUSTOMER'S MENU");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customers");
                Console.WriteLine("3. Delete Customer");
                Console.WriteLine("4. Back to Main Menu\n");

                Console.WriteLine("Enter your choice: ");
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

                        if (customersManager.AddCustomer(firstName, lastName, phone, customerAge))
                        {
                            Console.WriteLine("\nCustomer successfully added!");
                        }
                        else
                        {
                            Console.WriteLine("\nCustomer addition failed.");
                        }

                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(customersManager.ViewCustomers());
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter First Name: ");
                        firstName = Console.ReadLine();

                        Console.WriteLine("\nEnter Last Name: ");
                        lastName = Console.ReadLine();

                        Console.WriteLine("\nEnter Phone Number: ");
                        phone = Console.ReadLine();

                        if (customersManager.DeleteCustomer(firstName, lastName, phone))
                        {
                            Console.Clear();
                            Console.WriteLine("Customer successfully deleted!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Customer deletion failed or canceled.");
                        }

                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        return; // Exit the customer menu and return to the main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}