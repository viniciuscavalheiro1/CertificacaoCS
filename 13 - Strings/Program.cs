using System;

namespace _13___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Bom dia";
            string b = "B";

            b = b + "om dia";

            Console.WriteLine(a);
            Console.WriteLine(a == b);
            Console.WriteLine((object)a == (object)b);

            string bomDia = "Bom dia";

            Console.WriteLine($"Bom dia {bomDia[4]}");
        }
    }
}
