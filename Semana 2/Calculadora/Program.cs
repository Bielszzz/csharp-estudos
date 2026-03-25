using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Escolha a opção (+ - x /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("OPCAO INVÁLIDA! ");
                    break;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case 'X':
                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case ':':
                case '/':

                    if ( num2 == 0 )
                    {
                        Console.WriteLine("Não é possivel dividir por 0");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }                       
                    break;

            }

            Console.Write("Continuar calculando? (s / n): ");
            string opcao = Console.ReadLine().ToLower();

            if (opcao == "s") goto Inicio;
            else return;



            

        }
    }
}
