using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita un numero entre (0,10)");

            int num = Int32.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine(num + "--> UNO");
                    break;

                case 2:
                    Console.WriteLine(num + "--> DOS");
                    break;

                case 3:
                    Console.WriteLine(num + "--> TRES");
                    break;

                case 4:
                    Console.WriteLine(num + "--> CUATRO");
                    break;

                case 5:
                    Console.WriteLine(num + "--> CINCO");
                    break;

                case 6:
                    Console.WriteLine(num + "--> SEIS");
                    break;

                case 7:
                    Console.WriteLine(num + "--> SIETE");
                    break;

                case 8:
                    Console.WriteLine(num + "--> OCHO");
                    break;

                case 9:
                    Console.WriteLine(num + "--> NUEVE");
                    break;

                case 10:
                    Console.WriteLine(num + "--> DIES");
                    break;

                default:
                    Console.WriteLine("El numero asignado no se encuentra contemplado dentro de (0,10)");
                    break;
            }
        }
    }
}
