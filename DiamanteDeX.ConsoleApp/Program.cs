using System;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "x", espaco = " ";
            int numero;

            do
            {
                Console.Write("Digite um número inteiro e ímpar:");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero % 2 == 0);
            
            int metade = (numero + 1) / 2;

            for (int i = 1; i <= numero; i++)
            {
                if (i == 1)
                {
                    for (int j = 1; j <= (metade - i); j++)
                    {
                        Console.Write(espaco);
                    }
                    Console.WriteLine(x);
                }
                else if (i <= metade)
                {
                    x += "xx";
                    for (int j = 1; j <= (metade - i); j++)
                    {
                        Console.Write(espaco);
                    }
                    Console.WriteLine(x);
                }
            }

            for (int i = 1; i <= numero; i++)
            {
                x = "x";
                if (i == numero)
                {
                    for (int m = metade; m < numero; m++)
                    {
                        Console.Write(espaco);
                    }
                    Console.WriteLine(x);
                }
                else if (i > metade)
                {
                    x += "xx";
                    for (int k = i - metade; k > 0; k--)
                    {
                        Console.Write(espaco);
                    }
                    for (int j = 2; j <= (numero - i); j++)
                    {
                        x += "xx";
                    }
                    Console.WriteLine(x);
                }
            }
        }
    }
}