using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Array_bidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Matriz
            // MATRIZ - o primeiro numero, dos colchetes, representa a linha e o segundo a coluna
            int[,] numeros = new int[2, 3];
            
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");
            Console.WriteLine();
            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.WriteLine("[" + numeros[1, 2] + "]");


            string[,] nomes = 
            {
                {"Gabriel", "Pedro", "Bruno" },
                {"Eduarda", "Maria", "Joao" }
            };

            Console.WriteLine(nomes[0,1]);
            #endregion

            // EXERCICIO:
            // multiplicacao de matrizes se faz multiplicando a linha, pela coluna de outra matriz, gerando o valor em uma nova matriz

            int[,] matriz1 = new int [2,3];
            int[,] matriz2 = new int [3,2];

            int[,] resultado = new int [2,2];

            Console.WriteLine("Preencha a matriz 1");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0;  coluna < 3 ; coluna++)
                {
                    Console.Write($"M1 - posição: [{linha}][{coluna}]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencha a matriz 2");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0;coluna < 2 ; coluna++)
                {
                    Console.Write($"M2 - posição: [{linha}][{coluna}]: ");
                    matriz2[linha, coluna] = int.Parse (Console.ReadLine());
                }
                        
            }

            Console.WriteLine("\nResultado da matriz 1 x matriz2");



            resultado[0, 0] = matriz1[0, 0] * matriz2[0, 0] + matriz1[0, 1] * matriz2[1, 0] + matriz1[0, 2] * matriz2[2, 0];
            resultado[1, 0] = matriz1[1, 0] * matriz2[0, 0] + matriz1[1, 1] * matriz2[1, 0] + matriz1[1, 2] * matriz2[2, 0];
            resultado[0, 1] = matriz1[0, 0] * matriz2[0, 1] + matriz1[0, 1] * matriz2[1, 1] + matriz1[0, 2] * matriz2[2, 1];
            resultado[1, 1] = matriz1[1, 0] * matriz2[0, 1] + matriz1[1, 1] * matriz2[1, 1] + matriz1[1, 2] * matriz2[2, 1];

            Console.Write($"[{resultado[0, 0]}]");
            Console.Write($"[{resultado[0, 1]}]");
            Console.WriteLine();
            Console.Write($"[{resultado[1, 0]}]");
            Console.Write($"[{resultado[1, 1]}]");

            Console.ReadKey();
        }
    }
}
