# PatikaLibrary

The `PatikaLibrary` project is a simple library management system implemented in C#. It allows users to manage books, authors, and related information.

## Class Overview

### Book Class

The `Book` class represents a book in the library. It includes properties such as:

- `Id`: Unique identifier for the book.
- `Name`: Title of the book.
- `AuthorId`: Identifier for the author of the book.
- `PageCount`: Number of pages in the book.
- `CategoryId`: Identifier for the category of the book.
- `IsActive`: Status indicating if the book is active in the library.
- `CreateDate`: Date when the book was added to the library.

```csharp
public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AuthorId { get; set; }
    public int PageCount { get; set; }
    public int CategoryId { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreateDate { get; set; }
}
