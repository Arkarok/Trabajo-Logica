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
            Console.WriteLine("Hi Buddy, enter a number please");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hi Buddy, enter a number please");
            int b = Int32.Parse(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;
            Console.WriteLine("the first number is {0}, and the second one is: {1}", a, b);
            Console.WriteLine("the sum is: {0}", c);
            Console.WriteLine("the subtraction is: {0}", d);
            Console.WriteLine("the multiplication is: {0}", e);
            Console.WriteLine("the division is: {0}", f);
            Console.WriteLine("the residue is: {0}", g);
            Console.ReadKey();
        }
    }
}