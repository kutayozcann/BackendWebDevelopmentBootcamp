namespace Inhertance;
public class BaseKisi
{
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public void Display()
    {
        Console.Write($"Ad: {Name}, Soyad: {Surname}, ");
    }
}