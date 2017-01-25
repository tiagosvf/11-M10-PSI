using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestClubBest
{
    public class Pessoa
    {
        // Atributos privados
        // Data dataNasc;
        DateTime dataNasc;

        // Propriedades públicas
        public string Nome { get; set; }
        public Morada MoradaPessoa { get; set; }
        public int Idade { get; private set; } // A permissão de escrita é apenas válido na classe
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set
            {
                dataNasc = value;
                Idade = CalculaIdade(); // Calcula a idade sempre que se altere a data de nascimento
            }
        }

        int CalculaIdade()
        {
            int anos = DateTime.Now.Year - dataNasc.Year;
            if (DateTime.Now.Month < dataNasc.Month || (DateTime.Now.Month == dataNasc.Month && DateTime.Now.Day < dataNasc.Day))
                anos--;
            return anos;
        }

        public Pessoa()
        {
            Nome = null;
            DataNasc = new DateTime();
            MoradaPessoa = new Morada();
            Idade = CalculaIdade();
        }

        public Pessoa(string _nome, DateTime _dataNasc, Morada _moradaPessoa)
        {
            Nome = _nome;
            DataNasc = _dataNasc;
            MoradaPessoa = _moradaPessoa;
            Idade = CalculaIdade();
        }

        public override string ToString()
        {
            return Nome + ", " + Idade + " anos.\n" + MoradaPessoa.ToString();
        }
    }
}
