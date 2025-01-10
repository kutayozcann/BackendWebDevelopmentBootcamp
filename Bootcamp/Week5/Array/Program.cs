Random rnd = new Random();
// 1. Create an array with 10 elements
int[] array = new int[10];

// 2. Fill the array with for loop
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 100);
}

// Print the array with foreach loop
Console.Write("The random array is: ");
foreach (var i in array)
{
    Console.Write(i + " ");
}

Console.WriteLine();

// 3. Resize and add new number
Console.Write("Enter new number for array:");
int number = Convert.ToInt32(Console.ReadLine());

System.Array.Resize(ref array, 11);
array[array.Length - 1] = number;

// 4. Sort the array in descending order
System.Array.Sort(array);
System.Array.Reverse(array);

Console.Write("Sorted array is: ");
foreach (var i in array)
{
    Console.Write(i + " ");
}