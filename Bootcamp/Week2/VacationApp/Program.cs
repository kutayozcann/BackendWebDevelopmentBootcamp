using System;

namespace VacationApp{

    class Program{

        static void Main(string[] args){

                // Bu uygulama, kullanıcıların tatil planı yapmalarını sağlar.
                // Lokasyon, ulaşım yöntemi ve kişi sayısına göre toplam maliyet hesaplanır.    

            System.Console.WriteLine("Yol Arkadaşım uygulamasına hoş geldiniz!");
            
            bool app = false;               // Uygulamanın çalışmaya devam edip etmeyeceğini kontrol eder.

            while(!app){                    // Ana döngü: Kullanıcı çıkmak isteyene kadar çalışır.

            bool locBool = true;            // Lokasyon seçiminin döngü kontrolü değişkeni
            int totalCost = 0;              // Toplam tutar 
            string? locationChoice = "";    // Lokasyon seçim değişkeni

            while(locBool){                 // Lokasyon seçim döngüsü

                System.Console.WriteLine("Gidebileceğiniz lokasyonlar :");
                System.Console.WriteLine("Bodrum        Marmaris        Çeşme");
                System.Console.Write("Lokasyon Tercihiniz: ");

                locationChoice = Console.ReadLine().ToLower();

                switch(locationChoice){         
                    case "bodrum":              // Lokasyon seçildiğinde mesaj göster ve maliyeti artır.
                        Console.Clear();
                        System.Console.WriteLine("Bodrum'a gidiyorsunuz!");
                        totalCost += 4000;
                        locBool = false;        // Lokasyon seçildiğinde döngüyü bitir.
                        break;
                    case "marmaris":
                        Console.Clear();
                        System.Console.WriteLine("Marmaris'e gidiyorsunuz!");
                        totalCost += 3000;
                        locBool = false;
                        break;
                    case "çeşme":
                        Console.Clear();
                        System.Console.WriteLine("Çeşme'ye gidiyorsunuz!");
                        totalCost += 5000;
                        locBool = false;
                        break;
                    default:
                        Console.Clear();            //Geçersiz lokasyon uyarısı
                        System.Console.WriteLine("Geçersiz lokasyon girildi! Lütfen geçerli bir konum girin.");
                    break;
                }
            }

            bool countBool = false;                 //Kişi sayısı için döngü kontrol değişkeni
            int personCounter = 0;                  //Kişi sayısı değişkeni

            while(!countBool){                      //Kişi sayısı girişi için döngü
                System.Console.Write("Tatili kaç kişi için planlıyorsunuz: ");
                countBool = int.TryParse(Console.ReadLine(), out personCounter);
                    if(countBool == false){  
                        // Kullanıcı geçersiz giriş yaptığında uyarı ver.                                   
                        Console.Clear();
                        System.Console.WriteLine("Geçersiz bir giriş yaptınız! Lütfen geçerli bir sayı giriniz.");
                    }
            }

            switch(locationChoice){            //Lokasyon tercihine göre bilgilendirme
                case "bodrum":
                    System.Console.WriteLine("Ege'nin incisi Bodrum, tarihi kalıntıları ve canlı gece hayatıyla ünlüdür.");
                    System.Console.WriteLine("Masmavi denizi ve huzurlu koylarıyla hem dinlenmek hem de eğlenmek için ideal bir tatil sunar.");
                    System.Console.WriteLine("Bodrum Kalesi ve Sualtı Arkeoloji Müzesi, tarih ve kültür meraklıları için kaçırılmayacak noktalardır.");
                    break;
                case "marmaris":
                    System.Console.WriteLine("Marmaris, doğayla iç içe koyları ve marinalarıyla yat turizminin merkezlerinden biridir.");
                    System.Console.WriteLine("Çam ormanlarıyla çevrili plajları ve su sporları olanakları, doğaseverler için benzersiz bir deneyim sunar.");
                    System.Console.WriteLine("Tarihi Kaleiçi bölgesi ve limanı, fotoğraf tutkunları ve gezginler için harika manzaralar barındırır.");
                    break;
                case "çeşme":
                    System.Console.WriteLine("Çeşme, rüzgar sörfü ve plaj partileriyle ünlü enerjik bir tatil beldesidir.");
                    System.Console.WriteLine("Ilıca Plajı'nın sıcak termal suları ve yumuşak kumu, dinlenmek için mükemmel bir ortam sağlar.");
                    System.Console.WriteLine("Alaçatı'nın taş sokakları ve şirin kafeleri, huzurlu bir yürüyüş yapmak isteyenler için idealdir.");
                    break;
                default:
                    break;
            }

            int wayChoice = 0 ;                     // Yol seçimi için değişken
            bool wayBool = false;                   // Yol seçimi döngüsü için kontrol değişkeni

            while(!wayBool){                        // Yol seçimi döngüsü

                System.Console.WriteLine("Tatile hangi yolu kullanarak gitmek istersiniz ? ");
                System.Console.WriteLine("1 - Kara Yolu");
                System.Console.WriteLine("2 - Hava Yolu");
                System.Console.Write("Yol tercihiniz: ");

                wayChoice = Convert.ToInt16(Console.ReadLine());

                switch(wayChoice){              // Yol Seçimleri
                    case 1:
                        System.Console.WriteLine("Kara yolunu seçtiniz.");
                        wayBool = true;
                        totalCost += (personCounter * 1500); 
                        break;
                    case 2:
                        System.Console.WriteLine("Hava yolunu seçtiniz.");
                        wayBool = true;
                        totalCost += (personCounter * 4000);
                        break;
                    default:
                        System.Console.WriteLine("Geçersiz bir yol tercihi yaptınız. Lütfen geçerli bir tercih yapınız.");
                        break;
                }
            }

            System.Console.WriteLine("Seçmiş olduğunuz tatil planı: ");
            System.Console.WriteLine("Tatil Lokasyonu: " + locationChoice);
            System.Console.WriteLine("Kişi sayısı: "+ personCounter);
            System.Console.WriteLine("Tatile gidiş şekli : "+ wayChoice);
            System.Console.WriteLine("Tatil planının toplam maliyeti: "+ totalCost);
            System.Console.WriteLine("İyi Tatiller!");
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine("Yeni bir tatil planı yapmak ister misiniz ?");
            System.Console.WriteLine("1 - Evet");
            System.Console.WriteLine("2 - Hayır");
            System.Console.Write("Tercihiniz: ");

            int newPlanChoice = Convert.ToInt16(Console.ReadLine());
            bool newPlanChoiceBool = false;                             // Yeni plan sorgu kontrol değişkeni

            while(!newPlanChoiceBool){                                  // Yeni plan için sorgu döngüsü

                if(newPlanChoice == 1){
                    Console.Clear();
                    System.Console.WriteLine("Yeni bir plan oluşturmayı seçtiniz.");
                    newPlanChoiceBool = true;
                }
                else if(newPlanChoice == 2){
                    System.Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler!");
                    System.Console.WriteLine("İyi Günler");
                    newPlanChoiceBool = true;
                    app = true;                 // Genel döngü sonlandırma
                }
                else{
                    System.Console.WriteLine("Geçersiz bir tercih yaptınız. Lütfen tekrar deneyin.");
                }
            }   
            }
        }
    }
}