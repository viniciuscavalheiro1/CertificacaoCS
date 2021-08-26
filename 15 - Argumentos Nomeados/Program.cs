using System;

namespace _15___Argumentos_Nomeados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NomeIdade(nome: "Vinícius", idade: 22));
        }

        static string NomeIdade(int idade, string nome)
        {
            return $"Nome: {nome}, Idade: {idade}";
        }
    }

}
