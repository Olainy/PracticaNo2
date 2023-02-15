using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cadena de texto: ");
            string texto = Console.ReadLine();

            if (EsPalindromo(texto))
            {
                Console.WriteLine($"{texto} es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"{texto} no es un palíndromo.");
            }

            Console.ReadLine();
        }

        static bool EsPalindromo(string texto)
        {
            texto = texto.ToLower(); // Convertir todo a minúsculas para comparar sin considerar mayúsculas.

            int i = 0;
            int j = texto.Length - 1;

            while (i < j)
            {
                if (texto[i] != texto[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }