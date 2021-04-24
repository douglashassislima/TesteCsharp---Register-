using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string Registro()
        {
            Console.WriteLine("Registro - Login ");
            Console.WriteLine("1 - Registro ");
            Console.WriteLine("2 - Login ");
            Console.WriteLine("3 - Sair ");
            string inserir = Console.ReadLine();
            return inserir; 
        }
    }
}
