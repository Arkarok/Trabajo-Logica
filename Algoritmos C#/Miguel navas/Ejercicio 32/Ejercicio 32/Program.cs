using System;


namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo que lea un número 
            //y si este es mayor o igual a 10 devuelva el triple de este de lo contrario la cuarta parte de este.

            float numero,new_number;
            Console.WriteLine("escriba un numero = ");

            numero = float.Parse(Console.ReadLine());


            if (numero > 10)
            {
                new_number = numero * 3;
                Console.WriteLine("ya que es mayor a 10, el resultado será");
                Console.Write(new_number);
            }
            
            if (numero < 10)
            {
                new_number = (numero / 4);
                Console.Write("ya que es menor a 10, el resultado será");
                Console.Write(new_number);
            }

        }
    }
}
