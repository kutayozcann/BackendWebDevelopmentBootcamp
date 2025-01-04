using System;

namespace Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Kare square = new Kare(){Height = 20, Width = 20}; // Creating Kare object with H=20, W=20
        square.Area(); // Display area of square
        
        Dikdortgen rectangle = new Dikdortgen(){Height = 20, Width = 40}; // Creating Dikdortgen object with H=20 W=40
        rectangle.Area(); // Display area of rectangle
        
        Dikucgen rightTriangle = new Dikucgen(){Height = 20, Width = 30}; // Creating Dikucgen object with H=20 W=30
        rightTriangle.Area(); // Display area of rightTriangle
        
    }
}

