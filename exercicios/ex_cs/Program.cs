using System;

namespace ex_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Murilo","525.847.818-16");
            Aluno aluno2 = new Aluno("Luiz","161.388.718-39", "Prog1");
            Console.WriteLine(" Nome: " + aluno1.Nome);               
            Console.WriteLine(" Cpf: " + aluno1.Cpf);   
            Console.WriteLine("Curso:" + aluno1.Curso);          

              Console.WriteLine(" Nome: " + aluno2.Nome);               
            Console.WriteLine(" Cpf: " + aluno2.Cpf);   
            Console.WriteLine("Curso:" + aluno2.Curso);
        }
    }
}
