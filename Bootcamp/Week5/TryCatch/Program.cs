
bool isValid = false;

// Repeat until valid input is entered 
while (!isValid)
{
    try
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Square of given number: " + (number * number));
        
        // Exit the loop
        isValid = true;
    }
    // Handle invalid input format
    catch (FormatException ex) 
    {
        Console.WriteLine("Invalid input format. Please try again.");
        Console.WriteLine("Exception message: " + ex.Message);
    }
    // Handle numbers that are too large or too small
    catch (OverflowException ex)
    {
        Console.WriteLine("Invalid number. Please try again.");
        Console.WriteLine("Exception message: " + ex.Message);
    }
}