using System;

namespace Ejercicio19
{
    class Program
    {
//  Ejercicio 19 – Teclas
//  Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una
//  vocal, una cifra numérica o una consonante(pista: usa un dato de tipo "char" con una
//  estructura switch).
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un caracter: ");
            char letra = char.Parse(Console.ReadLine());
            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es una vocal");
                    break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("Es un número");
                    break;
                default:
                    Console.WriteLine("Es una consonante");
                    break;
            }

        }
    }
}
