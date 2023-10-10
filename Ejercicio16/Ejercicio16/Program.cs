using System;

namespace Ejercicio16
{
    //  Ejercicio 16 – Cálculo del desglose de una cantidad en billetes
    //  Escribe un programa que dada un cantidad de euros calcule su desglose en billetes de
    //  100, 50 20, 10 y 5 euros.
    class Program
    {
        static void Main(string[] args)
        {
            string teclado = "";
            Console.WriteLine("Escribe la cantidad de dinero: ");
            teclado = Console.ReadLine();
            float dinero = float.Parse(teclado);
            int cont100 = 0, cont50 = 0, cont20 = 0, cont10 = 0, cont5 = 0;
            Console.WriteLine(dinero);
            //NOTE: Caso de billetes 100 euros
            while (dinero > 0 && dinero >= 100)
            {
                dinero -= 100;
                cont100 += 1;
            }
            if (cont100 > 0)
            {
                Console.WriteLine(cont100+" billete(s) de 100 euros");

            }
            //NOTE: Caso de billetes 50 euros
            while (dinero > 0 && dinero >= 50)
            {
                dinero -= 50;
                cont50 += 1;
            }
            if (cont50 > 0)
            {
                Console.WriteLine(cont50 + " billete(s) de 50 euros");

            }
            //NOTE: Caso de billetes 20 euros
            while (dinero > 0 && dinero >= 20)
            {
                dinero -= 20;
                cont20 += 1;
            }
            if (cont20 > 0)
            {
                Console.WriteLine(cont20 + " billete(s) de 20 euros");

            }
            //NOTE: Caso de billetes 10 euros
            while (dinero > 0 && dinero >= 10)
            {
                dinero -= 10;
                cont10 += 1;
            }
            if (cont10 > 0)
            {
                Console.WriteLine(cont20 + " billete(s) de 10 euros");

            }
            //NOTE: Caso de billetes 5 euros
            while (dinero > 0 && dinero >= 5)
            {
                dinero -= 5;
                cont5 += 1;
            }
            if (cont5 > 0)
            {
                Console.WriteLine(cont5 + " billete(s) de 5 euros");

            }
            //NOTE: Caso de que haya sobrante no recogible en billetes
            if (dinero > 0)
            {
                Console.WriteLine("Te sobran " + dinero + " que estaran en monedas");

            }
        }
    }
}
