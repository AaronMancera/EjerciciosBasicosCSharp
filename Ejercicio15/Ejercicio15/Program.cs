using System;

namespace Ejercicio15
{
    class Program
    {
//      Ejercicio 15 – Número intermedio de tres enteros dados
//      Escribe un programa que calcule el número intermedio de tres números enteros.
        static void Main(string[] args)
        {
            int[] numeros = { 5, 2, 7 };
            int min = int.MaxValue;
            int max = 0;
            int intermedio = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (max < numeros[i])
                {
                    max = numeros[i];
                }
                if (min > numeros[i])
                {
                    min = numeros[i];
                }
                
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i]!=max && numeros[i] != min)
                {
                    intermedio = numeros[i];
                }

            }
            Console.WriteLine("El numero intermedio es: " + intermedio);

        }
    }
}
