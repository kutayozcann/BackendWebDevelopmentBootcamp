using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create baby1 with default constructor 
            Baby baby1 = new Baby();
            baby1._name = "Kutay";
            baby1._surname = "Özcan";
            
            // Create baby2 with name and surname
            Baby baby2 = new Baby("Rüzgar","Özcan");
            
            // Show details of both babies
            baby1.DisplayBabyInfo();
            baby2.DisplayBabyInfo();
            
        }
    }
}

