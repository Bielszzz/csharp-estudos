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
            m.Cumprimentar();
            m.Somar(12, 10);
            m.Apresentar("Gabriel", 22);
            
            Console.ReadKey();  
        }
    }
}
