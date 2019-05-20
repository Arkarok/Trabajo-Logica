using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita el primer numero");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digita el segundo numero");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digita el tercer numero");
            int num3 = Int32.Parse(Console.ReadLine());

            if (num1 < num2 && num2 < num3) 

                Console.WriteLine("Los numeros se estan incrementando");

            else if (num1 > num2 && num2 > num3) 

                Console.WriteLine("Los numeros estan disminuyendo");

            else

                Console.WriteLine("Los numeros no incrementan ni disminuyen");
        }
    }
}
