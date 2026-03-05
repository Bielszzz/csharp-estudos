using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores matematicos
            int num1 = 10;
            int num2 = 2;

            // int resultado = num1 + num2;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);
            #endregion

            #region Incremente e decremento
            int num3 = 10;

            //num3 = num3 + 1;
            //num3++;
            //++num3;
            //--num3;
            //num3--;

            //Console.WriteLine(num3++);
            //Console.WriteLine(num3);
            #endregion

            #region Operadores de atribuicao

            int num4 = 10;

            //num4 = num4 + 20;
            num4 += 20;
            num4 *= 2;

            #endregion

            #region Operadores de Igualdade

            bool res = 100 == 10*10;
            bool res2 = 200 != 200;

            #endregion

            #region Operadores Logicoss
            bool res3 = 100 > 50;
            bool res4 =  200 == 2000;

            bool final = res3 && res4;
            #endregion


            Console.WriteLine(final);
            Console.ReadKey();

        }
    }
}
