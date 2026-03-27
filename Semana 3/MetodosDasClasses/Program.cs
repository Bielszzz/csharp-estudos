using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            //Métodos Simples
            m.Cumprimentar();
            m.Somar(12, 10);
            m.Apresentar("Gabriel", 22);

            //Métodos com parâmetros
            int valor1 = 100;
            int valor2 = 100;

            //Passagem de parâmetros por valor e por referência
            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

            Console.WriteLine($"\npor valor manteve em {valor1}");
            Console.WriteLine($"por ref alterou a varivel {valor2}");

            //Métodos com retorno de valores
            m.MontaNome("Gabriel", "Oliveira"); // nao imprime nada
            Console.WriteLine(m.MontaNome("\nGabriel", "Oliveira")); // aqui acontece pois esta printando

            int codigoChar = m.CodigoChar('a');
            double pi = m.ValorPI();

            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);

            Console.WriteLine("\n" + m.Comparar(2, 1 * 2));
            Console.WriteLine(m.Comparar("biel", "Biel"));


            Console.ReadKey();  
        }
    }
}
