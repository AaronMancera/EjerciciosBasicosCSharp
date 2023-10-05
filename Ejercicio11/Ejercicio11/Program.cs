using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [10];
            var random = new Random();
            int sumaDeLosNumeros=0;
            int numMax = 0;
            int numMin = 101;
            for(int i = 0; i < 10; i++)
            {
                numeros[i] = random.Next(1, 100);
            }
            foreach(int numero in numeros)
            {
                numMax = Math.Max(numMax, numero);
                numMin = Math.Min(numMin, numero);
                sumaDeLosNumeros += numero;
            }

            Console.WriteLine("La suma de todos los numeros es: "+sumaDeLosNumeros);
            Console.WriteLine("El máximo: "+numMax);
            Console.WriteLine("El minimo: " + numMin);

        }
    }
}
