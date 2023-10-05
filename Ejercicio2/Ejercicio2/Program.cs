using System;

namespace Ejercicio2
{
    class Program
    {
        /*
         * Ejercicio 2 - Variables de tipo cadena
         * Crea dos variables, una con el nombre de una persona y otra con el nombre de una ciudad
         * y muestra por consola, el siguiente mensaje: «Hola » <nombre> » bienvenido a » <ciudad>.
        */
        static void Main(string[] args)
        {
            String nombrePersona = "Aarón", nombreCiudad = "Sevilla";
            Console.WriteLine("Hola "+ nombrePersona + " bienvenido a "+nombreCiudad);
        }
    }
}
