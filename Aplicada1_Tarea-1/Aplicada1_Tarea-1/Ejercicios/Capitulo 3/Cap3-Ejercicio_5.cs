using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;
            double longitud, apotema, resultado;
            Console.WriteLine("|-------MENU-------|");
            Console.WriteLine("1.Area ");
            Console.WriteLine("2.Perimetro");
            Console.WriteLine("|------------------|");

            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Lado: ");
                    lado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Longitud: ");
                    longitud = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Apotema: ");
                    apotema = Convert.ToDouble(Console.ReadLine());
                    resultado = longitud*lado*apotema;
                    Console.Write("EL AREA: ");
                    Console.WriteLine(resultado);
                    break;

                case 2:
                    Console.WriteLine("Lado: ");
                    lado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Longitud: ");
                    longitud = Convert.ToDouble(Console.ReadLine());

                    resultado = lado * longitud;
                    Console.Write("EL PERIMETRO: ");
                    Console.WriteLine(resultado);
                    break;
                default: Console.WriteLine("..."); break;
            }
            Console.ReadKey();
        }
    }
}
