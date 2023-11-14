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
                    Console.WriteLine("4. Back to Main Menu");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            customersManager.AddCustomer();
                            break;
                        case 2:
                            customersManager.ViewCustomers();
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