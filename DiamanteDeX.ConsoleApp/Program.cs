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
            x = ParteSuperiorDiamante(metade, x);

            MetadeDiamante(numero);

            x = numero - 2;
            x = ParteInferiorDiamante(metade, x);
        }

        static int ParteSuperiorDiamante(int metade, int x)
        {
            for (int i = metade; i > 0; i--)
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
            return x;
        }

        static void MetadeDiamante(int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
        }

        static int ParteInferiorDiamante(int metade, int x)
        {
            for (int i = metade; i > 0; i--)
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
            return x;
        }
    }
}