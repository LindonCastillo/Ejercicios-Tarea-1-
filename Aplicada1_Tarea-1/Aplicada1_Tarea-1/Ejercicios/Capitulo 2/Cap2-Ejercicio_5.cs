using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_cap2
{
    class Program
       { 

        static void Main(string[] args)
        {
            const double dolar = 50.47;
            const double euro = 56.69;

            double calculo(double Cantidad, double Moneda)
            {
                double x = Cantidad * Moneda;
                return x;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1-) Cambiar Dolar ");
            Console.WriteLine("2-) Cambiar Euro ");
            Console.WriteLine("------------------------");

            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad a cambiar: ");
            double dinero = Convert.ToDouble(Console.ReadLine());

            if (opcion == 1)
                Console.WriteLine("Pesos: " + calculo(dinero,dolar)); 
            else if(opcion == 2)
                Console.WriteLine("Pesos: " + calculo(dinero,euro));

            Console.ReadKey();
             
        }
    }
}
