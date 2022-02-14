using System;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, espaco, x = 1;

            do
            {
                Console.Write("Digite um número inteiro e ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero % 2 == 0);

            espaco = (numero - 1) / 2;

            for (int i = espaco; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= x; k++)
                {
                    Console.Write("x");
                }
                x += 2;
                Console.WriteLine();
            }
            



        }
    }
}