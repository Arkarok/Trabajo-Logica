using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put a decimal number");
            double value1 = Double.Parse(Console.ReadLine());
            int value2 = (int)value1;
            double result = value1 - value2;

            Console.WriteLine("number {0} -> int part {1}; & decimal part {2}", value1, value2, result);


            Console.ReadKey();
        }
    }
}
