using System;

namespace Ejercicio20
{
    class Program
    {
        //  Ejercicio 20 – Suma de números pares y números impares
        //  Escribe un programa que lea un número entero y calcule la suma de los números pares
        //  desde cero al número y la suma de los número impares desde cero al número.
        static void Main(string[] args)
        {
            Console.WriteLine("Numero:");
            int num = int.Parse(Console.ReadLine());
            int sumaPar = 0, sumaImpar = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    sumaPar += i;
                }
                else
                {
                    sumaImpar += i;
                }
            }
            Console.WriteLine("Suma numeros pares: "+sumaPar);
            Console.WriteLine("Suma numeros impares: "+sumaImpar);
        }
    }
}
