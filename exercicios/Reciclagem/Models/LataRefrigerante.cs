using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem.Models {
    public class LataRefrigerante : Materiais, ILataAmarela

    {
            public bool Metais()
            {
                System.Console.WriteLine("Esse item pertence a lata Amarela");
                return true;
            }
    }
}