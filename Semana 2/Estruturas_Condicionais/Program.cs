using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            if (valor == 10)
            {
                Console.WriteLine("Condicao verdadeira!");
            }

            else if (valor == 20) 
            {
                Console.WriteLine("Condicao alternativa 1");
            }

            else if (valor == 30)
            {
                Console.WriteLine("condicao alternativa 2");
            }

            else
            {
                Console.WriteLine("Condicao falsa!");
            }

            int num = 10;

            if (num > 5)
            {
                Console.WriteLine("O numero é maior que 5");

                if (num % 2 == 0)
                {
                    Console.WriteLine("O numero é par!");
                }

                else Console.WriteLine("O numero é impar!");
            }

            int numero = 10;
            string msng = "";

            msng = numero > 5 ? "numero maior que 5" : "numero menor que 5";

            Console.ReadKey();
        }
    }
}
