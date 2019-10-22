using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;


namespace Reciclagem.Models
{
    public class PapelBolo : Materiais, ILataCinza
    {
        public bool Indefinido()
        {
            System.Console.WriteLine("Esse item pertence a lata cinza");
            return true;
        }
    }
}