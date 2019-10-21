using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1° número");
            num1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite o 2º número");
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o o operador");
            oper = Console.ReadLine(); 
                   
                    if(oper == "*")
                        Console.Write($"{num1} * {num2} = {num1 * num2}");
                    
                    else if(oper == "+")
                  Console.Write($"{num1} + {num2} = {num1 + num2}");
                     
                     else if(oper == "-")
                  Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    
                     else if(oper == "/")
                  Console.Write($"{num1} / {num2} ={num1 / num2}");
                    
                     else if(oper == "%")
                 Console.Write($"{num1} % {num2} ={num1 % num2}");
                    
                    else if(oper != "%,*,/,-,+");
                    Console.Write("Escreva uma operação valida");

           
        }
    }
}
