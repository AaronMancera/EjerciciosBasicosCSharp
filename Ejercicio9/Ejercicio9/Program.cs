using System;

namespace Ejercicio9
{
    class Program
    {
        /*
         * Ejercicio 9 - Indicar día a partir de array
         * Genera un array con los días de la semana. A continuación genera un número aleatorio
         * entre 1 y 7 y muestra por pantalla a qué día en letras le corresponde. Para generar un
         * número aleatorio utiliza Random.Range(int minInclusive, int maxExclusive);
         */
        static void Main(string[] args)
        {
            string[] diasSemanas = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};
            var random = new Random();
            Console.WriteLine("El dia de la semana es: "+diasSemanas[random.Next(diasSemanas.Length)]);
        }
    }
}
