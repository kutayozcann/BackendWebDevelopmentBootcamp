using System;

namespace IfElse{
    class Program{

        static void Main(string[] args){

            Console.Write("Lutfen bir sayi giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if(number > 10){
                Console.WriteLine("Girilen sayi 10'dan buyuktur.");
            }
            else if(number < 10){
                Console.WriteLine("Girilen sayi 10'dan kucuktur.");
            }
            else{
                Console.WriteLine("Girilen sayi 10'a esittir.");
            }

            if(number % 2 == 0){
                Console.WriteLine("Girilen sayi cifttir.");
            }
            else{
                Console.WriteLine("Girilen sayi tektir.");
            }
        }
    }
}