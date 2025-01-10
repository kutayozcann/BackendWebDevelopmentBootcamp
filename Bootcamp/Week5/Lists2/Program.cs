Console.WriteLine("Enter 5 different coffee type for cafe menu !");

List<string?> coffees = new List<string?>(); // Creating string list for menu

for (int i = 0; i < 5; i++)  // Getting coffee types from user
{
    Console.Write($"Coffee {i+1}: ");
    coffees.Add(Console.ReadLine());
}
Console.Clear();

Console.WriteLine("Coffee Menu: ");   // Displaying menu
foreach (var coffee in coffees)
{
    Console.WriteLine(coffee);
}