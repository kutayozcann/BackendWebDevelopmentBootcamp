# Polymorphism Example in C#

This project demonstrates the **Polymorphism** principle in C# using geometric shapes. It uses an abstract base class `BaseGeometrikSekil` and derived classes (`Kare`, `Dikdortgen`, and `Dikucgen`) to calculate the area of different shapes.

## Features
- **Abstract Base Class (BaseGeometrikSekil):**
  - Defines common properties (`Height` and `Width`).
  - Provides an abstract method `Area()` to be implemented by derived classes.
- **Derived Classes:**
  - `Kare`: Calculates the area of a square.
  - `Dikdortgen`: Calculates the area of a rectangle.
  - `Dikucgen`: Calculates the area of a right triangle.
- Demonstrates method overriding to implement specific behaviors for each shape.

## Class Structure

### **BaseGeometrikSekil (Abstract Base Class)**
```csharp
public abstract class BaseGeometrikSekil
{
    public int Height { get; set; }
    public int Width { get; set; }
    public abstract void Area();
}
```

### **Derived Classes**
#### **Kare (Square)**
```csharp
public class Kare : BaseGeometrikSekil
{
    public override void Area()
    {
        Console.WriteLine($"Area of Kare : {Height * Width}");
    }
}
```

#### **Dikdortgen (Rectangle)**
```csharp
public class Dikdortgen : BaseGeometrikSekil
{
    public override void Area()
    {
        Console.WriteLine($"Area of Dikdortgen : {Height * Width}");
    }
}
```

#### **Dikucgen (Right Triangle)**
```csharp
public class Dikucgen : BaseGeometrikSekil
{
    public override void Area()
    {
        Console.WriteLine($"Area of Dikucgen : {Height * Width / 2}");
    }
}
```

## Usage

### Example Code:
```csharp
Kare square = new Kare(){Height = 20, Width = 20};
square.Area();

Dikdortgen rectangle = new Dikdortgen(){Height = 20, Width = 40};
rectangle.Area();

Dikucgen rightTriangle = new Dikucgen(){Height = 20, Width = 30};
rightTriangle.Area();
```

### Expected Output:
```
Area of Kare : 400
Area of Dikdortgen : 800
Area of Dikucgen : 300
```
