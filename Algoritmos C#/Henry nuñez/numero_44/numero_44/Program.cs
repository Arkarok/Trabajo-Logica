using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita un numero");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digita otro numero");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 > 5 || num2 > 5)
                Console.WriteLine("FALSE");

            else if (num1 < 0 || num2 < 0)
                Console.WriteLine("FALSE");

            else
                Console.WriteLine("TRUE");
        }
    }
}
