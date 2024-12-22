using System;

namespace Method{
    class Program{

        static void Main(string[] args){

            Lyrics();

            System.Console.WriteLine(RandomDivision());

            int number = Multiply(32, 14);
            Console.WriteLine(number);

            string name = "Kutay", lastName = "Özcan";
            Greeter(name, lastName);


            // Geriye Değer Döndürmeyen Bir void metot.
            static void Lyrics(){       

                Console.WriteLine("But in the end, it doesn't even matter");
            }

            // Geriye Tamsayı Döndüren Bir metot
            static int RandomDivision(){    

                Random rand = new();
                int number = rand.Next();

                return number / 2;
            }

            // Parametre Alan ve Geriye Değer Döndüren Bir Metot
            static int Multiply(int x, int y){  
                return x * y;
            }


            // Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
            static void Greeter(string name, string lastName){      
                System.Console.WriteLine($"Hoş Geldiniz {name} {lastName}");
            }



        }
    }
}