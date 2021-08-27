using System;

namespace _17___Sobrecarga_de_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }

    }
}
