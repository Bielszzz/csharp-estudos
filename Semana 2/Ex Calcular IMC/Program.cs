using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Calcular_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua altura em cm: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o seu peso em kg: ");
            int peso = int.Parse(Console.ReadLine());   

            altura = altura / 100;

            double IMC = peso / (altura * altura);

            if (IMC < 20)
            {
                Console.WriteLine($"IMC: {IMC:f2} - Abaixo do Peso! ");
            }

            else if (IMC >= 20 && IMC <= 24)
            {
                Console.WriteLine($"IMC: {IMC:f2} - Peso Ideal ");
            }

            else if (IMC > 24 && IMC <= 29)
            {
                Console.WriteLine($"IMC: {IMC:f2} - Acima do Peso ");
            }

            else Console.WriteLine($"IMC: {IMC:f2} - Obeso ");


            Console.ReadKey();
        }
    }
}
