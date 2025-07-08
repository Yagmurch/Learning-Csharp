using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            data data = new data();

            data.number = 1;
            data.name = "test";
            data.description = "test description";
            Console.WriteLine("Number: " + data.number);
            Console.WriteLine("Name: " + data.name);
            Console.WriteLine( "Description: " + data.description);


        }

        public class data
        {
          public int number { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }
    }
}
