using System;

namespace exe_aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno("Murilo", "525.847.818-16");
            Aluno aluno2 = new Aluno("Luiz", "161.388.718-39", "Prog1");
            Console.WriteLine(" Nome: " + aluno1.nome);
                Console.WriteLine(" Cpf: " + aluno1.cpf);
            Console.WriteLine("Curso:" + aluno1.curso);
                Console.WriteLine("------------");
            Console.WriteLine(" Nome: " + aluno2.nome);
                Console.WriteLine(" Cpf: " + aluno2.cpf);
            Console.WriteLine("Curso:" + aluno2.curso);

            Console.Write("Entre com o Nome: ");
                string nome = Console.ReadLine();
            Console.Write("Entre com o cpf: ");
                string cpf = Console.ReadLine();
            Console.Write("Entre com o curso: ");
                string curso = Console.ReadLine();
            Console.Write("Entre com o nota: ");
                int nota = int.Parse(Console.ReadLine());
            Console.Write("Insira o bimestre: ");
                int bimestre = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,cpf,curso);
            aluno3.setNotas(bimestre,nota);

            Console.WriteLine("Nota: " + aluno3.nome);
            Console.WriteLine("Cpf: " + aluno3.cpf);
            Console.WriteLine("curso: " + aluno3.curso);
            

        }
    }
}