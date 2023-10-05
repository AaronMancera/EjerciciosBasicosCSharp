using System;

namespace Ejercicio7
{
    /*
     * Ejercicio 7 - Número inversos
     * Muestre por consola lospr imeros 100 números de forma inversa, es decir, del 100 al 1.
     * Utiliza la estructura while
     */
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            while (i != 0) 
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}
