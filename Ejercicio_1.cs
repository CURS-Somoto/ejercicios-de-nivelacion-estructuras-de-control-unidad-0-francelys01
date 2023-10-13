/*Ejercicio 1: Impresión de Números Pares


Escribe un programa
que muestre los números pares del 2 al 20. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 20; i = i + 2)
            {

                Console.WriteLine(i);
            }
            Console.Read();
        
        }
    }
}
