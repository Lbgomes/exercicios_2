using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = 0;
            double porcento = 0.3;
            double resultado = porcento * salario;

             Console.WriteLine("Digite o valor do salário");
            salario = float.Parse(Console.ReadLine());

            if(salario >= 500){
                Console.WriteLine("Você não pode receber um aumento");
            }
            else {

               Console.Write("O seu salário será:" + resultado);
          
            }
        }
    }
}
