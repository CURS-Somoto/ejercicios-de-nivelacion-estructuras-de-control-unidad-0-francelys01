/* Ejercicio 6: Pare e Impar


Escribe un programa que diga si un número
es par o impar.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese número");
            int número = int.Parse(Console.ReadLine());
            if (número % 2 == 0)
            {
                Console.WriteLine("El número" + número + " es par. ");
            }
            else
            {
                Console.WriteLine("El número" + número + " es impar. ");
            }
            Console.ReadKey();
        }
    }
}
