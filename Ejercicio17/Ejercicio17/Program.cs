using System;

namespace Ejercicio17
{
    class Program
    {
        //      Ejercicio 17 – Tipo de triangulo
        //      Escribe un programa que dados tres números correspondientes a las longitudes de los
        //      tres lados de un triángulo indique si el triángulo es equilátero, isósceles o escaleno.
        static void Main(string[] args)
        {
            int l1 = 0, l2 = 0, l3 = 0;
            Console.WriteLine("Escribe en l1:");
            l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe en l2:");
            l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe en l3:");
            l3 = int.Parse(Console.ReadLine());
            if (l1 == l2 && l2 == l3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                Console.WriteLine("Es un triangulo isoscele");
            }
            else
            {
                Console.WriteLine("Es un triangulo escaleno");
            }

        }
    }
}
