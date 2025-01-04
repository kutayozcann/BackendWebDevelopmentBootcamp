# Inheritance Example in C#

This project demonstrates the **Inheritance** concept in C# using a simple example of a base class `BaseKisi` and two derived classes: `Ogrenci` (Student) and `Ogretmen` (Teacher).

## Features
- **Base Class (BaseKisi):**
  - Stores common properties (`Name`, `Surname`).
  - Provides a `Display()` method to show basic details.
- **Derived Class (Ogrenci):**
  - Inherits properties and methods from `BaseKisi`.
  - Adds a `StudentId` property.
  - Includes a `DisplayStudent()` method to show student details.
- **Derived Class (Ogretmen):**
  - Inherits properties and methods from `BaseKisi`.
  - Adds a `Salary` property.
  - Includes a `DisplayTeacher()` method to show teacher details.

## Class Structure

### **BaseKisi (Base Class)**
```csharp
public class BaseKisi
{
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public void Display()
    {
        Console.Write($"Ad: {Name}, Soyad: {Surname}, ");
    }
}
```

### **Ogrenci (Student - Derived Class)**
```csharp
public class Ogrenci : BaseKisi
{
    public string? StudentId { get; set; }
    public void DisplayStudent()
    {
        Display();
        Console.WriteLine($"Öğrenci Numarası: {StudentId}");
    }
}
```

### **Ogretmen (Teacher - Derived Class)**
```csharp
public class Ogretmen : BaseKisi
{
    public decimal Salary { get; set; }
    public void DisplayTeacher()
    {
        Display();
        Console.WriteLine($"Öğretmen Maaşı: {Salary} TL");
    }
}
```

## Usage

### Example Code:
```csharp
Ogrenci student = new Ogrenci()
{
    Name = "Kutay",
    Surname = "Özcan",
    StudentId = "123456"
};
student.DisplayStudent();

Ogretmen teacher = new Ogretmen()
{
    Name = "Sertan",
    Surname = "Bozkuş",
    Salary = 1000
};
teacher.DisplayTeacher();
```

### Expected Output:
```
Ad: Kutay, Soyad: Özcan, Öğrenci Numarası: 123456
Ad: Sertan, Soyad: Bozkuş, Öğretmen Maaşı: 1000 TL
```

