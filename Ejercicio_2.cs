/*Ejercicio 2: Suma de Dígitos


Crea un programa que calcule y muestre la
suma de los dígitos de un número ingresado por el usuario.*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_de_dos_digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.WriteLine("Ingrese un dígito");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un dígito");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("La suma es: " + c);
            Console.ReadLine();
        }
    }
}

