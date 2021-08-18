using System;

namespace _7___Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            DiasDaSemana primeiroDia = DiasDaSemana.Seg;

            DiasDeTrabalho diasDeTrabalho = DiasDeTrabalho.Seg | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex;

            Console.WriteLine(diasDeTrabalho);
        }
    }

    enum DiasDaSemana : long { Seg = 2, Ter = 3, Qua = 4, Qui = 5, Sex = 6, Sab = 7, Dom = 1 };

    [Flags]
    enum DiasDeTrabalho { Seg = 2, Ter = 3, Qua = 4, Qui = 5, Sex = 6, Sab = 7, Dom = 1 };
}
