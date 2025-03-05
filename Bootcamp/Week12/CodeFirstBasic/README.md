# PatikaFirstDb Project

This project is a simple demonstration of the Code-First approach using Entity Framework Core.

## Technologies Used
- C#
- .NET Core
- Entity Framework Core
- Microsoft SQL Server

## Setup Instructions

### Prerequisites
Make sure you have the following installed:
- .NET SDK
- SQL Server
- Visual Studio or Rider IDE

### Database Configuration
This project uses a local SQL Server instance. Ensure that your connection string in `PatikaFirstDbContext.cs` matches your database configuration:

```csharp
optionsBuilder.UseSqlServer(
    "Server=localhost,1433;Database=PatikaFirstDb1;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
```

### Running Migrations
Run the following commands in the terminal to create the database and apply migrations:

```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Seeding Data
The `OnModelCreating` method seeds the database with initial data for `Movies` and `Games`. If you want to reset the database, you can remove it and run the migration update again.

### Running the Application
Execute the following command to run the application:

```sh
dotnet run
```

## Entities
### MovieEntity
- `Id` (int)
- `Title` (string)
- `Genre` (string)
- `ReleaseYear` (int)

### GameEntity
- `Id` (int)
- `Name` (string)
- `Platform` (string)
- `Rating` (int)

