using System;

namespace _15___ParametrosOpcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ImprimeDetalheDoPedido(1, pizza, Vinícius));
        }
    }


    public string ImprimeDetalheDoPedido(int id, string nome, string vendedor) 
    {
        return $"ID VENDA: {id}, Nome: {nome}, Vendedor: {vendedor}";
    }
}
