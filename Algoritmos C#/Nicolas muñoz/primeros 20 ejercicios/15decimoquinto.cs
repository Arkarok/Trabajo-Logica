using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the aceleration value");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("The time value(in seconds)");
            double t = Double.Parse(Console.ReadLine());

            double dtrav = ((a * (t * t)) / 2);  //dtrav(distace traveled)

            Console.WriteLine("The distance traveled is {0}", dtrav);
            Console.ReadKey();
        }
    }
}
