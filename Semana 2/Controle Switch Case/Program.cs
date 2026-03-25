using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch - Case
            //Console.Write("Escolha a opção 1, 2, 3, 4 ou 5: ");
            //int escolha = int.Parse(Console.ReadLine());
            //switch (escolha)
            //{
            //    case 1:
            //        Console.WriteLine("OPCAO 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("OPCAO 2");
            //        break;

            //    case 3:
            //        Console.WriteLine("OPCAO 3");
            //        break;

            //    case 4:
            //    case 5:
            //        Console.WriteLine("OPCAO COMBINADA");
            //        break;

            //    default:
            //        return;
            //}
            #endregion

            #region goto
        Inicio: 
            Console.Write("Escolha uma opcao: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                default:
                    goto Inicio;
                    break;

                case 1:
                    valor += 100;
                    break;

                case 2:
                    valor += 50;
                    goto case 1;

            }

            Console.WriteLine($"Valor Final {valor}");
            #endregion

            Console.ReadKey();

        }
    }
}
