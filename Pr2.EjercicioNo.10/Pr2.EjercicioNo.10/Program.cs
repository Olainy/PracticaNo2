using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir tamaño del arreglo y crearlo
            int tamano = 10;
            int[] arreglo = new int[tamano];

            // Generar números aleatorios y guardarlos en el arreglo
            Random random = new Random();
            for (int i = 0; i < tamano; i++)
            {
                arreglo[i] = random.Next(100);
            }

            // Imprimir el arreglo sin ordenar
            Console.WriteLine("Arreglo sin ordenar:");
            ImprimirArreglo(arreglo);

            // Ordenar el arreglo de manera descendente por el método de la burbuja
            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = 0; j < tamano - i - 1; j++)
                {
                    if (arreglo[j] < arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }

            // Imprimir el arreglo ordenado de manera descendente
            Console.WriteLine("Arreglo ordenado de manera descendente:");
            ImprimirArreglo(arreglo);

            // Ordenar el arreglo de manera ascendente por el método de la burbuja
            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = 0; j < tamano - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }

            // Imprimir el arreglo ordenado de manera ascendente
            Console.WriteLine("Arreglo ordenado de manera ascendente:");
            ImprimirArreglo(arreglo);

            // Esperar a que el usuario presione cualquier tecla para salir
            Console.ReadKey();
        }

        // Función para imprimir un arreglo
        static void ImprimirArreglo(int[] arreglo)
        {
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
    }
}
