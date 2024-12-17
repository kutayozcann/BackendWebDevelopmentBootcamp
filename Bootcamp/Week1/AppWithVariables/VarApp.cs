using System;

namespace AppWithVariables{
    class Program{

        static void Main(string[] args){

            Console.WriteLine("Lutfen asagidaki bilgileri giriniz: ");

            string? tcNo, firstName, lastName, phoneNo, age;  //İşlem görmeyecek (sabit) değişkenleri string olarak tanımladım
            double firstItem, secondItem;                    //İndirim sonrası veri kaybı olmaması için double(ondalık) bir şekilde tanımladım

            Console.Write("T.C. Kimlik Numarası: ");        
            tcNo = Console.ReadLine();

            Console.Write("Adi: ");
            firstName = Console.ReadLine();

            Console.Write("Soyadi: ");
            lastName = Console.ReadLine();

            Console.Write("Telefon Numarasi: ");
            phoneNo = Console.ReadLine();

            Console.Write("Yas: ");
            age = Console.ReadLine();

            Console.Write("Ilk Aldigi Urunun Fiyati:  ");
            firstItem = Convert.ToDouble(Console.ReadLine());           //String input'u convert ile double'a çevirme
            
            Console.Write("Ikinci Aldigi Urunun Fiyati:  ");
            secondItem = Convert.ToDouble(Console.ReadLine());          //String input'u convert ile double'a çevirme

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine($"{tcNo} Tc numarali {firstName} {lastName} isimli kisi icin kayit olusturulmustur.");
            Console.WriteLine($"{phoneNo} telefon numarasina bildirim mesaji gonderilmistir.");

            double total = firstItem + secondItem;                      //Patika Puan
            double patikaPoint = total * 0.1;                           //Hesaplama işlemleri

            Console.WriteLine($"{total} toplam harcama karsiligi kazanilan 10% patika puan miktari -> {patikaPoint} TL'dir.");       
        }

    }
}