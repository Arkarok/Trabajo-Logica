using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N primeros numeros naturales");
            Console.WriteLine("Digita el numero de repeticiones");
            int num = Int32.Parse(Console.ReadLine());
            int i = 1;

            for (; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
