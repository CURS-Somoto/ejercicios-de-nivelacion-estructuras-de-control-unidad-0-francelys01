/*Ejercicio 5: Positivo o negativo


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int número = int.Parse(Console.ReadLine());
            if (número == 0)
            {
                Console.Write("El número " + número + " es un número neutro");
            }
            else if (número > 0)
            {
                Console.Write("El número " + número + " es un número positivo");
            }
            else
            {
                Console.Write("El número " + número + " es un número negativo");
            }
            Console.ReadKey();

        }
    }
}
