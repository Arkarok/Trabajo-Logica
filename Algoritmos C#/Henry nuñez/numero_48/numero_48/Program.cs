using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_48
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "", num2 = "";
            Console.WriteLine("Texto invertido");
            Console.WriteLine("Escribe el texto a invertir");
            num1 = Console.ReadLine();

            for(int x= num1.Length - 1; x >= 0; x--)
            {
                num2 += num1[x];
            }

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
