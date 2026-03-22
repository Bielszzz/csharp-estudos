using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Array_unidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VETORES

            int numero = 0;

            int[] numeros = new int[5];

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            numeros[2] = 55;

            string[] nomes = { "Gabriel", "Pedro" };


            Console.WriteLine(numeros[2]);
            Console.WriteLine(nomes[1]);

        }
    }
}
