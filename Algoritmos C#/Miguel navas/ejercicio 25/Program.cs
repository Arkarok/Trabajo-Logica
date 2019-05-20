using System;


namespace ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Digite el numero de cuatro cifras que desea invertir: ");

                char[] array = Console.ReadLine().ToCharArray();

                Array.Reverse(array);

                string n = new string(array);

                Console.WriteLine(n);
            }





        }

    }

}
