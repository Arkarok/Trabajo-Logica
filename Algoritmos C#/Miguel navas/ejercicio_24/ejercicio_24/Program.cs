using System;


namespace ejercicio_22 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe  un  algoritmo  que  dada  una  cantidad  de  segundos  indique  cuántos  minutos representan

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
