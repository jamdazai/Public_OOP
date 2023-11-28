namespace Project_practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customersManager = new CustomerManager(200);
            FlightManager flightManager = new FlightManager(15,15);
            BookingManager bookingManager = new BookingManager(50);
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

                switch (mainChoice)                                                             // MAIN MENU CHOICES
                {
                    case 1:                                                                     // Customer's Menu logic.                      
                        RunCustomerMenu(customersManager);
                        break;
                    case 2:                                                                     // Flight's Menu logic.
                        RunFlightMenu(flightManager);
                        break;
                    case 3:                                                                     // Booking's Menu logic.
                        RunBookingMenu(bookingManager, flightManager, customersManager);
                        break;
                    case 4:                                                                     // Exit the Program.
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");                 // Inform the user that they're choosing invalid choice.
                        Console.WriteLine("\nPress any key to continue.");                      // Allow them to continue if they choose any key.
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static void RunCustomerMenu(CustomerManager customersManager)                   // CUSTOMERS MENU
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("* == XYZ Airlines Limited == *\n");
                Console.WriteLine("CUSTOMER'S MENU");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. Add Customer");                                   // Allows the user to add customer.
                Console.WriteLine("2. View Customers");                                 // Allows the user to view the list of customers.
                Console.WriteLine("3. Delete Customer");                                // Allows the user to delete a customer.
                Console.WriteLine("4. Back to Main Menu\n");                            // Allows the user to go back to Main Menu.

                Console.WriteLine("Enter your choice: ");                               // Ask the user for their choice.
                int choice = Convert.ToInt32(Console.ReadLine());
                string firstName, lastName, phone;
                int customerAge;

                switch (choice)
                {
                    case 1:                                                 // Start of Add Customer logic.
                        Console.Clear();
                        Console.WriteLine("Enter First Name: ");            // Ask the user to input a first name.
                        firstName = Console.ReadLine();                     // Pass the input to firstName.

                        Console.WriteLine("\nEnter Last Name: ");           // Ask the user to input a last name.
                        lastName = Console.ReadLine();                      // Pass the input to lastName.

                        Console.WriteLine("\nEnter Phone Number: ");        // Ask the user for phone number.
                        phone = Console.ReadLine();                         // Pass the input to phone.

                        Console.WriteLine("\nEnter age: ");                 // Ask the user fo age.
                        customerAge = Convert.ToInt32(Console.ReadLine());  // Pass the input to customerAge.

                        
                        if (customersManager.AddCustomer(firstName, lastName, phone, customerAge))     // If everything is good.
                        {                                                                              // inform the user that
                            Console.WriteLine("\nCustomer successfully added!");                       // the customer is successfully added
                        }
                        else                                                                           // If everything went bad 
                        {                                                                              // inform the user that 
                            Console.WriteLine("\nCustomer addition failed.");                          // adding a customer was unsuccessful.
                        }
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;                                              // End of Add Customer Logic
                    case 2:                                                  // Start of View Customers.
                        Console.Clear();
                        Console.WriteLine(customersManager.ViewCustomers()); // Call the method ViewCustomers
                        Console.WriteLine("\nPress any key to continue.");   // to give a list of all the customers.
                        Console.ReadKey();
                        Console.Clear();
                        break;                                               // End of View Customers.   
                    case 3:                                         // Start of Delete a customer.
                        Console.Clear();
                        Console.WriteLine("Enter First Name: ");    // Ask the user to enter first name
                        firstName = Console.ReadLine();             // of the customer that they want to delete.

                        Console.WriteLine("\nEnter Last Name: ");   // Ask the user to enter last name
                        lastName = Console.ReadLine();              // of the customer that they want to delete.

                        Console.WriteLine("\nEnter Phone Number: ");     // Ask the user to enter the phone number
                        phone = Console.ReadLine();                      // of the customer that they want to delete.

                        
                        if (customersManager.DeleteCustomer(firstName, lastName, phone))
                        {
                            Console.Clear();                                                // If the customer is removed,
                            Console.WriteLine("Customer successfully deleted!");            // inform the user.
                        }
                        else
                        {
                            Console.Clear();                                                // If the customer wasn't deleted,
                            Console.WriteLine("Customer removal failed or canceled.");     // inform the user.
                        }

                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;                                                              // End of Delete a Customer logic.                             
                    case 4:
                        Console.Clear();
                        return;                                                             // Exit the customer menu and return to the main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");             // Inform the user that they're entering wrong choice.
                        break;
                }
            }

        }

        static void RunFlightMenu(FlightManager flightManager)                         // FLIGHTS MENU
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("* == XYZ Airlines Limited == *\n");
                Console.WriteLine("FLIGHT MENU");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. Add Flight");                                    // Allows the user to add flight.
                Console.WriteLine("2. View Flights");                                  // Allows the user to view all the flights.
                Console.WriteLine("3. View Particular Flight");                        // Allows the user to view a particular flight.
                Console.WriteLine("4. Delete Flight");                                 // Allows the user to delete a flight.
                Console.WriteLine("5. Back to Main Menu\n");                           // Allows the user to go back to the MAIN MENU.

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                string origin, destination;
                int maxSeats;
               

                switch (choice)
                {
                    case 1:                                          // Start of the logic to Add Flight
                        Console.Clear();
                        Console.WriteLine("Enter Origin: ");                        // Ask the user for origin.
                        origin = Console.ReadLine();                                // Pass the input to our origin variable.

                        Console.WriteLine("\nEnter Destination: ");                 // Ask the user for destination
                        destination = Console.ReadLine();                           // Pass the input to our destination variable.

                        Console.WriteLine("\nEnter Max Seats: ");                   // Ask the user for the max seats.
                        maxSeats = Convert.ToInt32(Console.ReadLine());             // Pass the input to maxSeats and convert it to int.

                        flightManager.AddFlight(origin, destination, maxSeats);     // Add the flight to using our method AddFlight.
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;                                       // End of the Add Flight logic.           
                    case 2:                                                 // Start of logic to View Flights
                        Console.Clear();
                        Console.WriteLine(flightManager.ViewFlights());     // Call our method ViewFlights to list all the flights we have.
                        Console.WriteLine("\nPress any key to continue.");  // Allows the user to continue to the Flight Menu.
                        Console.ReadKey();
                        Console.Clear();
                        break;                                              // End of the View Flights logic.
                    case 3:                                                                   // Start of logic to View a Particular FLight
                        Console.Clear();
                        Console.WriteLine("Enter Flight ID: ");                               // Ask the user for the FlightID
                        int flightID = Convert.ToInt32(Console.ReadLine());                   // Using the FlightID,
                        Console.WriteLine(flightManager.ViewParticularFlight(flightID));      // We're going to let the user to see the flight.
                        Console.WriteLine("\nPress any key to continue.");                    // Allow the user to continue by pressing any key.
                        Console.ReadKey();
                        Console.Clear();
                        break;                                                                // End of logic to View a Particular Flight
                    case 4:                                                                             // Start of logic to delete a flight.
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine(flightManager.ViewFlights());                             // Let the user see the lists of the flights while deciding what to delete.
                            Console.WriteLine("\n\n****************");
                            Console.WriteLine("Enter Flight ID to delete: ");                           // User must provide the Flight ID of the one they wants to delete.
                            int flightIDToDelete;

                            if (!int.TryParse(Console.ReadLine(), out flightIDToDelete))                // User must input a valid integer for the flight ID.
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Flight ID.");    // If the input is not a valid integer,
                                Console.WriteLine("Press any key to continue.");                        // Allow them to continue by pressing any key.
                                Console.ReadKey();
                                continue;                                                               // Restart the loop if the input is invalid
                            }

                            if (flightManager.DeleteFlight(flightIDToDelete))                           // Check if the flight with the specified ID was deleted.
                            {
                                break;                                                                  // Exit the loop if the flight is successfully deleted
                            }

                            else
                            {
                                Console.WriteLine("Do you wish to continue? (Y/N)");                  // Ask the user whether they want to continue.
                                ConsoleKeyInfo key = Console.ReadKey();
                                Console.WriteLine();

                                switch (key.KeyChar)
                                {
                                    case 'Y':
                                    case 'y':                                     
                                        break;                                                        // Continue the loop to get the proper flightID.
                                    case 'N':
                                    case 'n':                                                                           
                                        RunFlightMenu(flightManager);                                 // If the user doesn't want to continue, Return to the Flight Menu.
                                        return;
                                    default:                                      
                                        Console.WriteLine("Invalid input. Please enter Y/y or N/n."); // Message will prompt if the user chose neither of Y/N
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
                        Console.Clear();                                            // Exit the flight menu and return to the main menu
                        return;         
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");     // Inform the user that they're choosing an invalid option.
                        break;
                }
            }
        }
        static void RunBookingMenu(BookingManager bookingManager, FlightManager flightManager, CustomerManager customerManager)  // BOOKING MENU
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("* == XYZ Airlines Limited == *\n");
                Console.WriteLine("BOOKING MENU");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. Make Booking");                                              // Allows the user to create a booking.
                Console.WriteLine("2. View Bookings");                                             // Allows the user to view all the bookings.
                Console.WriteLine("3. Back to Main Menu\n");                                       // Allows the user to go back to the Main Menu.

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:                                                                        // Start of logic to Make a Booking.
                        Console.Clear();
                        if (bookingManager.MakeBooking(flightManager, customerManager))            // When we add Booking,
                        {                                                                          // There's a list of all Customers and Flights.          
                            Console.WriteLine("\nPress any key to continue.");                     
                        }
                        else
                        {
                            Console.WriteLine("\nBooking failed. Press any key to continue.");     // If something goes wrong, inform the user that the booking is failed.
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;                                                                     // End of the logic for Making a Booking.
                    case 2:                                                                        // Start of logic to View Bookings.
                        Console.Clear();
                        Console.WriteLine(bookingManager.ViewBookings());
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;                                                                    // End of the logic to View Bookings.
                    case 3:
                        Console.Clear();
                        return;                                                                   // Exit the booking menu and return to the main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}