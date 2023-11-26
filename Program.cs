namespace Project_practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customersManager = new CustomerManager(200);
            FlightManager flightManager = new FlightManager(15);

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
                        // Implement Customers menu logic.
                        RunCustomerMenu(customersManager);
                        break;
                    case 2:
                        // Implement Flights menu logic.
                        RunFlightMenu(flightManager);
                        break;
                    case 3:
                        // Implement Bookings menu logic.
                        break;
                    case 4:
                        // Exit the program.
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

        static void RunFlightMenu(FlightManager flightManager)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("* == XYZ Airlines Limited == *\n");
                Console.WriteLine("FLIGHT MENU");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. Add Flight");
                Console.WriteLine("2. View Flights");
                Console.WriteLine("3. View Particular Flight");
                Console.WriteLine("4. Delete Flight");
                Console.WriteLine("5. Back to Main Menu\n");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                string origin, destination;

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter Origin: ");
                        origin = Console.ReadLine();

                        Console.WriteLine("\nEnter Destination: ");
                        destination = Console.ReadLine();

                        flightManager.AddFlight(origin, destination);
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(flightManager.ViewFlights());
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter Flight ID: ");
                        int flightID = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(flightManager.ViewParticularFlight(flightID));
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine(flightManager.ViewFlights());      // Let the user see the lists of the flights while deciding what to delete.
                            Console.WriteLine("\n\n****************");
                            Console.WriteLine("Enter Flight ID to delete: ");    // User must provide the Flight ID of the one they wants to delete.
                            int flightIDToDelete;

                                if (!int.TryParse(Console.ReadLine(), out flightIDToDelete))
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid Flight ID.");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    continue; // Restart the loop if the input is invalid
                                }

                                if (flightManager.DeleteFlight(flightIDToDelete))
                                {
                                    Console.WriteLine("Flight successfully deleted!");
                                    break;    // Exit the loop if the flight is successfully deleted
                                }

                                else
                                {
                                    Console.WriteLine("Do you wish to continue? (Y/N)");
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    Console.WriteLine();

                                    switch (key.KeyChar)
                                    {
                                        case 'Y':
                                        case 'y':
                                            // Continue the loop to get the proper flightID.
                                            break;
                                        case 'N':
                                        case 'n':
                                            // User chose not to continue.
                                            // Return to the Main Menu.
                                            Console.Clear();
                                            return;
                                        default:
                                            Console.WriteLine("Invalid input. Please enter Y/y or N/n.");
                                            Console.WriteLine("Press any key to continue.");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                        }
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        return; // Exit the flight menu and return to the main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}