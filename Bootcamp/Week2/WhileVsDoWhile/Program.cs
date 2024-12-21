using System;

namespace WhileVsDoWhile{

    class Program{

        static void Main(string[] args){

            int counter = 0;
            System.Console.Write("While döngüsü için limit değerini giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            while(counter <= limit){
                System.Console.WriteLine("Ben bir Patika'lıyım :" + counter);
                counter++;
            }

            System.Console.Write("Do-While döngüsü için limit değerini giriniz: ");
            limit = Convert.ToInt32(Console.ReadLine());
            counter = 0;
            do{
                System.Console.WriteLine("Ben bir Patika'lıyım :" + counter);
                counter++;
            }while(counter <= limit);

            //İlk input olan 10'da iki döngü de aynı aynı çıktıları sağladı.
            //İkinci inputta -5 olan limit değeri 0 olan sayaçtan küçük olduğundan
            //While döngüsünün giriş koşulu sağlamadı ama Do-While döngüsüne 1 kere 
            //kesin olarak giriş yapıp sonrasında koşul sağlanmadığı için döngü kırılmıştır.


        }
    }
}