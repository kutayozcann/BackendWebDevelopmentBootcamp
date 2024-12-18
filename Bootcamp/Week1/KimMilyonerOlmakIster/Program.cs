using System;

namespace KimMilyonerOlmakIster{

    class Program{

        static void Main(string[] args){

            int point = 0;
            char playerSelection = ' ';

            Console.Clear();
            Console.WriteLine("\nKim Milyoner Olmak Ister?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Kural: Toplam 3 sorudan 2 tanesini bildiğiniz zaman büyük ödülü kazanacaksınız");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hazır olduğunuzda Enter tuşuna basınız. İyi oyunlar :)");
            Console.ReadLine();
            Console.Clear();

            
            while(true){                //1. Soru için Geçerli cevap alana kadar devam eden bir sistem 

                Console.Clear();
                Console.WriteLine("Aşağıdaki canlılardan hangisinin sınıfı kuştur ?");
                Console.WriteLine("A) Yarasa         B) Kartal");
                Console.Write("Cevabınız: ");
                playerSelection = Convert.ToChar(Console.ReadLine().ToLower()) ;

                if(playerSelection == 'b'){
                    point++;
                    Console.WriteLine("Doğru cevap. :)");
                    Console.WriteLine("Sıradaki soru için Enter tuşuna basın.");
                    Console.ReadLine();
                    break;
                }
                else if(playerSelection == 'a'){
                    Console.WriteLine("Yanlış cevap. :(");
                    Console.WriteLine("Sıradaki soru için Enter tuşuna basın.");
                    Console.ReadLine();
                    break;
                }
                else{
                Console.WriteLine("Geçersiz şık tercihi yaptınız.\nTekrar Denemek için Enter tuşuna basın.");
                Console.ReadLine();
                }
            }


            while(true){                   //2. soru için geçerli bir cevap alana kadar devam eden bir sistem

                Console.Clear();
                Console.WriteLine("Yüzölçümü olarak en büyük kıya hangisidir ?");
                Console.WriteLine("A) Asya         B) Afrika");
                Console.Write("Cevabınız: ");
                playerSelection = Convert.ToChar(Console.ReadLine().ToLower());

                if(playerSelection == 'a'){
                    point++;
                    Console.WriteLine("Doğru cevap. :)");
                    Console.WriteLine("Devam etmek için Enter tuşuna basın.");
                    Console.ReadLine();
                    break;
                }
                else if(playerSelection == 'b'){
                    Console.WriteLine("Yanlış cevap. :(");
                    Console.WriteLine("Devam etmek için Enter tuşuna basın.");
                    Console.ReadLine();
                    break;
                }
                else{
                Console.WriteLine("Geçersiz şık tercihi yaptınız.\nTekrar Denemek için Enter tuşuna basın.");
                Console.ReadLine();
                }
            }

            //2. sorudan sonra elde edilen puana göre if karar yapısını kullanarak oyuna devam edip etmeyeciğinin hesaplanması

            if(point == 0){                                             
                Console.Clear();
                Console.WriteLine("Maalesef kazanma şansınız kalmadı. :( ");
            }
            else if(point == 1){

                    while(true){

                    Console.Clear();
                    Console.WriteLine("Aşağıdaki müzik gruplarından hangi tür olarak 'metal' yapmaktadırlar ?");
                    Console.WriteLine("A) Gojira         B) Men I Trust ");
                    Console.Write("Cevabınız: ");
                    playerSelection = Convert.ToChar(Console.ReadLine().ToLower());

                    if(playerSelection == 'a'){
                        point++;
                        Console.WriteLine("Doğru cevap. :)");
                        Console.WriteLine("Tebrikler! Büyük ödülü kazandınız.");
                        break;
                    }
                    else if(playerSelection == 'b'){
                        Console.WriteLine("Yanlış cevap. :(");
                        Console.WriteLine("Maalesef oyunu kaybettiniz. :( ");
                        break;
                    }
                    else{
                    Console.WriteLine("Geçersiz şık tercihi yaptınız.\nTekrar Denemek için Enter tuşuna basın.");
                    Console.ReadLine();
                    }
            }
            }
            else{
                Console.Clear();
                Console.WriteLine("Tebrikler! Büyük ödülü kazandınız.");
            }
            

            





        }
    }
}