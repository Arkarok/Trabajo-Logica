using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Penultima letra de un texto");
            string texto = Console.ReadLine();
            int longitud = texto.Length;
            string penultimovalor = texto.Substring(texto.Length - 2, 1);
            Console.WriteLine(penultimovalor);
        }
    }
}
