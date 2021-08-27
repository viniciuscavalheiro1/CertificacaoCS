using System;

namespace _16___Metodos_de_extensão
{
    class Program
    {
        static void Main(string[] args)
        {

            Impressora impressora = new Impressora("HELOOO");
            impressora.Imprimir();
            impressora.ImprimirDocumentoHTML();

        }
    }

    class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo...");
            Console.WriteLine(Documento);
        }
    }

    static class ImpressoraExtensions
    {
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }
}
