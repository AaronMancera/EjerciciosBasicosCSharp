using System;

namespace Ejercicio21
{
    class Program
    {
        //  Ejercicio 21 – Estadística de vocales
        //  Escribe un programa que lea una cadena por teclado y calcule el número de cada una de
        //  las vocales(tanto en minúscula como en mayúsculas). Intenta usar foreach y switch.
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe la cadena: ");
            string cadena = Console.ReadLine();

            foreach (char c in cadena.ToCharArray())
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        Console.WriteLine("el valor de " + c + " es de: " + (int)c);
                        break;
                }
            }
        }
    }
}
