using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (a.Login(senha))
            {
                Console.WriteLine("Senha correta, Seja bem vindo!");
            }

            else Console.WriteLine("Senha incorreta!");


            Console.ReadKey();

        }
    }
}
