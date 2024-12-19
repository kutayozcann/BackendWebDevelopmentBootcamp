using System;

namespace ForPractice{

    class Program{


        static void Main(string[] args){

            //Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırma
            for (int i = 0; i < 10; i++){
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

            //1-20 arasındaki sayıları konsola yazdırma
            for (int i = 1; i <= 20; i++){
                Console.WriteLine(i);
            }
            
            //1-20 arasındaki çift sayıları yazdırma
            for (int i = 1; i <= 20; i++){
                if (i % 2 == 0){
                    Console.WriteLine(i);
                }
            }

            //50 ile 150 arasındaki sayıların toplamını yazdırma
            int result = 0;
            for (int i = 50; i <= 150; i++){
                result += i;
                }
            Console.WriteLine(result);

            //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı yazdırma
            int odd = 0;
            int even = 0;
            for (int i = 1; i <= 120; i++){
                if (i % 2 == 0){
                    even += i;
                } else {
                    odd += i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı: " + odd);
            Console.WriteLine("Çift sayıların toplamı: " + even);

        }
    }

}