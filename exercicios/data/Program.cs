using System;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            int idade = 0;
           

            do{
            Console.WriteLine("Escreva o ano de seu nascimento");
            idade = int.Parse(Console.ReadLine());
            if((ano >21) ||(ano <0)){
                Console.WriteLine("Data inválida");
            }
            }
            while((ano >2021) || (ano < 0));
             idade = 2019 - idade;
            if (idade <= 2)
            {
                Console.WriteLine("Você é um recém nascido");
            }
            else if (idade >= 3 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if (idade >= 12 && idade <= 19)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else if (idade >= 12 && idade <= 19)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else if (idade >= 20 && idade <= 65)
            {
                Console.WriteLine("Você é um adulto");
            }
            else if (idade > 65)
            {
                Console.WriteLine("Você é um idoso");
            }
            
        }
    }
}

