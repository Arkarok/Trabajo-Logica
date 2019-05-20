using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hi";
            Console.WriteLine("Hi Buddy, enter your name please");
            string b = Console.ReadLine();
            Console.WriteLine("your greeting message is: {0}, {1}", a, b);
            Console.ReadKey();
        }
    }
}