using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the object mass value 1(kg)");
            double m1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("put the mass value 2(kg)");
            double m2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("put the object aceleration");
            double a = Double.Parse(Console.ReadLine());

            double strength1 = m1 * a;
            double strength2 = m2 * a;

            double fstrength = strength1 + strength2;

            Console.WriteLine("the strength1 is: {0}, the strength2 is: {1} & the final strength is: {2} ", strength1, strength2, fstrength);


           
            Console.ReadKey();

        }
    }
}
