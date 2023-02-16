using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDiscos = 3; // Número de discos
            SolucionarTorreHanoi(numeroDiscos, 'A', 'C', 'B'); // Llamada a la función recursiva

            Console.ReadLine();
        }

        static void SolucionarTorreHanoi(int n, char desde, char hacia, char auxiliar)
        {
            if (n == 1)
            {
                Console.WriteLine("Mover disco 1 de la torre " + desde + " a la torre " + hacia);
            }
            else
            {
                SolucionarTorreHanoi(n - 1, desde, auxiliar, hacia);
                Console.WriteLine("Mover disco " + n + " de la torre " + desde + " a la torre " + hacia);
                SolucionarTorreHanoi(n - 1, auxiliar, hacia, desde);

                Console.ReadLine();
            }
            
        }
    }
    
}