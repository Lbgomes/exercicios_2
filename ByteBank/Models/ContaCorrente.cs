using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models {
    public class ContaCorrente {
        public class ContaCorrente : ContaBancaria {
            public ContaCorrente (int Agencia, int NumeroConta, string Titular) : base (Agencia, NumeroConta, Titular) {

            }
        }
    }
}