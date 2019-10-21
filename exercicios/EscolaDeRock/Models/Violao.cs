using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models {
    public class Violao : InstrumentoMusical, IHarmonia {
        public bool ManterRitmo () {
                System.Console.WriteLine ("Mantendo o ritmo do Baixo");
                return true;
            }

            public bool TocarAcordes () {
                System.Console.WriteLine ("Tocando acordes do Baixo");
                return true;
            }
    }
}