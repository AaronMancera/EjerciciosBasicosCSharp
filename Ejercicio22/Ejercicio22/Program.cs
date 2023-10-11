using System;

namespace Ejercicio22
{
//  Ejercicio 22 – Sucesión de letras mayúsculas
//  Crear un programa que muestre las letras de la Z(mayúscula) a la A(mayúscula,
//  descendiendo). (pista: usa los códigos de los caracteres).
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = (int)'Z'; i >= (int)'A'; i--)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
