# Dependency Injection #

## Description
This project demonstrates how to implement **Dependency Injection (DI)** using **Constructor Injection** in a C# **Console Application**. The example includes:

- **ITeacher (Interface):** Defines the contract for the `Teacher` class.
- **Teacher (Class):** Implements `ITeacher` and provides teacher information.
- **Classroom (Class):** Depends on `ITeacher` and uses **constructor injection** to receive a `Teacher` instance.
- **Program.cs:** Configures the **DI Container** using `Microsoft.Extensions.DependencyInjection`.

---

## Technologies Used
- C#
- .NET Core Console Application
- Dependency Injection (DI)
- `Microsoft.Extensions.DependencyInjection`

---


### 2. Run the project
```sh
dotnet run
```

### 3. Expected Output
```
Teacher: Kutay Özcan
```

---

## Code Example
### **ITeacher Interface**
```csharp
public interface ITeacher
{
    string GetInfo();
}
```

### **Teacher Class**
```csharp
public class Teacher : ITeacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetInfo()
    {
        return $"Teacher: {FirstName} {LastName}";
    }
}
```

### **Classroom Class (Using Dependency Injection)**
```csharp
public class Classroom
{
    private readonly ITeacher _teacher;

    public Classroom(ITeacher teacher) // Constructor Injection
    {
        _teacher = teacher;
    }

    public void GetTeacherInfo()
    {
        Console.WriteLine(_teacher.GetInfo());
    }
}
```

### **Program.cs (Dependency Injection Container)**
```csharp
using System;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<ITeacher, Teacher>(provider => new Teacher("Kutay", "Özcan"))
            .AddTransient<Classroom>()
            .BuildServiceProvider();

        var classroom = serviceProvider.GetService<Classroom>();
        classroom?.GetTeacherInfo();
    }
}
```

---

## Explanation
1. **Dependency Injection (DI)**: `Classroom` depends on `ITeacher`, and we inject a `Teacher` instance through the constructor.
2. **Service Collection**: We register dependencies using `AddTransient<>` in `Program.cs`.
3. **Service Resolution**: `serviceProvider.GetService<Classroom>()` retrieves a fully initialized instance.
