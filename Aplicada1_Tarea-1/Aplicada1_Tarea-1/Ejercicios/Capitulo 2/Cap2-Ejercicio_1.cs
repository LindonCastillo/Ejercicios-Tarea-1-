using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lado: ");
            int lado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Longitud: ");
            double longitud = Convert.ToDouble (Console.ReadLine());

            double resultado = lado * longitud;
            Console.Write("Resultado: ");
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}
