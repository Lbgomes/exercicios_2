using System;

namespace exe_aluno
{
    public class Aluno
    {

        //propriedades

        public string nome { get; set; }
        public string curso { get; set; }

        public string cpf { get; set; }

        public string notas;

        //construtos
        public Aluno(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public Aluno(string nome, string curso, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.curso = curso;

        }



    }
}