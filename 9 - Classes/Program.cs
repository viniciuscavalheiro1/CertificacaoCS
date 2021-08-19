using System;

namespace _9___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoGPS posicaoGPS = new PosicaoGPS(32.4, 32.4);

            Console.WriteLine(posicaoGPS.ToString());

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(32.4, 32.4, DateTime.Now);

            Console.WriteLine(posicao2);
        }
    }

    class PosicaoGPS
    {
        public double p1;
        public double p2;

        public PosicaoGPS(double p1, double p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public override string ToString()
        {
            return $"Posição 1: {p1}, Posição 2: {p2}";
        }
      
    }

    class PosicaoGPSComLeitura : PosicaoGPS
    {

        private readonly DateTime dataLeitura;

        public PosicaoGPSComLeitura(double p1, double p2, DateTime dataLeitura) : base(p1, p2)
        {
            this.dataLeitura = dataLeitura;
        }

        public override string ToString()
        {
            return $"Posição 1: {p1}, Posição 2: {p2}, Data Leitura: {dataLeitura}";
        }
    }
}
