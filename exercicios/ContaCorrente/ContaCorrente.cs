using System;

namespace ContaCorrente
{

    class ContaCorrente
    {



        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public ContaCorrente(int Agencia, int Numero, Cliente Titular)
        {

            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0;
        }
        class Operacoes
        {

            public double Deposito { get; set; }
            public double Transferencia { get; set; }
            public double Saque { get; set; }
            public Operacoes(double Deposito, double Transferencia, double Saque)
            {

                this.Deposito = Deposito;
                this.Transferencia = Transferencia;
                this.Saque = Saque;
            }
        }
    }
}