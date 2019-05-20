using System;


namespace Ejercicio 21  
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un  algoritmo que  dada una  cantidad de  segundos indique  cuántas horas representan
            int segundos;
            int conversion;
            Console.WriteLine("Digite los segundos que desea convertir ");
            segundos = int.Parse(Console.ReadLine());
            conversion = (segundos * 24) / 86400;



            Console.Write("Los segundos convertidos a horas van a ser iguales a");
            Console.Write(conversion);
            Console.Write(" horas"); 

            




        }
    }
}
