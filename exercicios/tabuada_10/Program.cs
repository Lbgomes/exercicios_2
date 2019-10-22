using System;

namespace tabuada_10
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int num = 0; num < 11; num *= 1)
            {
               Console.WriteLine($"{num} * 1 = {num}");
               Console.WriteLine($"{num} * 2 = {num}");
               Console.WriteLine($"{num} * 3 = {num}");
               Console.WriteLine($"{num} * 4 = {num}");
               Console.WriteLine($"{num} * 5 = {num}");
               Console.WriteLine($"{num} * 6 = {num}");
               Console.WriteLine($"{num} * 7 = {num}");
               Console.WriteLine($"{num} * 8 = {num}");
               Console.WriteLine($"{num} * 9 = {num}");
               Console.WriteLine($"{num} * 10 = {num}");
            }
        }
    }
}
