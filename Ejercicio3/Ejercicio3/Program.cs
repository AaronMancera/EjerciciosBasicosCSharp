using System;

namespace Ejercicio3
{
    class Program
    {
        /*
         * Ejercicio 3 - Comparación de números
         * Crea dos variables numéricas con valores distintos, no necesariamente enteros, y muestra
         * por consola que número es el mayor
         */
        static void Main(string[] args)
        {
            int menor = 1, mayor = 5;
            Console.WriteLine("El numero mayor es: "+Math.Max(menor,mayor));
        }
    }
}
