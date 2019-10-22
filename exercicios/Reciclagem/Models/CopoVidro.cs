using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class CopoVidro : Materiais, ILataVerde
    {
        public bool Vidros()
        {
            System.Console.WriteLine("Esse item pertence a lata verde");
            return true;
        }   
    }
}