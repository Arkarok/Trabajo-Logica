using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the sale price");
            double value = Double.Parse(Console.ReadLine());
            double iva_value = value * 0.19;
            double final_p = value + iva_value;

            Console.WriteLine("The price is: {0}, the iva price is: {1}, and the price with iva is {2}", value, iva_value, final_p);
            Console.ReadKey();
        }
    }
}
