using System;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float num4 = 0;
            string oper;
            
            Console.WriteLine("Escreva a 1ª nota");
                 num1 = float.Parse(Console.ReadLine());
             Console.WriteLine("Escreva a 2ª nota");
                num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a 3ª nota");
                 num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a 4ª nota");
                 num4 = float.Parse(Console.ReadLine());
            float media = (num1 + num2 + num3 + num4) / 4;
                Console.WriteLine("Sua média é " + media);
                if(media >= 7){
                Console.WriteLine("Aprovado");
                }
                else{
                 Console.WriteLine("Reprovado");
        }
    }
}
}
