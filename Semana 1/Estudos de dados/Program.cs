using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos_de_dados
{
    internal class Program
    {
        enum Notas
        {
            Minimo = 10, 
            Media = 20, 
            Maxima = 30
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Var
            var num = 10; //var assume o msm tipo de variavel, que foi declarada, pelo resto da aplicacao

            num = 22;
            #endregion

            #region obj
            object obj = false; //variaveis object é a base para todos os tipos de variaveis,
                                //pode ser mudada a qualquer momento durante a aplicacao
            obj = 100;
            obj = "eu";
            #endregion

            #region const
            const double pi = 3.1415;
            const string nome = "gabriel";
            #endregion

            #region enum
            Notas notasAlunos = Notas.Media;
            #endregion

            #region Struct
            Pessoa p1 = new Pessoa();

            p1.nome = "Gabriel";
            p1.altura = 1.74;
            p1.idade = 22;

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                idade = 20,
                altura = 1.70
            };

            p1.nome = "Eduarda";
            #endregion


            Console.WriteLine(p1.nome);
            Console.ReadKey();

        }
    }
}
