using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao conta = null;

            
            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Somar;
            conta(10, 20);

            Console.WriteLine();

            conta -= m.Subtrair;
            conta -= m.Somar;

            conta(15, 3);
            Console.ReadKey();
        }
    }
}
