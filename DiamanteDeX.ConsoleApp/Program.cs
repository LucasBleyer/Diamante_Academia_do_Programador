using System;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Digite um número inteiro e ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero % 2 == 0);

            int metade = (numero - 1) / 2;

            int x = 1;
            for (int i = metade; i > 0; i--)
            {

                for (int espaco = 1; espaco <= i; espaco++)
                {
                    Console.Write(" ");
                }

                for (int letra_x = 1; letra_x <= x; letra_x++)
                {
                    Console.Write("x");
                }
                x = x + 2;
                Console.WriteLine();

            }

            for (int i = 0; i < numero; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();

            x = numero - 2;
            for (int i = metade; i > 0; i--)
            {
                for (int espaco = i; espaco <= metade; espaco++)
                {
                    Console.Write(" ");
                }
                for (int letra_x = 0; letra_x < x; letra_x++)
                {
                    Console.Write("x");
                }
                x = x - 2;
                Console.WriteLine();
            }

        }
    }
}