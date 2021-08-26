using System;

namespace _15___Argumentos_Nomeados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NomeIdade(nome: "Vinícius", idade: 22));

            Carro carro = new Carro();

            Console.WriteLine(carro.ToString());
        }

        static string NomeIdade(int idade, string nome)
        {
            return $"Nome: {nome}, Idade: {idade}";
        }
    }

    class Carro
    {
        string nome;
        int ano;

        public Carro(string nome, int ano)
        {
            this.nome = nome;
            this.ano = ano;
        }

        public Carro(string nome = "Fiat")
        {
            this.nome = nome;
        }



        public override string ToString()
        {
            return $"Nome: {nome}";
        }
    }

}
