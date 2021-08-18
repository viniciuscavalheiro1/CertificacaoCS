using System;

namespace _3___Pontos_Flutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            float idade = 15.5f;

            //double massa = 6_000000_000000_000000_000000;

            float massaDaTerra = 5.9736e24f;

            double numeroMuitoMaior = 6e100;

            Console.WriteLine(numeroMuitoMaior);

            var calculo = 3 + 2.4f / 123.44444f;
            Console.WriteLine(calculo.GetType());

        }
    }
}
