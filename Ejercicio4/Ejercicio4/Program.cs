using System;

namespace Ejercicio4
{
    /*
     * Ejercicio 4 - Número aleatorio
     * Genera un número aleatorio entre 1 y 10 y muestra por consola si es par o impar. Para
     * generar un número aleatorio utiliza Random.Range(int minInclusive, int maxExclusive);
     */
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(); //se declara la clase Random a la variable random
            int numeroRandom = random.Next(1, 10);
            if (numeroRandom % 2 == 0) {
                Console.WriteLine("El numero aleatorio: " + numeroRandom +" es par");
            }
            else
            {
                Console.WriteLine("El numero aleatorio: " + numeroRandom + " es impar");
            }
        }
    }
}
