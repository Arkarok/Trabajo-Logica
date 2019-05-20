using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primera letra en Mayusculas");
            string texto = Console.ReadLine();
            string a = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto);
            Console.WriteLine(a);
        }
    }
}
