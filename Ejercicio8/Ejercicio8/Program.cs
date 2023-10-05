using System;

namespace Ejercicio8
{
    class Program
    {
        /*
         * Ejercicio 8 - Número pares en rango
         * Genera dos números aleatorios entre 1 y 1000 y muestra por pantalla los números pares
         * que existen entre los 2 empezando siempre por el número menor. Utiliza un único bucle en
         * el código.
         */
        static void Main(string[] args)
        {
            var random = new Random();
            int resultado=0;
            while (resultado == 0)
            {
                int numAleatorio1 = random.Next(1, 1000);
                int numAleatorio2 = random.Next(1, 1000);
                if(numAleatorio1%2==0 && numAleatorio2 % 2 == 0)
                {
                    resultado = Math.Min(numAleatorio1, numAleatorio2);
                    //Console.WriteLine("numAleatorio1: "+numAleatorio1+" - numAleatorio2: "+ numAleatorio2);

                }
                else if (numAleatorio1 % 2 == 0)
                {
                    resultado = numAleatorio1;
                    //Console.WriteLine("numAleatorio1: " + numAleatorio1);
                }
                else if(numAleatorio2%2 == 0)
                {
                    resultado = numAleatorio2;
                    //Console.WriteLine("numAleatorio2: " + numAleatorio2);
                }

            }
            Console.WriteLine(resultado);
        }
    }
}
