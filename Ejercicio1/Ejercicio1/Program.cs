using System;

namespace Ejercicio1
{
    class Program
    {
        /*
         * Ejercicio 1 - Variables numéricas
         * Crea 3 variables numéricas con el valor que tu quieras y en otra variable numérica para
         * guardar el valor de la suma de las 3 anteriores. Muestra el resultado por consola.
         */
        static void Main(string[] args)
        {
            //Variables a utilizar
            int num1 = 5, num2 = 10, num3 = 15, resultado;
            resultado = num1 + num2 + num3; //operacion de suma de las variables
            Console.WriteLine("El resultado es: " + resultado); //muestra el resultado
        }
    }
}
