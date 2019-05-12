using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine("Domingo"); break;
                case 2: Console.WriteLine("Lunes"); break;
                case 3: Console.WriteLine("Martes"); break;
                case 4: Console.WriteLine("Miercoles"); break;
                case 5: Console.WriteLine("Jueves"); break;
                case 6: Console.WriteLine("Viernes"); break;
                case 7: Console.WriteLine("Sabado"); break;
                default: Console.WriteLine("..."); break;
            }
            Console.ReadKey();
        }
    }
}
