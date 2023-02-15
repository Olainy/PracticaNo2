using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número inicial:");
            int numInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número final:");
            int numFinal = int.Parse(Console.ReadLine());

            for (int i = numInicial; i <= numFinal; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        static bool EsPrimo(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
            Console.ReadKey();

        }

    }
}