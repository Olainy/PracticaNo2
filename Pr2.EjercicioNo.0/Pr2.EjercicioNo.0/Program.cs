using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la fracción mixta en el formato 'entero numerador/denominador': ");
            string fraccionMixta = Console.ReadLine();

            // Dividir la fracción mixta en sus componentes
            int entero, numerador, denominador;
            string[] componentes = fraccionMixta.Split(' ');
            entero = int.Parse(componentes[0]);
            string[] fraccion = componentes[1].Split('/');
            numerador = int.Parse(fraccion[0]);
            denominador = int.Parse(fraccion[1]);

            // Convertir la fracción mixta a fracción común
            numerador += entero * denominador;

            // Simplificar la fracción común
            int mcd = MCD(numerador, denominador);
            numerador /= mcd;
            denominador /= mcd;

            // Mostrar el resultado
            Console.WriteLine("La fracción común equivalente es: {0}/{1}", numerador, denominador);

            Console.ReadLine();
        }

        // Función para calcular el máximo común divisor
        static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
