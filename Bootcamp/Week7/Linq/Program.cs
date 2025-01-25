var rnd = new Random();
var numbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    numbers.Add(rnd.Next(-30, 30));
}

Console.Write("Random created list: ");
PrintList(numbers);

// Finding even numbers
var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
Console.Write("Even numbers: ");
PrintList(evenNumbers);

//Finding odd numbers
var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
Console.Write("Odd numbers: ");
PrintList(oddNumbers);

//Finding negative numbers
var negativeNumbers = numbers.Where(x => x < 0).ToList();
Console.Write("Negative numbers: ");
PrintList(negativeNumbers);

//Finding positive numbers
var positiveNumbers = numbers.Where(x => x > 0).ToList();
Console.Write("Positive numbers: ");
PrintList(positiveNumbers);

//Finding numbers between 15 and 22
var betweenNumbers = new List<int>(numbers.Where(x => x is > 15 and < 22)).ToList();
Console.Write("Numbers between 15 and 22 : ");
PrintList(betweenNumbers);

//Square of every number in list
var squaredNumbers = new List<int>(numbers.Select(x => x * x)).ToList();
Console.Write("Squared numbers: ");
PrintList(squaredNumbers);
return;

void PrintList(List<int> list)
{
    if (list.Count != 0)
    {
        foreach (var num in list)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("No numbers");
    }
}