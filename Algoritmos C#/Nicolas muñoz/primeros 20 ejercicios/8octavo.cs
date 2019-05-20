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
            Console.WriteLine("put the first grade");
            double g1 = Double.Parse(Console.ReadLine());
            double G1 = g1 * 0.15;

            Console.WriteLine("put the second grade");
            double g2 = Double.Parse(Console.ReadLine());
            double G2 = g2 * 0.2;

            Console.WriteLine("put the third grade");
            double g3 = Double.Parse(Console.ReadLine());
            double G3 = g3 * 0.15;

            Console.WriteLine("put the fourth grade");
            double g4 = Double.Parse(Console.ReadLine());
            double G4 = g4 * 0.3;

            Console.WriteLine("put the fifth grade");
            double g5 = Double.Parse(Console.ReadLine());
            double G5 = g5 * 0.2;

            double result = G1 + G2 + G3 + G4 + G5;

            Console.WriteLine("The final prom is {0}", result);
            Console.ReadKey();
        }
    }
}
