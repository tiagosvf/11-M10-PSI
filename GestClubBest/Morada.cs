using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestClubBest
{
    public class Morada
    {
        // Propriedades
        public string Rua { set; get; }
        public string Localidade { set; get; }
        public string CodigoPostal { set; get; }


        public Morada()
        {
            Rua = null;
            Localidade = null;
            CodigoPostal = null;
        }

        public Morada(string _rua, string _localidade, string _codigoPostal)
        {
            Rua = _rua;
            Localidade = _localidade;
            CodigoPostal = _codigoPostal;
        }


        public override string ToString()
        {
            return Rua + "\n " + Localidade + "\n " + CodigoPostal;
        }
    }
}
