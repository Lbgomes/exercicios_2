using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem.Models
{
    public class GarrafaPet : Materiais, ILataVermelha
    {
        public bool Plastico()
        {
            System.Console.WriteLine("Esse item pertence a lata vermelha");
            return true;
        }
    }
}