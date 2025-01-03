# Car Class - Encapsulation Example

This project demonstrates the **Encapsulation** principle using a simple C# application. It includes a `Car` class to manage the properties of a car object.

## Features
- **Brand:** Stores and manages the car's brand.
- **Model:** Stores and manages the car's model.
- **Color:** Stores and manages the car's color.
- **DoorNumber:** Supports 2 or 4-door vehicles and provides an error message for invalid inputs.

## Class Definition
**Car Class:**
- **Private Fields:** 
  - `_brand`, `_model`, `_color`, and `_doorNumber` are defined as private fields.
- **Properties:**
  - Properties (Brand, Model, Color, DoorNumber) are defined with getters and setters to ensure encapsulation.
- **Constructor:**
  - A default constructor is defined.
- **Method:**
  - `DisplayCarInfo()` displays all car details.

## Usage

### Example Code:
```csharp
Car car = new Car();
car.Brand = "Honda";
car.Model = "Civic";
car.Color = "Black";
car.DoorNumber = 4;

car.DisplayCarInfo();
```

### Expected Output:
```
Car Info: Honda Civic Black 4
```


