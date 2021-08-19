using System;

namespace _8___Tipos_de_Referência
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cliente1 = new Cliente("Vinicius", 22);
            var cliente2 = cliente1;
            Console.WriteLine($"Cliente1: {cliente1}");
            Console.WriteLine($"Cliente1: {cliente2}");

            cliente1.Nome = "HEAD";

            Console.WriteLine($"Cliente1: {cliente1}");
            Console.WriteLine($"Cliente1: {cliente2}");
        }
    } 

    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
