using System;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)


        {
            bool jogadorNaoDesistiu = true;
            do
            {

                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("        Mate o Dragão      ");
                Console.WriteLine("==============================");
                System.Console.WriteLine("1 - Iniciar jogo");
                System.Console.WriteLine("0 - Sair do jogo ");
                System.Console.Write("Digite sua opção: ");
                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        
                        Guerreiro guerreiro = CriarGuerreiro();


                        Dragao dragao = new Dragao();
                        dragao.Nome = "Charizard";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;


                        /*
                        ==============================================================================================
                                                                Inicio - Primeiro Diálogo
                        ============================================================================================== */
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, seu louco! vim-lhe derrotar-lhe");
                        CriarDialogo(dragao.Nome, $" Humano tolinho. Quem pensas que és?");
                        FinalizarDialogo();


                        /* Fim - Primeiro Diálogo */

                        /* Inicio - Segundo Diálogo */
                        Console.Clear();
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! da casa {guerreiro.Sobrenome}, ó inseto asqueiroso ");
                        System.Console.WriteLine($" {guerreiro.Nome.ToUpper()}: Vim lá da {guerreiro.CidadeNatal} pra te descer o cacete!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Sua criatura ridícula, você acha mesmo que conseguirá me derrotar? ");
                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        /** 
                        ** Fim - Segundo Diálogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Inteligencia : guerreiro.Forca + guerreiro.Destreza;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine("1 - Atacar ");
                            System.Console.WriteLine("2 - Fugir ");
                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int NumeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int NumeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    int DragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > DragaoDestrezaTotal)
                                    {

                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, corno");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"Hp Dragão {dragao.Vida}");
                                        System.Console.WriteLine($"hp Guerreiro {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: errrrrrrrrrrrrrou");
                                    }

                                    break;
                                case "2":
                                    Console.Clear();
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Corre que o corno tá puto");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: FDP KKKKKKKJ");
                                    jogadorNaoDesistiu = false;
                                    break;


                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER PARA PROSEGUIR");
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoDesistiu)
                        {

                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random();
                            int NumeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int NumeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                            int DragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                            if (guerreiroDestrezaTotal < DragaoDestrezaTotal)
                            {

                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Tomou na jabiraca");
                                guerreiro.Vida -= (dragao.Forca);
                                System.Console.WriteLine($"Hp Dragão {dragao.Vida}");
                                System.Console.WriteLine($"hp Guerreiro {guerreiro.Vida}");
                            }
                            else
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: errrrrrrrrrrrrrou");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Aperte ENTER PARA PROSEGUIR");
                            Console.ReadLine();



                            Console.Clear();
                            System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine("1 - Atacar ");
                            System.Console.WriteLine("2 - Fugir ");
                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    NumeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    NumeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    DragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > DragaoDestrezaTotal)
                                    {

                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, corno");
                                        dragao.Vida -= (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"Hp Dragão {dragao.Vida}");
                                        System.Console.WriteLine($"hp Guerreiro {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: errrrrrrrrrrrrrou");
                                    }

                                    break;
                                case "2":
                                    Console.Clear();
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Corre que o corno tá puto");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: FDP KKKKKKKJ");
                                    jogadorNaoDesistiu = false;
                                    break;


                            }


                        }

                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("Morri, morri, morri, de mentirinha, mas morri");
                        }
                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Parabéns guerreiro");
                        }

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("Game Over");
                        break;
                    default:
                        System.Console.WriteLine("Comando inválido");
                        break;

                }
            } while (jogadorNaoDesistiu);

        }
        public static void CriarDialogo(string nome, string frase)
        {

            System.Console.WriteLine($"{nome.ToUpper()}: \n-{frase}");

        }

        public static void FinalizarDialogo()
        {
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER PARA PROSEGUIR");
            Console.ReadLine();
            Console.Clear();
        }

        public static Guerreiro CriarGuerreiro()
        {
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Drago";
            guerreiro.Sobrenome = "Aratog";
            guerreiro.CidadeNatal = "Ilhas do norte";
            guerreiro.DataNascimento = DateTime.Parse("25/04/500");
            guerreiro.FerramentaAtaque = "Espada";
            guerreiro.FerramentaProtecao = "Escudo";
            guerreiro.Forca = 4;
            guerreiro.Destreza = 2;
            guerreiro.Inteligencia = 2;
            guerreiro.Vida = 20;

            return  guerreiro;
        }

    }
}