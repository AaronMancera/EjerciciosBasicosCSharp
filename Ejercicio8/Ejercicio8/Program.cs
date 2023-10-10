using System;

namespace Ejercicio8
{
    class Program
    {
        /*
         * Ejercicio 8 - Número pares en rango
         * Genera dos números aleatorios entre 1 y 1000 y muestra por pantalla los números pares
         * que existen entre los 2 empezando siempre por el número menor. Utiliza un único bucle en
         * el código.
         */
        static void Main(string[] args)
        {
            var random = new Random();

            int numAleatorio1 = random.Next(1, 1000);
            int numAleatorio2 = random.Next(1, 1000);
            int final = Math.Max(numAleatorio1, numAleatorio2);
            int inicio = Math.Min(numAleatorio1, numAleatorio2);
            Console.WriteLine(inicio);
            Console.WriteLine(final);
            Console.ReadLine();
            for (int i = inicio; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
