using System;

namespace _2___Tipos_Inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 15;

            char resposta = 'S'; //System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal

            short passageirosVoo = 230;

            Console.WriteLine(passageirosVoo);

            passageirosVoo = -4;

            Console.WriteLine(passageirosVoo);

            int populacao = 1500;

            long populacaoDoBrasil = 207_660_929;

            sbyte nivelDeBrilho = -127;
            ushort passageirosNavio = 230;

            uint estoque = -2300;
            Console.WriteLine($"Estoque: {estoque}");

        }
    }
}
