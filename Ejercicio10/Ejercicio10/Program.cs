using System;

namespace Ejercicio10
{
    class Program
    {
        /*
         * Ejercicio 10 - Ciudades
         * Escribe un array de ocho ciudades de España. Muestre el array por consola utilizando la
         * estructura foreach y a continuación muestre una ciudad al azar.
         */
        static void Main(string[] args)
        {
            string[] ciudades = { "Madrid", "Barcelona", "Valencia", "Sevilla", "Zaragoza", "Málaga", "Murcia", "Palma de Mallorca", "Las Palmas de Gran Canaria", "Bilbao" };
            Console.WriteLine("Estructura del array");
            foreach (string ciudad in ciudades)
            {
                Console.WriteLine(ciudad);

            }
            var random = new Random();
            Console.WriteLine("La ciudad aleatoria es: "+ciudades[random.Next(ciudades.Length)]);
        }
    }
}
