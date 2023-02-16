using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año: ");

            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} es un año bisiesto.", year);
            }
            else
            {
                Console.WriteLine("{0} no es un año bisiesto.", year);
            }

            Console.ReadLine();
        }
    }
}
