using System;

namespace CertificacaoCS
{
    class Program
    {
        static void Main(string[] args)


        {
            int idade;
            idade = 100;
            int copiaIdade = idade;

            Console.WriteLine($"Idade = {idade}");
            
            if(idade > 10)
            {
                Console.WriteLine($"Idade cópia maior que 10 = {copiaIdade}");
            }
            int? idade2 = null;
            System.Nullable<int> idade3 = n ull;

            idade = 'a';
            Console.WriteLine($"Idade = {idade}");
        }
    }
}
