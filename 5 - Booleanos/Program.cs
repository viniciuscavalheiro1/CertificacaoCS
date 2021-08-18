using System;

namespace _5___Booleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool possuiSaldo = true;

            Console.WriteLine($"Possui saldo: {possuiSaldo}");

            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias: {dias}");

            bool diasPar = (dias % 2 == 0);

            if (diasPar == true)
            {
                Console.WriteLine(diasPar);
            }
        }
    }
}
