using System;

namespace _14___Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(10, 20);

            Console.WriteLine(retangulo.GetArea());
            retangulo.GetAreaAoQuadrado(retangulo);
        }
    }

    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"Altura: {altura}, Largura: {largura}");

            var area = GetArea();
            Console.WriteLine($"Area: {area}");
        }

        internal double GetArea()
        {
            return Altura * Largura;
        }

        public Retangulo GetAreaAoQuadrado(Retangulo retangulo)
        {
            double dobroRetanguloLargura;
            double dobroRetanguloAltura;
            dobroRetanguloAltura = retangulo.Altura * 2;
            dobroRetanguloLargura = retangulo.Largura * 2;

            Retangulo novoRetangulo = new Retangulo(dobroRetanguloAltura, dobroRetanguloLargura);

            return novoRetangulo;
        }
    }
}
