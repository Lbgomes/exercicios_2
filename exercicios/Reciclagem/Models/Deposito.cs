using System;
using Reciclagem.Models;
using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Deposito
    {
    public static Dictionary<int, Materiais> materiais = new Dictionary<int, Materiais>()
    {
            {0, new PapelBolo() },
            {1, new FolhaSufite() },
            {2, new LataRefrigerante()},
            {3, new CascaLaranja() },
            {4, new GarrafaPet() },
            {5, new CopoVidro()}

    };
    }
}