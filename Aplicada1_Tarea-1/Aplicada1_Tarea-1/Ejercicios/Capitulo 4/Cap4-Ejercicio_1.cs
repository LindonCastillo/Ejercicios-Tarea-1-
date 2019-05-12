using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_1_cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CUAL TABLA QUIERE VER?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i= 0; i<10; i++)
            {
                Console.WriteLine(num + "X" + (i + 1) + "=" + (num * (i + 1)));
            }
            Console.ReadKey();
        }
    }
}
