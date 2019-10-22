using System;

namespace McBonalds
{
    public class Cliente
    {
        //propriedades

        public string Nome;  //Nome do cliente
        public string Endereco;  //Endereço do cliente
        public string Telefone;  //Telefone do cliente
        public string Senha;  //Senha do cliente
        public string Email;  //Email do cliente
        public DateTime DataNascimento;  //Data de nascimento do cliente

        //construtor

        public Cliente(string Nome, string telefone, string Email)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;

        }

    }
}