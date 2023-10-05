using System;

namespace Ejercicio12
{
    class Program
    {
        /*
         * Ejercicio 12 - Tabla de multiplicar
         * Escriba un array con la tabla de multiplicar de un número aleatorio entre 1 y 10. Una vez
         * generado el array muestre el mismo por consola utilizando la estructura foreach.
         */
        static void Main(string[] args)
        {
            int[] tablaDeMultiplicar = new int[10];
            var random = new Random();
            int numAleatorio = random.Next(1, 10);
            for(int i=0; i < tablaDeMultiplicar.Length; i++)
            {
                tablaDeMultiplicar[i] = (i + 1) * numAleatorio;
            }
            Console.WriteLine("La tabla del "+numAleatorio);
            foreach (int numero in tablaDeMultiplicar)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
