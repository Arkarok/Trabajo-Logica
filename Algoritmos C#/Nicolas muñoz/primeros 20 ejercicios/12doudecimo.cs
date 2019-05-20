using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the first value");
            double n1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("put the second value");
            double n2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("put the third value");
            double n3 = Double.Parse(Console.ReadLine());

            double average = (n1 + n2 + n3) / 3;

            Console.WriteLine("The numbers are {0}, {1}, {2}; & the average is: {3} ", n1, n2, n3, average);
            Console.ReadKey();
        }
    }
}
