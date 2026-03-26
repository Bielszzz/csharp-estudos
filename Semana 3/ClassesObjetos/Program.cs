using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse m3 = new OutraClasse();
            //OutraClasse m4 = m3;
            #endregion

            Pessoa  p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.sobrenome = "Oliveira";
            p1.anoNascimento = 2003;

            Pessoa p2 = new Pessoa()
            {
                nome = p1.nome,
                sobrenome = "Rodrigues",
                anoNascimento = 2005
            };

            Console.WriteLine($"Pessoa 1: {p1.nome}");
            Console.WriteLine($"Pessoa 1: {p1.sobrenome}");
            Console.WriteLine($"Pessoa 1: {p1.anoNascimento}");
            p1.Cumprimentar();

            Console.WriteLine($"\nPessoa 2: {p2.nome}");
            Console.WriteLine($"Pessoa 2: {p2.sobrenome}");
            Console.WriteLine($"Pessoa 2: {p2.anoNascimento}");
            p2.Cumprimentar();


            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
}
