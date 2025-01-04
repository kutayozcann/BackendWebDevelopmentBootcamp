# Polymorphism Example in C#

This project demonstrates **Polymorphism** in C# using geometric shapes. It calculates the area of different shapes using an abstract base class and derived classes.

## Features
- **Base Class (BaseGeometrikSekil):**
  - Defines common properties (`Height` and `Width`).
  - Provides an abstract method `Area()` to be implemented by subclasses.
- **Derived Classes:**
  - `Kare`: Calculates the area of a square.
  - `Dikdortgen`: Calculates the area of a rectangle.
  - `Dikucgen`: Calculates the area of a right triangle.

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

### Output:
```
Area of Kare : 400
Area of Dikdortgen : 800
Area of Dikucgen : 300
```

