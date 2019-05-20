using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put radio value");
            double rad = Double.Parse(Console.ReadLine());
            double a = 2 * 3.14 * rad;
            double b = 3.14 * (rad * rad);
            Console.WriteLine("The perimete is {0}, & the area is {1}", a, b);
            Console.ReadKey();
        }
    }
}
