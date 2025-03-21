# JWT Authentication System

This project demonstrates how to implement a JWT (JSON Web Token) authentication system using .NET and Entity Framework Core.

## Features
- User authentication using JWT
- Secure API endpoints with token validation
- Entity Framework Core for database operations
- Role-based authentication (can be extended)

## Prerequisites
Ensure you have the following installed:
- .NET 6 or later
- SQL Server (or modify the connection string for other databases)
- Visual Studio or VS Code

## Installation

### 1. Clone the Repository
```sh
git clone https://github.com/your-repository/jwt-authentication.git
cd jwt-authentication
```

### 2. Install Dependencies
Run the following command to install required NuGet packages:
```sh
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package System.IdentityModel.Tokens.Jwt
```

### 3. Configure Database
Update `appsettings.json` with your database connection string:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=JwtAuthDb;Trusted_Connection=True;"
}
```
Run the migration and update the database:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the Application
```sh
dotnet run
```

## API Endpoints

### Authentication
**Login**
```http
POST /api/auth/login
```
**Request Body:**
```json
{
  "email": "test@example.com",
  "password": "123456"
}
```
**Response:**
```json
{
  "token": "your-jwt-token-here"
}
```

### Protected Endpoint (Requires Authorization)
```http
GET /api/protected/secure-data
```
**Headers:**
```
Authorization: Bearer your-jwt-token-here
```


