using System;


namespace ejercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un numero positivo o negativo: ");

            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            

            {
                Console.WriteLine("Es positivo!");
            }

            else
            {
                Console.WriteLine("Es Negativo!");


            }


        }
    }
}
