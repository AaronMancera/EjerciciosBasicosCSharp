using System;

namespace Ejercicio18
{
    //  Ejercicio 18 – Calificaciones
    //  Escribe un programa que dada una nota numérica del uno al diez devuelva: Sobresaliente
    //  (10 ó 9), Notable(8 ó 7), Bien(6), Suficiente(5), Insuficiente(4 ó 3) o Muy Deficiente(2, 1
    //  ó 0). También se debe indicar si la nota introducida está fuera del rango.Usa una
    //  estructura switch.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe la nota: ");
            int nota = 0;
            nota = int.Parse(Console.ReadLine());
            switch (nota)
            {
                case 10:

                case 9:
                    Console.WriteLine("Sobresaliente");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                    Console.WriteLine("Insuficiente");
                    break;
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Muy deficiente");
                    break;
                default:
                    Console.WriteLine("Valor introducido fuera de rango");
                    break;
            }

        }
    }
}
