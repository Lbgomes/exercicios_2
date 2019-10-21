using System;

namespace exe_ByteBank {
    class Program {
        static void Main (string[] args) {

            Console.Clear ();
            System.Console.WriteLine ("---ByteBank---");

            bool trocaSenha = false;
            bool deposito = false;
            bool saque = false;
            bool transferencia = false;

            System.Console.WriteLine ("Insira seu nome:");
            string Nome = Console.ReadLine ();
            System.Console.WriteLine ("Insira seu Cpf:");
            string Cpf = Console.ReadLine ();
            System.Console.WriteLine ("Insira seu Email:");
            string Email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (Nome, Cpf, Email);

            do {
                System.Console.WriteLine ("Senha:");
                string senha = Console.ReadLine ();
                trocaSenha = cliente1.TrocaSenha (senha);
                if (trocaSenha) {
                    System.Console.WriteLine ("Senha alterada com sucesso!");
                } else {
                    System.Console.WriteLine ("Senha invalida");
                }

            } while (!trocaSenha);

            System.Console.WriteLine ("Insira o numero da agencia");
            int agencia = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Insira o numero da conta");
            int Numero = int.Parse (Console.ReadLine ());

            ContaCorrente ContaCorrente = new ContaCorrente (agencia, Numero, cliente1);
            // System.Console.WriteLine("Insira seu saldo: ");
            // do
            // {
            //     ContaCorrente.Saldo = Double.Parse(Console.ReadLine());
            //     if (ContaCorrente.Saldo < 0)
            //     {
            //         System.Console.WriteLine("Valor invalido");
            //     }
            //     if (ContaCorrente.Saldo > 0)
            //     {
            //         System.Console.WriteLine($"Seu saldo = {ContaCorrente.Saldo}");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Valor do saldo deve ser positivo...");
            //         System.Console.WriteLine("Insira seu saldo: ");
            //     }
            // } while (ContaCorrente.Saldo < 0);
            // System.Console.WriteLine();

            Cliente cliente2 = new Cliente ("Cesar", "123.123.123-45", "1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente (123, 123, cliente2);

            #region Depósito
            Cliente Usuario = ContaCorrente.Titular;
            Console.WriteLine ("ByteBank - Depósito em conta");
            Console.WriteLine ($"Bem vindo - {Usuario.Nome}");
            Console.WriteLine ($"Agência - {ContaCorrente.Agencia} conta: {ContaCorrente.Numero}");
            Console.WriteLine ($"Saldo: {ContaCorrente.Saldo}");
            Console.WriteLine ();
            Console.WriteLine ("Digite o valor do depósito: ");
            double valor = double.Parse (Console.ReadLine ());
            ContaCorrente.deposito (valor);
            Console.WriteLine ();
            Console.WriteLine ($"Novo saldo: {ContaCorrente.Saldo}");
            Console.WriteLine ();
            #endregion

            #region  Saque
            
                Console.Clear ();

                Console.Write ("Qual o valor do Saque? ");
                valor = double.Parse (Console.ReadLine ());
                if (ContaCorrente.saque (valor)) {
                    Console.WriteLine ("Saque realizado com sucesso. Retire as notas");
                } else {
                    Console.WriteLine ("Não foi possivel realizar a operação");
                }
                Console.WriteLine ($"Novo saldo: {ContaCorrente.Saldo}");

                #endregion

                #region Transferência
                Console.WriteLine ("ByteBank - Transferência");
                Console.WriteLine ($"Bem vindo - {Usuario.Nome}");
                Console.WriteLine ($"Agência - {ContaCorrente.Agencia} conta: {ContaCorrente.Numero}");
                Console.WriteLine ($"Saldo: {ContaCorrente.Saldo}");
                Console.WriteLine ();
                Console.WriteLine ("Digite o valor da transferência: ");
                valor = double.Parse (Console.ReadLine ());
                if (ContaCorrente.transferencia (contaCorrente2, valor)) {
                    Console.WriteLine ("Transferência efetuada.");
                } else {
                    Console.WriteLine ("Não foi possível realizar a operação.");
                }

                Console.WriteLine ();
                Console.WriteLine ($"Novo saldo Origem: {ContaCorrente.Saldo}");
                Console.WriteLine ($"Novo saldo Destino: {contaCorrente2.Saldo}");
                Console.WriteLine ();
                #endregion

        }

    }
}