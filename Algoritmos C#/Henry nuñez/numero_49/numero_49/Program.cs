using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador");
            int letra = 0;
            int numero = 0;
            int espacio = 0;
            int i = 0;
            Console.WriteLine("Digita un texto");
            string texto = Console.ReadLine();
            int longitud = texto.Length;

            for (; i < longitud;i++)
            {
                if (texto[i]==' ')
                {
                    espacio++;
                }
            }
            letra = longitud - espacio;
            numero = letra - espacio-longitud;
            Console.WriteLine("La cantidad de espacios fue de: " + espacio);
            Console.WriteLine("La cantidad de letras fue de" + letra);
            Console.WriteLine("La cantidad de numeros fue de" + numero);
        }
    }
}
