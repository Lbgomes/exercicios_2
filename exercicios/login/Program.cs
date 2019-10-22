using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string admlogin = "admin";
            string admsenha = "admin";

            Console.WriteLine("Digite seu login");
            admlogin = Console.ReadLine();
            Console.WriteLine("Digite sua Senha");
            admsenha = Console.ReadLine();

            if ((admlogin == "admin") && (admsenha == "admin"))
            {
                Console.WriteLine("Bem vindo Admin");

            }
            else
            {
                Console.WriteLine("Bem vindo usuário");

            }

        }
    }
}

