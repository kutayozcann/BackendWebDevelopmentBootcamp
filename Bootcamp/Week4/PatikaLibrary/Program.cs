using System;

namespace PatikaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // New: Bir sınıfın yeni bir nesnesini oluşturmak için kullanılan anahtar kelime
            Book book = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
            book.DisplayBook();
            
            
            
        }
    }
}

