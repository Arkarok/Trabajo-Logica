using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the object mass value(kg)");
            double m = Double.Parse(Console.ReadLine());

            int c = 299792458;

            Console.WriteLine("the speed of light is {0}", c);

            double e = m * Math.Pow(c, 2);


            Console.WriteLine("The energy is {0}", e);
            Console.ReadKey();
        }
    }
}
