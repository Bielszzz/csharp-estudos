using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversao Explicita
            float num1 = 10.4f;

            int num2 = (int)num1;

            // Console.WriteLine(num2);
            #endregion

            #region Metodo Parse
            string txtnumero = "1985";

            int numero = int.Parse(txtnumero);

            byte num3 = byte.Parse("120");
            #endregion

            #region Class Convert
            string texto = Convert.ToString(2500);
            #endregion

            Console.WriteLine(texto);
            Console.ReadKey();

        }
    }
}
