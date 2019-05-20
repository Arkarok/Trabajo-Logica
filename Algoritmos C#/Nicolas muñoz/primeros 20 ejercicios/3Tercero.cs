using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Buddy, enter a number to calculate it square power please");
            int a = Int32.Parse(Console.ReadLine());
            int b = a * a;
            Console.WriteLine("the main number is: {0}, and it square power is {1}", a, b);
            Console.ReadKey();
        }
    }
}
