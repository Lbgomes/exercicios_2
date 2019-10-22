using System;

namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {

            int limiteAlunos = 10;
            int limiteSalas = 10;
            Aluno[] Aluno = new Aluno[100];
            Sala[] sala = new Sala[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            // bool querSair = false;
        }
        public void CadastrarAluno (Aluno[] alunos, int totalAluno, int alunosCadastrados) {
            if (totalAluno < alunosCadastrados) {
                Console.WriteLine (" =====SENAIzinho===== ");
                System.Console.WriteLine ();
                System.Console.WriteLine ("===Cadastrar aluno===");
                System.Console.WriteLine ();
                System.Console.Write ("Nome: ");
                string nome = Console.ReadLine ();
                System.Console.Write ("Data de nascimento: ");
                DateTime dataNascimento = DateTime.Parse (Console.ReadLine ());
                
                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nome;
                novoAluno.DataNascimento = dataNascimento;

                int index = 0;
                foreach


            }
        }

        // Console.Clear ();
        // Console.WriteLine (" =====SENAIzinho===== ");
        // System.Console.WriteLine ();
        // System.Console.WriteLine ("1 - Cadastrar Aluno");
        // System.Console.WriteLine ("2 - Cadastrar Sala");
        // System.Console.WriteLine ("3 - Alocar Aluno");
        // System.Console.WriteLine ("4 - Remover Aluno");
        // System.Console.WriteLine ("5 - Verificar Salas");
        // System.Console.WriteLine ("6 - Verificar Alunos");
        // System.Console.WriteLine ("0 – Sair");
        // System.Console.WriteLine ();
        // System.Console.WriteLine ("Insira sua opção: ");
        // string opcaoUsuario = Console.ReadLine ();

        // switch (opcaoUsuario) {
        //     case "1":
        //         if (alunosCadastrados < 100) {
        //         } else {
        //             System.Console.WriteLine ("Quantidade de alunos máximos atingida");
        //         }
        //         break;

        //     case "2":

        //         Console.WriteLine (" =====SENAIzinho===== ");
        //         System.Console.WriteLine ();
        //         System.Console.WriteLine ("===Cadastrar Sala===");
        //         System.Console.WriteLine ();
        //         System.Console.WriteLine ("Insira o número da sala: ");
        //         Console.ReadLine ();
        //         System.Console.WriteLine ("Insira a quantidade de alunos que essa sala já possui: ");
        //         Console.ReadLine ();

        //         break;

        //     case "3":
        //         System.Console.WriteLine (" =====SENAIzinho===== ");
        //         System.Console.WriteLine ();
        //         System.Console.WriteLine ();
        //         System.Console.WriteLine ("===Alocar Aluno===");
        //         System.Console.WriteLine ("Insira o nome do aluno: ");
        //         Console.ReadLine ();
        //         System.Console.WriteLine ("Insira o número da sala: ");
        //         Console.ReadLine ();
        //         break;

        //     case "4":
        //         System.Console.WriteLine (" =====SENAIzinho===== ");
        //         System.Console.WriteLine ();
        //         System.Console.WriteLine ("Remover Aluno");
        //         System.Console.WriteLine ();
        //         System.Console.WriteLine ("Insira o nome do aluno: ");

        //         break;

    }
}
}