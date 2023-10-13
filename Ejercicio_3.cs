/*Ejercicio 3: Numero primo


Escribe un
programa que determine si un número dado es primo o no.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar número : ");
            int número = int.Parse(Console.ReadLine());
            int divisor = 1, contador = 0;
            while (divisor <= número) 
            {
                if (número % divisor == 0) 
                {
                    contador++;
                }
                divisor++;
            }
            if (contador == 2)
            {
                Console.Write("El número es primo");
            }
            else
            {
                Console.WriteLine("El número no es primo");
            }
           
            Console.ReadKey();

        }
    }
}

