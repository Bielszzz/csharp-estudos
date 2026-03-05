using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float c, f, k;
            Console.WriteLine("### CONVERSOR DE TEMPERATURAS!! ###");
            Console.Write("Insira a temperatura em graus Celsius: ");

            c = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------");
         
            f = (c * 9 / 5) + 32;

            k = c + 273.15f;

            Console.WriteLine("temperatura em Celsius: "+c);
            Console.WriteLine("temperatura em Fahrenheit: " + f);
            Console.WriteLine("temperatura em Kelvin: " + k);
            Console.WriteLine("--------------------------------");
            Console.ReadKey();

        }
    }
}
