using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = 0;



            System.Console.WriteLine("Insira o numero da agencia");
            int agencia = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o numero da conta");
            int Numero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o nome do titular");
            Cliente Titular = Console.ReadLine();
            ContaCorrente contaCorrente = new ContaCorrente(agencia, Numero, Titular);
            System.Console.WriteLine("Insira seu saldo: ");
            do
            {
                contaCorrente.Saldo = Double.Parse(Console.ReadLine());
                if (contaCorrente.Saldo < 0)
                {
                    System.Console.WriteLine("Valor invalido");
                }
                if (contaCorrente.Saldo > 0)
                {
                    System.Console.WriteLine($"Seu saldo = {contaCorrente.Saldo}");
                }
                else
                {
                    System.Console.WriteLine("Valor do saldo deve ser positivo...");
                    System.Console.WriteLine("Insira seu saldo: ");
                }
            } while (contaCorrente.Saldo < 0);

            Console.Clear();
            System.Console.WriteLine($"Olá {Titular} Selecione a operação desejada:");
            System.Console.WriteLine();
            System.Console.WriteLine("1- Saque");
            System.Console.WriteLine("2- Deposito");
            System.Console.WriteLine("3- Transferencia");
            Console.ReadLine();








        }


    }
}


