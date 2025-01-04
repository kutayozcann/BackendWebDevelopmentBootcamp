using Inhertance;
namespace Inheritance;
public class Ogrenci : BaseKisi
{
    public string? StudentId { get; set; }
    public void DisplayStudent()
    {
        Display();
        Console.WriteLine($"Öğrenci Numarası: {StudentId} ");
    }
}