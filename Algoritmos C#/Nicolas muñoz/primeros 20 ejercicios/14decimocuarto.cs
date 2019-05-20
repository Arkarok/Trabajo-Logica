using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the height value");
            double h = Double.Parse(Console.ReadLine());

            Console.WriteLine("The gravity value is 10");
            int g = 10;

            Console.WriteLine("The initial speed is 0");
            int inits = 0;

            double num = (inits + (2 * g * h));
            double fspeed = Math.Sqrt(num);

            double time = (fspeed - inits)/g;


            Console.WriteLine("The time value is {0:F3}", time); //solo se mostraran 3 decimales ({0:F3})
            Console.ReadKey();
        }
    }
}
