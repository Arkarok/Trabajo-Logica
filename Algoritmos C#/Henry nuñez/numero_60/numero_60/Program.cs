using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N numeros naturales change");
            Console.WriteLine("Digita el numero de repeticiones");
            int num = Int32.Parse(Console.ReadLine());
            int i = 1;

            for (; i <= num; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i*-1);
                else
                    Console.WriteLine(i);
            }
        }
    }
}
