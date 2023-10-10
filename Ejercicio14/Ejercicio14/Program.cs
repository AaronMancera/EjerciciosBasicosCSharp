using System;

namespace Ejercicio14
{
    class Program
    {
//      Ejercicio 14 – Número mayor y menor de tres enteros dados
//      Escribe un programa que calcule el mayor y el menor de tres números enteros

        static void Main(string[] args)
        {
            int[] numeros = { 5, 2, 7 };
            int min = int.MaxValue;
            int max = 0;
            for(int i = 0; i < numeros.Length; i++) 
            {
                if (max < numeros[i])
                {
                    max = numeros[i];
                }
                if(min > numeros[i])
                {
                    min = numeros[i];
                }
            }
            Console.WriteLine("El numero mayor es: "+max+" y el minimo es: "+min);
        }
    }
}
