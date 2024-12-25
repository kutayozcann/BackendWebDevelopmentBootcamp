using System;
using System.Security.Cryptography.X509Certificates;

namespace Week2Practice{
    class Program{
        static void Main(string[] args){

            //1. Soru
            System.Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");
            System.Console.WriteLine("-------------------------------------------");

            //2. Soru
            string name = "Kutay";
            int num = 10;
            System.Console.WriteLine($"İsim : {name} , Sayı : {num}");
            System.Console.WriteLine("-------------------------------------------");

            //3. Soru
            Random rand = new Random();
            int randNum1 = rand.Next();
            System.Console.WriteLine($"Rastgele bir sayı : {randNum1}");
            System.Console.WriteLine("-------------------------------------------");

            //4. Soru            
            int randNum = rand.Next(1, 100);
            System.Console.WriteLine($"Rastgele sayı : {randNum}, 3'e bölümünden kalan : {randNum%3}");
            System.Console.WriteLine("-------------------------------------------");

            //5. Soru
            System.Console.Write("Lütfen yaşınızı giriniz :");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 18){
                System.Console.WriteLine("+");
            }
            else{
                System.Console.WriteLine("-");
            }    
            System.Console.WriteLine("-------------------------------------------");

            //6. Soru
            for(int i = 0; i < 10; i++){
                System.Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }
            System.Console.WriteLine("-------------------------------------------");

            //7. Soru
            System.Console.Write("İlk metinsel değeri giriniz :");
            string? str1 = Console.ReadLine();
            System.Console.Write("İkinci metinsel değeri giriniz :");
            string? str2 = Console.ReadLine();
            string? tempStr = str1;
            str1 = str2;
            str2 = tempStr;
            System.Console.WriteLine($"İlk metinsel değer : {str1}");
            System.Console.WriteLine($"İkinci metinsel değer : {str2}");
            System.Console.WriteLine("-------------------------------------------");

            //8. Soru
            BenDegerDondurmem();
            System.Console.WriteLine("-------------------------------------------");

            //9. Soru
            int sum = Sum(10,29);
            System.Console.WriteLine("-------------------------------------------");

            //10.Soru
            System.Console.Write("True veya False değer giriniz :");
            bool? boolInput = Convert.ToBoolean(Console.ReadLine());
            string convertedInput = BoolToString(boolInput);
            System.Console.WriteLine($"Girilen değer : {convertedInput}");
            System.Console.WriteLine("-------------------------------------------");

            //11. Soru
            int age1 = 25, age2 = 34, age3 = 9;
            int biggestAge = BiggestAge(age1, age2, age3);
            System.Console.WriteLine($"İlk yaş :{age1}, İkinci yaş :{age2}, Üçüncü yaş :{age3}");
            System.Console.WriteLine($"En büyük yaş : {biggestAge}");
            System.Console.WriteLine("-------------------------------------------");

            //12. Soru
            int maxNumber = FindMaxNumber();
            System.Console.WriteLine($"En büyük sayı : {maxNumber}");
            System.Console.WriteLine("-------------------------------------------");

            //13. Soru
            System.Console.Write("İlk metinsel değer: ");
            string? strSwitch1 = Console.ReadLine();
            System.Console.Write("İkinci metinsel değer: ");
            string? strSwitch2 = Console.ReadLine();

            SwitchStrings(ref strSwitch1, ref strSwitch2);
            System.Console.WriteLine($"Artık İlk metinsel değer : {strSwitch1}");
            System.Console.WriteLine($"Artık İkinci metinsel değer : {strSwitch2}");
            System.Console.WriteLine("-------------------------------------------");

            //14. Soru 
            System.Console.Write("Bir sayı giriniz: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            bool isEven = EvenOdd(numberInput);
            System.Console.WriteLine($"Girdiğiniz sayı çifttir :{isEven}");
            System.Console.WriteLine("-------------------------------------------");

            //15. Soru
            System.Console.Write("Aracın hızını km/h cinsinden giriniz :");
            int speed = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Aracın kaç saat yol aldığını giriniz :");
            int time = Convert.ToInt32(Console.ReadLine());
            int road = RoadProblem(speed,time);
            System.Console.WriteLine($"Aracın gittiği toplam yol km cinsinden : {road}km");
            System.Console.WriteLine("-------------------------------------------");

            //16. Soru
            System.Console.Write("Alanını hesaplamak istediğiniz dairenin yarıçapını giriniz: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = CircleArea(r);
            System.Console.WriteLine($"Dairenin alanı :{area}");
            System.Console.WriteLine("-------------------------------------------");

            //17. Soru
            string str3 = "Zaman bir GeRi SayIm";
            System.Console.WriteLine(str3.ToUpper());
            System.Console.WriteLine(str3.ToLower());
            System.Console.WriteLine("-------------------------------------------");

            //18. Soru
            string strTrim = "    Selamlar   ";
            System.Console.WriteLine(strTrim.Trim());
            System.Console.WriteLine("-------------------------------------------");
        }


        //8.Soru için method tanımı
        public static void BenDegerDondurmem(){
            System.Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
        }

        //9. Soru için method tanımı
        public static int Sum(int a, int b){
            return a + b;
        }

        //10. Soru için method tanımı
        public static string BoolToString(bool? a){
            return (bool)a ? "Doğru" : "Yanlış";
        }

        //11. Soru için method tanımı
        public static int BiggestAge(int a, int b, int c){
            return Math.Max(a, Math.Max(b, c));
        }

        //12. Soru için method tanımı
        public static int FindMaxNumber(){

            System.Console.WriteLine("İstediğiniz kadar sayı girebilirsiniz (durmak için 'q' tuşlayın): ");

            int[] numbers = new int[10];
            int added = 0;

            while(true){
                System.Console.Write("Sayı giriniz : ");
                string? input = Console.ReadLine();

                if(input?.ToLower() == "q")
                    break;

                if(int.TryParse(input, out int number)){    //Girdi int'e dönüşebilme kontrolü

                    if(added == numbers.Length){    //Yer kalmadıysa yeniden boyutlandırma
                        Array.Resize(ref numbers, numbers.Length * 2);
                    }
                    numbers[added] = number;
                    added++;
                }
                else{
                    System.Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }

            }

            int max = numbers[0];
            foreach(var i in numbers){
                if(i > max){
                    max = i;
                }
            }

            System.Console.WriteLine("Girilen sayılar: " + string.Join(", ", numbers));
            return max;
        }

        //13. Soru için method tanımı
        public static void SwitchStrings(ref string a, ref string b){
            string temp = a;
            a = b;
            b = temp;
        }

        //14. Soru için method tanımı
        public static bool EvenOdd(int a){
            if(a % 2 == 0){
                return true;
            }
            else{
                return false;
            }

        }

        //15. Soru için method tanımı
        public static int RoadProblem(int speed, int time){
            return speed * time;
        }

        //16. Soru için method tanımı
        public static double CircleArea(double r){
            return Math.PI * Math.Pow(r, 2);
        }
    }
}