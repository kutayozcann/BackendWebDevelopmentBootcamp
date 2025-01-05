# Abstraction Example

This project demonstrates the **Abstraction** concept in C# programming. It includes an abstract class defining tasks for employees and derived classes implementing specific roles.

## Features
- **Abstract Class (Employee):**
  - Contains common properties (`Name`, `Surname`, `Department`).
  - Defines an abstract method `Task()`.
- **Derived Classes:**
  - `ProjectManager`: Defines tasks for a project manager.
  - `SoftwareDeveloper`: Defines tasks for a software developer.
  - `SalesManager`: Defines tasks for a sales manager.

## Usage

### Example Code:
```csharp
Employee pManager = new ProjectManager()
{
    Name = "Kutay",
    Surname = "Özcan",
    Department = "IT"
};
pManager.Task();
```

### Expected Output:
```
Kutay Özcan: Working as Project Manager at IT
```

