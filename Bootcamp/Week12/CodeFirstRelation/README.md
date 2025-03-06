# PatikaSecondDb Project

This project demonstrates a simple Code-First approach with Entity Framework Core, focusing on defining relationships between entities.

### Database Configuration
This project uses a local SQL Server instance. Ensure that your connection string in `PatikaSecondDbContext.cs` matches your database setup:

```csharp
optionsBuilder.UseSqlServer(
    "Server=localhost,1433;Database=PatikaCodeFirstDb2;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
```


### Entity Relationship
- A `UserEntity` can have multiple `PostEntity` records.
- A `PostEntity` belongs to a single `UserEntity`.
- The relationship is defined using a foreign key (`UserId`).
