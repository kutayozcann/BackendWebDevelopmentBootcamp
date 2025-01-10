// Creating and Adding guests to list
List<string> guests = new List<string>()
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};

// Display Guests List
Console.WriteLine("** Guest List **");
foreach (var person in guests)
{
    Console.Write(guests.IndexOf(person) + 1 + " - ");
    Console.WriteLine(person);
}