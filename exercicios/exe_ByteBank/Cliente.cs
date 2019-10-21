using System;

namespace exe_ByteBank {

    class Cliente {

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string senha;
        public Cliente (string Nome, string Cpf, string Email) {

            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        public bool TrocaSenha (string senha) {
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this.senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
    class ContaCorrente {

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _Saldo { get; set; }

        public ContaCorrente (int Agencia, int Numero, Cliente Titular) {

            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this._Saldo = 0;
        }
        public double Saldo {
            get { return _Saldo; }
            set { _Saldo = value; }
        }

        public bool deposito (double valor) {

            if (valor >= 0) {
                this._Saldo += valor;
                return true;
            } else {
                return false;
            }
        }

        public bool saque (double valor) {
            if (valor >= 0) {
                if (_Saldo >= valor) {
                    _Saldo -= valor;
                    return true;
                } else {
                    return false;
                }
            }
            return false;
        }
        public bool transferencia (ContaCorrente contaDestino, double valor) {
            if (this.saque (valor)) {
                contaDestino.deposito (valor);
                _Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }

    }
}