using CarFabrication;

Console.WriteLine("Welcome to Car Fabrication App");

var appRepeater = true; // Keep the program running
var cars = new List<Car>(); // Stores created cars

while (appRepeater)
{
    Console.WriteLine("Do you want to create a car?");
    Console.Write("'Y' or 'N' :");
    var choice = Console.ReadLine()?.ToUpper();
    switch (choice)
    {
        case "Y": // If user wants to create a car
        {
            create: // Starts cat creation
            Console.Clear();
            Console.Write("Enter the serial number: ");
            var serialNumber = Console.ReadLine();
            Console.Write("Enter the brand: ");
            var brand = Console.ReadLine();
            Console.Write("Enter the model: ");
            var model = Console.ReadLine();
            Console.Write("Enter the color: ");
            var color = Console.ReadLine();
            int doorNumber;
            exception: // For handling invalid input 
            try
            {
                Console.Write("Enter the door number: ");
                doorNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Try again.");
                goto exception;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input was either too big or too small. Try again.");
                goto exception;
            }

            // Create a new car and set its details 
            var car = new Car()
            {
                SerialNumber = serialNumber,
                Brand = brand,
                Model = model,
                Color = color,
                DoorNumber = doorNumber
            };

            cars.Add(car); // Add the car to the list

            Console.WriteLine("Car created successfully.");
            Console.WriteLine("Do you want to create another car?");
            Console.Write("'Y' or 'N' :");
            choice = Console.ReadLine()?.ToUpper();
            if (choice == "Y") // Repeat car creation 
            {
                goto create;
            }

            if (choice == "N")
            {
                // Show all created cars 
                foreach (var item in cars)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Serial Number: " + item.SerialNumber);
                    Console.WriteLine("Brand: " + item.Brand);
                }

                Console.WriteLine("Shutting down...");
                appRepeater = false; // Exit the program 
            }
            else
            {
                Console.WriteLine("Invalid input.");
                goto case "N"; // Go to "No" Case
            }

            break;
        }
        case "N": // If user wants to exit 
            appRepeater = false;
            Console.WriteLine("Shutting down...");
            break;
        default: // Handle invalid input
            Console.WriteLine("Invalid input. Try again.");
            appRepeater = true;
            break;
    }
}