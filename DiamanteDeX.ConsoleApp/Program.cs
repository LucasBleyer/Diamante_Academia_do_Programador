using System;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //entrada
            int n;
            do
            {
                Console.Write("Digite um número inteiro e ímpar: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n % 2 == 0);

        //processamento e saída
            int metade = (n - 1) / 2;

            int x = 1;
            for (int i = metade; i > 0; i--)//ponta de cima do diamante
            {
                for (int j = 1; j <= i; j++)
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

            for (int i = 0; i < n; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();

            x = n - 2;
            for (int i = metade; i > 0; i--)//ponta de baixo do diamante
            {
                for (int j = i; j <= metade; j++)
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