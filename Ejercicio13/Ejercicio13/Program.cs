using System;

namespace Ejercicio13
{
    class Program
    {
        /*
         * Ejercicio 13 – Funciones básicas de la librería Math
         * Escribe un programa que pida un número decimal por consola (usa los métodos
         * Console.Readline() y float.Parse()) y calcule: cuadrado, raíz cuadrada, parte entera, valor
         * redondeado e indique si el número es menor o mayor que 50. 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número:");
            string teclado = "";
            teclado = Console.ReadLine();
            teclado=teclado.Replace(".", ",");
            Console.WriteLine("El cuadrado es: " + Math.Pow(float.Parse(teclado), 2));
            Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(float.Parse(teclado)));
            string[] tecladoSplit = teclado.Split(",");
            //Math.Truncate(float.Parse(teclado)); //Utilizando el metodo de math
            Console.WriteLine("La parte entera es: " + tecladoSplit[0]);
            Console.WriteLine("El redondeo es: " + Math.Round(float.Parse(teclado)));
            if (float.Parse(teclado) < 50)
            {
                Console.WriteLine("El numero " + teclado + " es menor que 50");

            }
            else if (float.Parse(teclado) > 50)
            {
                Console.WriteLine("El numero " + teclado + " es mayor que 50");

            }
            else
            {
                Console.WriteLine("El numero " + teclado + " es igual que 50");
            }

        }
    }
}
