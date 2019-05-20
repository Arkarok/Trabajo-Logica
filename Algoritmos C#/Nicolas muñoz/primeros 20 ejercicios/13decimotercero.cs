using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the first value");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("put the second value");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("the original first value is: {0}", a);
            Console.WriteLine("the original secon value is: {0},", b);

            double c = a;
            a = b;
            b = c;
            

            Console.WriteLine("The new first value is {0}", a);
            Console.WriteLine("& the new second value is: {0}", b);
            Console.ReadKey();
        }
    }
}
