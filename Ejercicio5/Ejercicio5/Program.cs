using System;

namespace Ejercicio5
{
    class Program
    {
        /*
         * Ejercicio 5 - Indicar mes
         * Genera un número aleatorio entre 1 y 12 y muestra por consola a qué mes en letras le
         * corresponde. No utilices un array para guardar los meses. Para generar un número aleatorio
         * utiliza Random.Range(int minInclusive, int maxExclusive);
         */
        static void Main(string[] args)
        {
            var random =new Random();
            int mes = random.Next(1, 12);
            //Console.WriteLine(mes);
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
            }
        }
    }
}
