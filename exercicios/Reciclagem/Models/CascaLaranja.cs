using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class CascaLaranja : Materiais, ILataMarrom
    {
        public bool Organico()
        {
            System.Console.WriteLine("Esse item pertence a lata marrom");
            return true;
        }
    }
}