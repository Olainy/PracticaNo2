using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.EjercicioNo._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la primera fecha (dd/mm/yyyy): ");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la segunda fecha (dd/mm/yyyy): ");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());

            TimeSpan difFechas = fecha2.Subtract(fecha1);
            int semanas = difFechas.Days / 7;

            Console.WriteLine("La cantidad de semanas entre las dos fechas es: " + semanas);

            Console.ReadLine();
        }
    }


}
