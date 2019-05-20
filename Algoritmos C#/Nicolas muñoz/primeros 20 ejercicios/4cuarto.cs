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
            Console.WriteLine("Hi Buddy, enter a number to calculate it sum with another one");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hi Buddy, enter a secon number to calculate it sum");
            int b = Int32.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("the first number is: {0},the secondone is: {1}, & the sum is: {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
