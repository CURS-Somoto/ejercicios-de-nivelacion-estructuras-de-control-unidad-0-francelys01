/* Ejercicio 7: Conteo Regresivo


Imprime un conteo regresivo del 10 al 1
utilizando un bucle for.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_regresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 10; a >=1; a = a-1)
            {
                Console.WriteLine(a);
                Console.ReadKey();
            
        }
    }

  }

}

