using System;


namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {

            int segundos;
            int conversion;

            Console.WriteLine("Digite los segundos que desea convertir: ");
            segundos = int.Parse(Console.ReadLine());
            conversion = segundos / 60;

            Console.Write("Los segundos convertidos a minutos van a ser iguales a ");
            Console.Write(conversion);
            Console.Write("minutos");

        }
    }
}
