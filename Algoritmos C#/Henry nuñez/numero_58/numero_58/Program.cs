﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros 10 numeros naturales pares");
            int i = 1;

            for (; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
