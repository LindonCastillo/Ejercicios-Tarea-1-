using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0, menor = 0, sumaEdad = 0;
            Console.WriteLine("|------Promedio De Edades------|");
            Console.WriteLine("Cuantas Personas son?");
            int edadCant = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < edadCant; i++)
            {
                Console.Write("Edad: ");
                int edad = Convert.ToInt16(Console.ReadLine());

                if(mayor == 0 && menor == 0)
                {
                    mayor = menor = edad;
                }

                sumaEdad += edad;

                if (edad > mayor)
                {
                    mayor = edad;
                }

                if (edad < menor)
                {
                    menor = edad;
                }
            }


            Console.WriteLine("El Promedio Es: "+sumaEdad/edadCant);

            Console.WriteLine("La Mayor Edad Es: "+mayor);
            Console.WriteLine("La Menor Edad Es: "+menor);
            Console.ReadKey();
        }
    }
}
