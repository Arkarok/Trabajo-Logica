using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_54
{
    class Program
    {
        static void Main(string[] args)
        {
            string caracter;
            Console.WriteLine("PALINDROMO");
            Console.WriteLine("Digita el texto o palabra para saber si es palindromo o no");
            string palabra = Console.ReadLine();
            int i = palabra.Length;
            string inverso = "";

            for (int x = i - 1; x >= 0; x--)
            {
                caracter = palabra.Substring(x, 1);
                inverso = inverso + caracter;
            }
            if (palabra == inverso)
            {
                Console.WriteLine("Es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindromo");
            }
        }
    }
}
