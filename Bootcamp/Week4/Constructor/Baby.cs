namespace Constructor;

public class Baby
{
    // Properties for baby
    public string _name { get; set; }
    public string _surname { get; set; }
    public DateTime _birthday { get; set; }

    // Default Constructor
    public Baby()
    {
        Console.WriteLine("Ingaaaa");
        _birthday = DateTime.Now;
    }

    // Constructor with name and surname
    public Baby(string name, string surname)
    {
        _name = name;
        _surname = surname;
        _birthday = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    // Display baby's details
    public void DisplayBabyInfo()
    {
        Console.WriteLine("Baby name: " + _name);
        Console.WriteLine("Baby surname: " + _surname);
        Console.WriteLine("Baby birthday: " + _birthday);
    }
}