using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Cleytu", "11 11 1111-1111","cleytusilvaoliveira@gmail.com");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}
