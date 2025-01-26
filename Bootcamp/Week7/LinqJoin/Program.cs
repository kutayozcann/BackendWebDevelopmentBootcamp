using LinqJoin;

// List of authors
var authors = new List<Author>()
{
  new Author(){AuthorId = 1, Name = "Orhan Pamuk"},
  new Author(){AuthorId = 2, Name = "Elif Şafak"},
  new Author(){AuthorId = 3, Name = "Ahmet Ümit"}
};

// List of books
var books = new List<Book>()
{
  new Book(){BookId = 1, Title = "Kar", AuthorID = 1},
  new Book(){BookId = 2, Title = "İstanbul", AuthorID = 1},
  new Book(){BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorID = 2},
  new Book(){BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorID = 3}
};

// Join authors with their books based on AuthorId
var authorsBooks = from author in authors
                   join book in books
                   on author.AuthorId equals book.AuthorID
                   select new
                   {
                     AuthorName = author.Name,
                     BookName = book.Title
                   };

// Print the result
foreach (var item in authorsBooks)
{
  Console.WriteLine($"{item.AuthorName} => {item.BookName}");
}
