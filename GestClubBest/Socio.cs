using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestClubBest
{
    public class Socio : Pessoa
    {
        readonly uint numSocio; // 0 to 4,294,967,295 - Unsigned 32-bit integer
                                // Deve ser inicializado no construtor

        // propriedade apenas de leitura
        public uint NumSocio
        {
            get
            {
                return numSocio;
            }
        }

        public Socio(string _nome, DateTime _dataNasc, Morada _moradaPessoa, uint _numSocio) : base(_nome, _dataNasc, _moradaPessoa)
        {
            numSocio = _numSocio;
        }

        public override string ToString()
        {
            return  Nome + ", " + Idade + " anos.\n" + MoradaPessoa.ToString() + " " + "N.º " + numSocio ;
        }
    }
}
