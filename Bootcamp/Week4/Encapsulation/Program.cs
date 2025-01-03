using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Honda";
            car.Color = "Black";
            car.Model = "Civic";
            
            car.DoorNumber = 5;
            
            car.DisplayCarInfo();

            car.DoorNumber = 2;
            
            car.DisplayCarInfo();

        }
    }
}

