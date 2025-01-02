namespace OOP;

public class Person
{
    //Private fields to store personal details
    private string name;
    private string surname;
    private DateTime birthday;

    //Property to get or set the name
    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    //Property to get or set the surname
    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    //Property to get or set the birthday
    public DateTime Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    //Method to print person's details
    public void PrintPerson()
    {
        Console.WriteLine($"{name} {surname} isimli kişinin doğum tarihi : {birthday}");
    }
    

}