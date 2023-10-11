using System;
using System.Collections;

namespace Ejercicio24
{
    class Program
    {
//  Ejercicio 24 – Cifras de un número
//  Crear un programa calcule cuantas cifras tiene un número entero positivo(pista: se puede
//  hacer dividiendo varias veces entre 10).
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero");
            int num = int.Parse(Console.ReadLine());
            int numEntero = num;
            var numeroSeparados = new ArrayList();
            while (num > 0)
            {
                num=num / 10;
                numeroSeparados.Add(num);
            }
            Console.WriteLine("Tiene "+numeroSeparados.Count+" caracteres");
        }
    }
}
