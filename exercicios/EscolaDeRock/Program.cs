using System;
using System.Collections.Generic;
using EscolaDeRock.Interfaces;
using EscolaDeRock.Models;
namespace EscolaDeRock {


    enum FormacaoEnum : int {
        TRIO = 3,
        QUARTETO
    }

    enum InstrumentoEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    }

    enum CategoriaEnum : int {

        HARMONIA,
        PERCUSSÃO,
        MELODIA
    }
    class Program {
        static void Main (string[] args) {
            string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames (typeof (CategoriaEnum));

            var opcoesFormacao = new List<string> () {

                "   - 0                 ",
                "   - 1             "
            };
            int opcoesFormacaoSelecionada = 0;
            string menuBar = "=================================";
            bool querSair = false;
            do {
                bool FormacaoEscolhida = false;

                do {
                    Console.Clear();
                    #region Area do Menu
                    Console.Clear();
                    System.Console.WriteLine (menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine ("      Seja bem-vind@             ");
                    System.Console.WriteLine ("      Escolha uma formação       ");
                    Console.ResetColor ();
                    System.Console.WriteLine (menuBar);

                    for (int i = 0; i < opcoesFormacao.Count; i++) {
                        string titulo = itensMenuPrincipal[i];
                        if (opcoesFormacaoSelecionada == i) {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine (opcoesFormacao[opcoesFormacaoSelecionada].Replace ("-", ">").Replace (i.ToString (), titulo));
                            Console.ResetColor ();
                        } else {
                            System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), titulo));
                        }
                    }
                    var Key = Console.ReadKey (true).Key;

                    switch (Key) {

                        case ConsoleKey.UpArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                            break;

                        case ConsoleKey.DownArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                            break;

                        case ConsoleKey.Enter:
                            FormacaoEscolhida = true;
                            break;

                    }
                    Console.Clear();
#endregion
                } while (false);
            } while (!querSair);
        }
    }
}