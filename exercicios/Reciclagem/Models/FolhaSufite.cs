using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class FolhaSufite : Materiais, ILataAzul
    {
        public bool Papeis()
        {
            System.Console.WriteLine("Esse item pertence a lata Azul");
            return true;
        }
    }
}