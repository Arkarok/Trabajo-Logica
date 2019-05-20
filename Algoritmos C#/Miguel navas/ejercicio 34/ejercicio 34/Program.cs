using System;


namespace ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            numero3 = Convert.ToInt16(Console.ReadLine());
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("El numero mayor es " + numero1);
            }
            else
            {
                if (numero2 > numero1 && numero2 > numero3)
                {
                    Console.WriteLine("El numero mayor es " + numero2);
                }
                else
                {
                    Console.WriteLine("El numero mayor es " + numero3);


                }
            }
        }

    }

}