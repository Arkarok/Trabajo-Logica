using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put x1");
            double x1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("put x2");
            double x2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("put y1");
            double y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("put y2");
            double y2 = Double.Parse(Console.ReadLine());

            double aux = ((x2 - x1) + (y2 - y1));

            double x = Math.Sqrt(aux);

            Console.WriteLine("the distance is: {0}, ", x);
            Console.ReadKey();
        }
    }
}
