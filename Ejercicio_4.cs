/*Ejercicio 4: Serie factorial


Crea un programa que genere y muestre el
resultado factorial de un numero. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial de " + num + " es " + factorial);
            Console.ReadLine();
        }
    }
}

