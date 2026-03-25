using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo while
            //int valor = 0;

            //while (valor < 10)
            //{
            //    Console.WriteLine($"valor: {valor}");
            //    valor ++;
            //}
            #endregion

            #region Ciclo do-while
            //int num;
            //do
            //{
            //    Console.Write("Digite o valor de num: ");
            //    num = int.Parse(Console.ReadLine());
            //} while (num < 10);
            #endregion

            #region Ciclo for

            //for (int i = 0, j = 5; i < 10; i++, j--)
            //{
            //    Console.WriteLine($"i = {i} | j = {j}");
            //}

            #endregion

            #region foreach

            string[] nomes = { "Gabriel", "Eduarda", "Lucas", "João" };

            int id = 1;

            foreach (var item in nomes)
            {
                Console.WriteLine($"Nome: {item} ID: {id}");
                id++;
            }

            #endregion
        }
    }
}
