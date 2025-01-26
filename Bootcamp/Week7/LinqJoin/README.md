# LINQ Join

This project demonstrates how to use LINQ `join` in C# to associate authors with their books based on a common key (`AuthorId`). It uses two lists: one for authors and one for books.

## How It Works

1. **Authors List**: Contains information about authors (e.g., ID and name).
2. **Books List**: Contains information about books (e.g., ID, title, and the author's ID).
3. **LINQ Query**: Matches each book with its author using the `AuthorId` field.
4. **Output**: Displays the author's name along with their book title.

## Output

When you run the code, you will see the following output:
```plaintext
Orhan Pamuk => Kar  
Orhan Pamuk => İstanbul  
Elif Şafak => 10 Minutes 38 Seconds in This Strange World  
Ahmet Ümit => Beyoğlu Rapsodisi  
