using System;

namespace Ejercicio6
{
    class Program
    {
        /*
         * Ejercicio 6 - Números pares y divisibles por 3
         * Recorre los números del 1 al 100. Muestra en la consola los números pares y divisibles
         * entre 3.
         */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%2==0 && i % 3 == 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
