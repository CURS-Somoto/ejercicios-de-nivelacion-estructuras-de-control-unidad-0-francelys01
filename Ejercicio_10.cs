/*
Ejercicio 10: Determinar si un Número es
Positivo, Negativo o Cero


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int número;
            Console.WriteLine("Ingrese un número");
            número = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(número + " x " + i + " = " + número * i);
            }
              Console.ReadKey();
        }
    }
