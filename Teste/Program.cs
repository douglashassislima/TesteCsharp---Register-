using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string decida = Registro();
            Info[] detalhes = new Info[7];
            while (decida.ToUpper() != "X")
            {
                switch (decida)
                {
                    case "1":
                        Info pessoas = new Info();
                        Console.WriteLine("Digite seu nome: ");
                        string G = Console.ReadLine().ToUpper();
                        pessoas.Usuarios = G;
                      
                        Console.WriteLine("Digite sua senha: ");
                        string D = Console.ReadLine().ToUpper();
                        pessoas.Senha = D;
                        break;
                    case "2":
                        bool VerificacaoDeSenha = false, VerificacaoDeUsuario = false;
                        string VerifDeS, VerifUsu;
                        Console.WriteLine("Insira seu nome: ");
                        string LoginUsuario = Console.ReadLine().ToUpper();
                        foreach (var H in detalhes)
                        {
                            VerifUsu = H.Usuarios;
                            if (VerifUsu == LoginUsuario)
                            {
                                VerificacaoDeUsuario = true;
                                if(VerificacaoDeUsuario = true)
                                {
                                    Console.WriteLine("Insira sua senha: ");
                                    string LoginSenha = Console.ReadLine().ToUpper();
                                    for (int i = 0; i < detalhes.Length; i++)
                                    {
                                        if(LoginSenha == H.Senha)
                                        {
                                            VerificacaoDeSenha = true;
                                        }
                                    }
                                }
                            }
                        }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                decida = Registro();

            }
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
