using System;

namespace IfElse_SwitchCase{

    class IESC_Practice{

        static void Main(string[] args){

            Console.WriteLine("\nRuya Manavina Hos Geldiniz!");
            
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diger butun meyveler = 4 TL\n ");

            int elma = 2,
                armut = 3,
                cilek = 2,
                muz = 3,
                diger = 4;

            Console.Write("Hangi meyveyi satin almak istersiniz? ");
            Console.Write("(Elma/Armut/Çilek/Muz/Diger) :");

            string? fruit = Console.ReadLine().ToLower();

            //If-else yapısından daha az kod yazdığım için switch yapısını kullandım 

            switch(fruit){
                case "elma":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {elma} TL");
                    break;
                case "armut":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {armut} TL");
                    break;
                case "cilek":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {cilek} TL");
                    break;
                case "muz":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {muz} TL");
                    break;
                case "diger":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {diger} TL");
                    break;
                default:
                    Console.WriteLine("Lutfen gecerli bir meyve seciniz!");
                    break;
               }

                /*
               if(fruit == "elma"){
                Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {elma} TL");
               }
               else if(fruit == "armut"){
                Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {armut} TL");
               }
               else if(fruit == "cilek"){
                Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {cilek} TL");
               }
               else if(fruit == "muz"){
                Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {muz} TL");
               } 
               else if(fruit == "diger"){
                Console.WriteLine($"Seçtiğiniz meyvenin fiyati : {diger} TL");
               }
               else{
                Console.WriteLine("Lutfen gecerli bir meyve seciniz!");
               }
               */
        }

    }

}