using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestClubBest
{
    public class Atleta : Pessoa
    {
        double peso;

        public static Pessoa Treinador { get; set; }

        public double Peso  // kg; valor positivo
        {
            get
            {
                return peso;
            }
            set
            {
                peso = Math.Abs(value);
            }
        }

        public Atleta() : base()
        {
            Peso = 0;
            Treinador = new Pessoa();
        }

        public Atleta(string _nome, DateTime _dataNasc, Morada _moradaPessoa, double _peso) : base(_nome, _dataNasc, _moradaPessoa)
        {
            Peso = _peso;
        }


        public void SetAtleta(Pessoa _treinador)
        {
            Treinador = _treinador;
        }

    }
}
