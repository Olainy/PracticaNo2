using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Random
            Random rand = new Random();

            // Generar tres números aleatorios entre 1 y 100
            int num1 = rand.Next(1, 101);
            int num2 = rand.Next(1, 101);
            int num3 = rand.Next(1, 101);

            // Mostrar los números generados
            Console.WriteLine("Los números de la tómbola son: {0}, {1}, {2}", num1, num2, num3);

            // Esperar a que el usuario presione cualquier tecla
            Console.ReadKey();
        }
    }
}
