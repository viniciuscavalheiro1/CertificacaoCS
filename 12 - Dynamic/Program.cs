using System;

namespace _12___Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object objeto = 1;

            dynamic dinamico = 1;

            dinamico = dinamico + 3;

            Console.WriteLine(dinamico);
        }
    }
}
