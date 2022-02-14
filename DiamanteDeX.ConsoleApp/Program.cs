using System;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metade_diamante_cima_pra_baixo = "";
            int numero;
            do
            {
                Console.Write("Digite um número ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero % 2 == 0);

            for (int i = 0; i < numero / 2; i++)
            {
                for (int j = 0; j < numero / 2; j++)
                {
                    metade_diamante_cima_pra_baixo += "x";
                }
                metade_diamante_cima_pra_baixo += "\n";
            }

        }
    }
}