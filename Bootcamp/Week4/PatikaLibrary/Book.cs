namespace PatikaLibrary;

// Class: Nesne oluşturmak için şablon
public class Book
{
   
    //Property: Bir sınıfın özelliklerinin tanımlamak için kullanılır. "get()" ve "sen()" metotları içerir
    public string? BookName { get; set; }
    public string? AuthorName { get; set; }
    public string? AuthorSurname {get; set;}
    public int NumberOfPages {get; set;}
    public string? Publisher {get; set;}
    public DateOnly? RegistrationDate {get; set;}
    
    // Constructor: Sınıfın nesnesini oluştururken kulladığımız özel bir metot
    public Book()
    {
        RegistrationDate = DateOnly.FromDateTime(DateTime.Now);
    }

    public Book(string bookName, string authorName, string authorSurname, int numberOfPages, string publisher)
    {
        BookName = bookName;
        AuthorName = authorName;
        AuthorSurname = authorSurname;
        NumberOfPages = numberOfPages;
        Publisher = publisher;
        RegistrationDate = DateOnly.FromDateTime(DateTime.Now);
    }

    public void DisplayBook()
    {
        Console.WriteLine($"Book Name: {BookName}");
        Console.WriteLine($"Author: {AuthorName}");
        Console.WriteLine($"Author Surname: {AuthorSurname}");
        Console.WriteLine($"Number of pages: {NumberOfPages}");
        Console.WriteLine($"Publisher: {Publisher}");
        Console.WriteLine($"Registration Date: {RegistrationDate}");
    }
}
