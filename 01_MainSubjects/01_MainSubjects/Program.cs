using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları  

            //Console.WriteLine("Merhaba Dünya");  
            //Console.Write("Selam");  

            //Console.WriteLine("***** Yemek Kategorileri *****");  
            //Console.WriteLine();  
            //Console.WriteLine("1-Çorbalar");  
            //Console.WriteLine("2-Ana Yemekler");  
            //Console.WriteLine("3-Soğuk Başlangıçlar");  
            //Console.WriteLine("4-Salatalar");  
            //Console.WriteLine("S-Tatlılar");  
            //Console.WriteLine("6-İçecekler");  
            //Console.WriteLine();  
            //Console.WriteLine("***** Yemek Kategorileri *****");  

            #endregion

            #region StringDeğişkenler  

            //string  
            //Değişken_türü değişken_adı;  

            //string name;  
            //name = "Yagmur";  
            //Console.WriteLine(name);  

            //string customerName;  
            //string customerSurname;  
            //string customerPhone;  
            //string customerEmail, district, city;  

            //customerName = "Ali";  
            //customerSurname = "Çınar";  
            //customerPhone = "+90 535 700 3560";  
            //customerEmail = "deneme@gmail.com";  
            //district = "Mudanya";  
            //city = "Bursa";   

            //Console.WriteLine("**** Reservation Card ****");  
            //Console.WriteLine();  
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);  
            //Console.WriteLine("Contact: " + customerPhone);  
            //Console.WriteLine("Email Address: " + customerEmail);  
            //Console.WriteLine("Address: " + district + " / " + city);  

            //customerName = "Ayşegül";  
            //Console.WriteLine(customerName);  

            #endregion

            #region Int Değişkenler  

            //int  
            //int number = 24;  
            //Console.WriteLine(number);  

            int hamburgerPrice = 300;
            int cokePrice = 35;

            Console.WriteLine("----- Hamburger and Drink Order -----");
            Console.WriteLine("Hamburger Price: " + hamburgerPrice + " TL");
            Console.WriteLine("Coke Price: " + cokePrice + " TL");

            int hamburgerCount;
            int cokeCount;

            int totalPrice = 0;

            hamburgerCount = 2;
            cokeCount = 3;

            int totalhamburgerPrice = hamburgerPrice * hamburgerCount; // Fixed missing declaration  
            int totalcokePrice = cokePrice * cokeCount; // Fixed missing declaration  

            Console.WriteLine("Hamburger Count: " + hamburgerCount);
            Console.WriteLine("Coke Count: " + cokeCount);

            #endregion
        }
    }
}
