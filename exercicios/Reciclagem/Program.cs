using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem {
    enum MateriaisEnum : int {

        CASCALARANJA,
        COPOVIDRO,
        FOLHASUFITE,
        GARRAFAPET,
        LATAREFRIGERANTE,
        PAPELBOLO

    }
    enum LataEnum : int {
        LATAAMARELA,
        LATAAZUL,
        LATACINZA,
        LATAMARROM,
        LATAVERDE,
        LATAVERMELHA
    }

    class Program {

        static void Main (string[] args) {

            string[] itensMenuLatas = Enum.GetNames (typeof (MateriaisEnum));

            var opcoesLixo = new List<string> () {

                "   - 0             ",
                "   - 1             ",
                "   - 2             ",
                "   - 3             ",
                "   - 4             ",
                "   - 5             ",
            };

            bool opcaoSelecionada = false;
            int opcoesLixoEscolhida = 0;
            String menuBar = "==========================";
            bool querSair = false;
            int i = 0;

            Console.Clear ();
            System.Console.WriteLine (menuBar);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine ("      Seja bem-vind@      ");
            System.Console.WriteLine ("    Escolha uma formação  ");
            Console.ResetColor ();
            System.Console.WriteLine (menuBar);

        }
    }
}