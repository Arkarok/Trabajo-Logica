using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the Hexagon side value");
            double side = Double.Parse(Console.ReadLine());

            Console.WriteLine("put the Hexagon apotema value");
            double apotema = Double.Parse(Console.ReadLine());

            double area = 3 * side * apotema;
            Console.WriteLine("The area is {0}", area);
            Console.ReadKey();
        }
    }
}
