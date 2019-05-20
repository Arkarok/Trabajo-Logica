using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the aceleration value");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("The time value(in seconds)");
            double t = Double.Parse(Console.ReadLine());

            int initspeed = 0;

            double fspeed = initspeed + a * t ;  //fspeed=(final speed)

            Console.WriteLine("The final speed is {0}", fspeed);
            Console.ReadKey();
        }
    }
}
