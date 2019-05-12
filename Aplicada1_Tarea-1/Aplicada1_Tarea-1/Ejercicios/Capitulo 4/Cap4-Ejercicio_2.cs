using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dijite Un Numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dijite Una Potencia");
            int potencia = Convert.ToInt32(Console.ReadLine());
            double resultado=1;
            for (int i = 0; i < potencia; i++)
            {
                resultado *= num;
            }

            Console.Write("Resultado: ");
            Console.Write(resultado);
            Console.ReadKey();
        }


    }
}
