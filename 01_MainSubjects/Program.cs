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
            #region Yazd�rmaKomutlar�

            //Console.WriteLine("Merhaba D�nya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-�orbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-So�uk Ba�lang��lar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("S-Tatl�lar");
            //Console.WriteLine("6-��ecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDe�i�kenler

            //string
            //De�i�ken_t�r� de�i�ken_ad�;

            //string name;
            //name = "Yagmur";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "��nar";
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

            //customerName = "Ay�eg�l";
            //Console.WriteLine(customerName);

            #endregion

            #region Int De�i�kenler

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

            hamburgerCount = 2;
            cokeCount = 3;

            totalhamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;

            console.WriteLine("Total Hamburger Price: " + totalhamburgerPrice + " TL");
            console.WriteLine("Total Coke Price: " + totalCokePrice + " TL");

            console.writeLine();

            int totalPrice = totalhamburgerPrice + totalCokePrice;
            console.WriteLine("Total Order Price: " + totalPrice + " TL");


            #endregion
        }
    }
}