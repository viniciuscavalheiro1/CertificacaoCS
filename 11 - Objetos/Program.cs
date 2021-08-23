using System;

namespace _11___Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            object meuObjeto;

            meuObjeto = 10;

            meuObjeto = new Jogador();
            Console.WriteLine(meuObjeto);
            Jogador classRef;

            classRef = (Jogador)meuObjeto;
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
