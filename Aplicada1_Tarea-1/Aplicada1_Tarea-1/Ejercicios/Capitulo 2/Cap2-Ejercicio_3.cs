using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grados: ");
            double grados = Convert.ToDouble(Console.ReadLine());

            double resultado = (grados * 3.14) / 180;
            Console.WriteLine("Radián: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
