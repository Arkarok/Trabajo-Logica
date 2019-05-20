using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put a num");
            int a = Int32.Parse(Console.ReadLine());

            int b = a * 11;

            int c = a * 111;

            int d = a + b + c;

  

            Console.WriteLine("The nums to sum are {0}, {1}, {2} & the sum is {3}", a, b, c, d);
            Console.ReadKey();
        }
    }
}
