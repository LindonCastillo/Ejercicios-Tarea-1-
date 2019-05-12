using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grados °C: ");
            double gradosC = Convert.ToDouble(Console.ReadLine());
            double resultado = (gradosC *9/5) + 32;
            Console.WriteLine("Grados °F: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
