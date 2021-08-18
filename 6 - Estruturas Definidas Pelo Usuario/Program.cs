using System;

namespace _6___Estruturas_Definidas_Pelo_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            double longitude = 12.3;
            Console.WriteLine($"Lngitude: {longitude}");

            PosicaoGPS posicao1;


            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            PosicaoGPS posicao2 = new PosicaoGPS() { Latitude = 32.4, Longitude = 43.5 };

            PosicaoGPS posicao3 = new PosicaoGPS(13.4, 29.8);

            Console.WriteLine(posicao3);

            Carro carros = new Carro("Fiat", "Uno", marcas.chevrollet);

            Console.WriteLine(carros);
        }
    }

    interface IGPS 
    {
        bool EstaNoHemisferioNorte();

    }

    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }

    struct Carro
    {
        public string nome;
        public string modelo;
        public marcas marca;

        public Carro(string nome, string modelo, marcas marca)
        {
            this.nome = nome;
            this.modelo = modelo;
            this.marca = marca;
        }

        public override string ToString()
        {
            return $"Nome: {nome}, Modelo: {modelo}, Marca: {marca}";
        }

    }

    enum marcas
    {
        fiat,
        chevrollet
    }
}
