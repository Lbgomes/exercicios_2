using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models {
    public class ContaEspecial : ContaBancaria {
        public ContaEspecial (int Agencia, int NumeroConta, string Titular) : base (Agencia, NumeroConta, Titular) 
        {

        }
    }
}