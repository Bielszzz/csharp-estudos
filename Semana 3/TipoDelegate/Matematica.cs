using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Matematica
    {
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine($"A soma é: {resultado}");
        }

        public void Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            Console.WriteLine($"A subtração é: {resultado}");
        }


    }
}
