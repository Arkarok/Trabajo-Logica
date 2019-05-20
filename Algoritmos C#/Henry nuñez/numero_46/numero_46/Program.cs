using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita un numero");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digita otro numero");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digita nuevamente un numero");
            int num3 = Int32.Parse(Console.ReadLine());

            if (num1 == num2 || num2 == num3 || num1 == num3)
                Console.WriteLine("Por lo menos hay dos o mas numeros iguales");

            else
                Console.WriteLine("No hay numeros iguales");
        }
    }
}
