using System;

namespace TechStore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.WriteLine("Welcome to Tech Store!");
            
            // Variable to control the loop for creating product
            bool appRepeat;

            do
            {
                appRepeat = false;
                
                Console.WriteLine("Enter 1 to create a Phone \nEnter 2 to create a PC");
                Console.Write("Your Choice :");
                bool validChoice = int.TryParse(Console.ReadLine(), out int choice);
                
                // Validate user input for product type 
                while (!validChoice || choice < 1 || choice > 2)
                {
                    Console.WriteLine("Please enter a valid choice.");
                    Console.Write("Your Choice :");
                    validChoice = int.TryParse(Console.ReadLine(), out choice);
                }

                // Collect common product details
                Console.Write("Please enter a serial number: ");
                string serialNumber = Console.ReadLine();

                Console.Write("Please enter a name: ");
                string name = Console.ReadLine();

                Console.Write("Please enter a description: ");
                string description = Console.ReadLine();

                Console.Write("Please enter a operating system: ");
                string operatingSystem = Console.ReadLine();

                // Declare a variable to store the created product
                BaseMakine product;

                // Create a Phone object if user selects option 1
                if (choice == 1)
                {
                    Console.WriteLine("Does this phone have turkish license ?");
                    Console.WriteLine("Enter 'y' for yes or enter 'n' for no");
                    Console.Write("Licence choice: ");
                    bool isLicenced = false;
                    string? licence = Console.ReadLine();
                    if (licence == "y")
                    {
                        isLicenced = true;
                    }
                    
                    // Instantiate a Phone object with the provided details
                    product = new Phone()
                    {
                        SerialNumber = serialNumber,
                        Name = name,
                        Description = description,
                        OpSystem = operatingSystem,
                        isTrLicenced = isLicenced
                    };
                }
                // Create a PC object if user selects option 2
                else
                {
                    Console.WriteLine("Does this PC have bluetooth ?");
                    Console.WriteLine("Enter 'y' for yes or enter 'n' for no");
                    Console.Write("Bluetooth choice: ");
                    bool isBluetooth = false;
                    string? bluetooth = Console.ReadLine();
                    if (bluetooth == "y")
                    {
                        isBluetooth = true;
                    }
                    
                    // Ask for number of USB Ports
                    Console.WriteLine("How many Usb ports does this PC have ? (2 or 4)");
                    int usbPorts = Convert.ToInt32(Console.ReadLine());

                    // Instantiate a PC object with the provided details
                    product = new PC()
                    {
                        Name = name,
                        Description = description,
                        OpSystem = operatingSystem,
                        BluetoothEnabled = isBluetooth,
                        SerialNumber = serialNumber,
                        UsbPortNumber = usbPorts
                    };
                }
                
                // Display product name and details 
                product.GetProductName();
                product.Display();

                // Asking user for creating a new product
                Console.WriteLine("Do you want to create new product ?");
                Console.WriteLine("Enter 'y' for yes or enter 'n' for no");
                string? appRepeatChoice = Console.ReadLine();
                if (appRepeatChoice == "y")
                {
                    appRepeat = true;
                }
            } while (appRepeat); // Repeat process if user wants
    
            // Exit message
            Console.WriteLine("Have a nice day!");
            Console.WriteLine("Shut down Tech Store!");
        }
    }
}

