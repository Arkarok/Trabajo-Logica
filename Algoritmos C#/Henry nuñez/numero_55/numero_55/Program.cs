using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de cualquier poligono");
            int x = 0, area = 0, i, area_total = 0, d = 0;
            Console.WriteLine("Digite el numero de vertices");
            x = Int32.Parse(Console.ReadLine());
            int a;
            int b;

            for(i = 0; i < x; i++)
            {
                Console.WriteLine("Ingrese los vertices (x,y)" + i);
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
            }

            for (i = 0; i < x - 1; i++)
            {
                area = (a * b / 2);
            }
        }
    }
}
