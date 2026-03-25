using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int seq = 0;

            Console.Write("Quantos valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sequência de Fibonacci com {valores} valores:");
            
            for (int i = 0; i < valores; i++)
            {
                if (i == valores - 1) Console.Write($"{num1}");
               
                else Console.Write($"{num1}, ");
                
                seq = num1 + num2;

                num1 = num2;
                num2 = seq;

            }

            Console.ReadKey();
        }
    }
}
