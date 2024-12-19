using System;

namespace While{

    class Program{

        static void Main(string[] args){

            //Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!"
            int i = 0;
            while(i < 10){
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                i++;
            }
            Console.WriteLine("--------------------------");

            //1 ile 20 arasındaki sayıları konsola yazdırma
            int j = 1;
            while(j <= 20){
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("--------------------------");

            //1 ile 20 arasındaki çift sayıları konsola yazdırma
            int k = 1;
            while(k <= 20){
                if(k % 2 == 0){
                    Console.WriteLine(k);
                }
                k++;
            }
            Console.WriteLine("--------------------------");

            //50 ile 150 arasındaki sayıların toplamını ekrana yazdırma
            int l = 50;
            int result = 0;
            while(l <= 150){
                result += l;
                l++;
            }
            Console.WriteLine(result);
            Console.WriteLine("--------------------------");

            //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırma
            int m = 1;
            int odd = 0;
            int even = 0;
            while(m <= 120){
                if(m % 2 == 0){
                    even += m;
                }else{
                    odd += m;
                }
                m++;
            }
            Console.WriteLine("Tek sayıların toplamı: " + odd);
            Console.WriteLine("Çift sayıların toplamı: " + even);



            


        }

    }
}