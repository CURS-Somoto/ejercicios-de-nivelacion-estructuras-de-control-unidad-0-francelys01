/*
Ejercicio 9: Mayor de Dos Números


Dado dos números, muestra el número mayor
utilizando una estructura if

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_dos_números
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;

            Console.WriteLine("Número uno");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Número dos");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("El número " + n1 + " es el mayor");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("El número " + n2 + " es el mayor");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
            Console.ReadLine();
             
        }
    }
}

