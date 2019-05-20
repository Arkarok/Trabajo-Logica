using System;


namespace ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Ingresa el año = ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
            {
                Console.WriteLine("El año " + a + " SI es bisiesto! ");

            }

            else
            {
                Console.WriteLine("El año " + a + " NO es bisiesto! ");
            }
            Console.ReadLine();
        }
    }
}
