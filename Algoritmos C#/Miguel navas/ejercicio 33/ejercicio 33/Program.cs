using System;


namespace ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo que lea dos números y determine el mayor de ellos

            int numero1, numero2;

            Console.WriteLine("Ingrese el primer numero = ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero = ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("el primer numero es mayor que el segundo numero");
            }

            else if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros son iguales! ");
            }

            else
            {
                Console.WriteLine("El segundo numero es mayor que el primero");
            }

        }
    }
}
