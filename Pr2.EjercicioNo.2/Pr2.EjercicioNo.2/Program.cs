using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int mcd = CalcularMCD(a, b);
            Console.WriteLine("El Máximo Común Divisor de " + a + " y " + b + " es: " + mcd);

            int mcm = CalcularMCM(a, b, mcd);
            Console.WriteLine("El Mínimo Común Múltiplo de " + a + " y " + b + " es: " + mcm);

            Console.ReadLine();
        }

        static int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static int CalcularMCM(int a, int b, int mcd)
        {
            return (a * b) / mcd;
        }
    }
}