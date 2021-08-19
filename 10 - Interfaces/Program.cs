using System;

namespace _10___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IEletroDomestico lampada = new Lampada();
            lampada.ligar();

            IPotencia lampada2 = new Lampada();
            lampada2.whats = 13.3;

            Console.WriteLine(lampada2.ToString());
            
        }
    }

    interface IPotencia 
    {
        double whats { get; set; }
    }
    interface IEletroDomestico
    {
        void ligar()
        {
            Console.WriteLine("LIGOU!");
        }

        void desligar()
        {

        }
    }

    class Lampada : IEletroDomestico, IPotencia
    {
        public double whats { get; set; }

        void ligar()
        {

        }

        void desligar()
        {

        }
    }


    class Televisao : IEletroDomestico
    {
        void ligar()
        {

        }

        void desligar()
        {

        }
    }
}
