using System;


namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int venta;
            float valorIVA;
            Console.WriteLine("Digite el valor de la venta: ");
            venta = int.Parse(Console.ReadLine());

            valorIVA = venta * 0.19;

            if (valorIVA > 150000)
            {
                venta = venta * 0.95;
            }

            Console.WriteLine("El valor total del producto es = ", venta);

        }

    }

}