using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese b: ");
            int b = int.Parse(Console.ReadLine());

            int sumCubes = (a * a * a) + (b * b * b);
            int diffCubes = (a - b) * (a * a + a * b + b * b);

            Console.WriteLine($"La suma de los cubos de {a} y {b} es {sumCubes}");
            Console.WriteLine($"La diferencia de los cubos de {a} y {b} es {diffCubes}");

            Console.ReadLine(); 
        }
    }
}        