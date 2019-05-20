using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero menor a 100.000");
            int n = Int32.Parse(Console.ReadLine());

            if (n >= 100000)
            {
                Console.WriteLine("El numero tiene que ser menor que 100.000");
            }

            else
            {
                ///Console.WriteLine("El numero tiene que ser menor que 100.000");
            }

            if (n >= 10000 || n < -10000)
            {
                Console.WriteLine(n + " Tiene 5 digitos");
            }

            else if (n >= 1000 || n >= -9999 && n < -1000)
                Console.WriteLine(n + " Tiene 4 digitos");

            else if (n >= 100 || n >= -999 && n < -100)
                Console.WriteLine(n + " Tiene 3 digitos");

            else if (n > 10 || n >= -99 && n < -10)
                Console.WriteLine(n + " Tiene 2 digitos");

            else if (n >= -9)
                Console.WriteLine(n + " Tiene 1 digito");
        }
    }
}
