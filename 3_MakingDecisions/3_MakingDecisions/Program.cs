using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password; 
            //password= Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış.");
            //}


            //Console.Read();


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi.");
            //}

            //int number;
            //Console.Write(("Sayıyı giriniz: "));
            //number= int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.Write("Sayı doğru");

            //}
            //else
            //{
            //    Console.Write("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = ""; // Başlangıç değeri verildi
            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //else if (average > 50 && average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //else if (average > 70 && average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //else if (average > 84 && average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //else
            //{
            //    result = "Geçersiz ortalama";
            //}

            //Console.WriteLine(result);  


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();
            //if(city== "adana" | city == "adıyaman" | city == "afyonkarahisar" | city == "ağrı" | city == "amasya" | city == "ankara" | city == "antalya" | city == "artvin" | city == "aydın" | city == "balıkesir" | city == "bilecik" | city == "bingöl" | city == "bitlis" | city == "bolu" | city == "burdur" | city == "bursa" | city == "çanakkale" | city == "çankırı" | city == "çorum" | city == "denizli" | city == "diyarbakır" | city == "edirne" | city == "elazığ" | city == "erzincan" | city == "erzurum" | city == "eskişehir" | city == "gaziantep" | city == "giresun" | city == "gümüşhane" | city == "hakkari" | city == "hatay" | city == "ısparta" | city == "mersin")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı yanlış.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz, admin!");
            //}

            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("Birinci sayının ikinci sayıya bölümünden kalan: " + result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number= int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları

            //char team;
            //Console.Write("Lütfen takım seçiniz (A/B): ");
            //team = char.Parse(Console.ReadLine().ToUpper());
            //if (team == 'A')
            //{
            //    Console.WriteLine("Takım A seçildi.");
            //}
            //else if (team == 'B')
            //{
            //    Console.WriteLine("Takım B seçildi.");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz takım seçimi.");
            //}


            #endregion

            #region Restoran örneği

            //Console.WriteLine("=== Restoran Menüsü ===");
            //Console.WriteLine("1. Çorba");
            //Console.WriteLine("2. Ana Yemek");
            //Console.WriteLine("3. İçecek");
            //Console.WriteLine("4. Tatlı");
            //Console.WriteLine("5. Salata");
            //Console.Write("Bir kategori seçiniz (1-5): ");
            //string secim = Console.ReadLine();

            //if (secim == "1")
            //{
            //    Console.WriteLine("\n--- Çorbalar ---");
            //    Console.WriteLine("Mercimek Çorbası - 40 TL");
            //    Console.WriteLine("Ezogelin Çorbası - 45 TL");
            //}
            //else if (secim == "2")
            //{
            //    Console.WriteLine("\n--- Ana Yemekler ---");
            //    Console.WriteLine("Kebap - 150 TL");
            //    Console.WriteLine("Tavuk Şiş - 120 TL");
            //}
            //else if (secim == "3")
            //{
            //    Console.WriteLine("\n--- İçecekler ---");
            //    Console.WriteLine("Ayran - 20 TL");
            //    Console.WriteLine("Kola - 30 TL");
            //}
            //else if (secim == "4")
            //{
            //    Console.WriteLine("\n--- Tatlılar ---");
            //    Console.WriteLine("Baklava - 70 TL");
            //    Console.WriteLine("Sütlaç - 50 TL");
            //}
            //else if (secim == "5")
            //{
            //    Console.WriteLine("\n--- Salatalar ---");
            //    Console.WriteLine("Çoban Salata - 35 TL");
            //    Console.WriteLine("Mevsim Salata - 30 TL");
            //}

            //Console.WriteLine("\nAfiyet olsun!");

            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen ay seçiniz (1-12): ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Geçersiz ay numarası"); break;
            //}

            #endregion

            #region Switch Case - Hesap Makinesi

            //int num1, num2, result;
            //char operation;
            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen işlem seçiniz (+, -, *, /): ");
            //operation = char.Parse(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine("Sonuç: " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem.");
            //        break;
            //}


            Console.Read();
            #endregion



        }
    }
}
