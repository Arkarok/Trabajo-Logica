using System;

namespace Ejercicio__27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo que lea un número y determine si es par o impar

            int numero;

            Console.WriteLine("Digite un numero cualquiera: ");
            numero = int.Parse(Console.ReadLine());

            if ((numero % 2) == 0)

            {
                Console.WriteLine("Es PAR!!");

            }

            else
            {
                Console.WriteLine("Es IMPAR!!!");
            }
            






        }
    }
}
