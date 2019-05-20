using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dias de la semana");
            Console.WriteLine("Digita un numero");
            int num = Int32.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine(num + " --> LUNES");
                    break;

                case 2:
                    Console.WriteLine(num + " --> MARTES");
                    break;

                case 3:
                    Console.WriteLine(num + " --> MIERCOLES");
                    break;

                case 4:
                    Console.WriteLine(num + " --> JUEVES");
                    break;

                case 5:
                    Console.WriteLine(num + " --> VIERNES");
                    break;

                case 6:
                    Console.WriteLine(num + " --> SABADO");
                    break;

                case 7:
                    Console.WriteLine(num + " --> DOMINGO");
                    break;

                default:
                    Console.WriteLine("El numero asignado no se encuentra contemplado entre los dias de la semana");
                    break;
            }
        }
    }
}
