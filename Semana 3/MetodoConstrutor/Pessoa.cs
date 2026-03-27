using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            nome = "Desconhecido";
            sobrenome = "Nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobrenome, int anoNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            idade = Idade(); // sobrecarga de construtor
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = 2008;
            idade = Idade(); // sobrecarga de construtor
        }

        private int Idade() // sobrecarga de construtor
        {
            return 2026 - anoNascimento;
        }

    }
}
