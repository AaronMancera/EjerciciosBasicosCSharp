using System;

namespace Ejercicio23
{
    class Program
    {
        //  Ejercicio 23 – Comprobar si un número es primo
        //  Escribe un programa que calcule si un número entero es primo(solo es divisible entre 1 y
        //  entre él mismo).
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero: ");
            int num = int.Parse(Console.ReadLine());
            bool primo = true;
            for (int i = 2; i < num && primo != false; i++)
            {
                if ((num % i) == 0)
                {
                    primo = false;
                }

            }
            if (primo)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");

            }
        }
    }
}
