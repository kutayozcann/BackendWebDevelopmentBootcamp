using Inhertance;
namespace Inheritance;
public class Ogretmen : BaseKisi
{
    public decimal Salary { get; set; }
    public void DisplayTeacher()
    {
        Display();
        Console.WriteLine($"Öğrentmen Maas Bilgisi: {Salary} TL");
    }
}