using System;


namespace ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite un numero");
            numero = int.Parse(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("EEs par y ademas...");
            }

            if (numero % 2 != 0)
            {
                Console.WriteLine("Es inpar y ademas...");
            }

            if (numero > 0)
            {
                Console.WriteLine("Es Positivo!");
            }

            else
            {
                Console.WriteLine("Es Negativo!");

            }
            





        }
    }
}
