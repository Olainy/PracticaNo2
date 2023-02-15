using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una palabra: ");
            string palabra = Console.ReadLine();

            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string palabraInvertida = new string(caracteres);

            Console.WriteLine("Palabra invertida: " + palabraInvertida);

            Console.ReadKey();
        }
    }
}