using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestClubBest
{
    public class Clube
    {
        public Pessoa Presidente { get; set; } // Cada clube tem um presidente
        public List<Pessoa> listaPessoasClube; // Lista de atletas e sócios

        public Clube()
        {
            Presidente = new Pessoa();
            listaPessoasClube = new List<Pessoa>();
        }

        public Clube(Pessoa _presidente)
        {
            Presidente = _presidente;
            listaPessoasClube = new List<Pessoa>();
        }

        // Inser um atleta ou um sócio
        public void InserirPessoa(Pessoa _pessoa)
        {
            listaPessoasClube.Add(_pessoa);
        }

        // Exemplo de outro método: devolve quantos sócios tem a lista de pessoas
        public int GetCountSocios()
        {
            int total = 0;
            foreach (var item in Global.clube.listaPessoasClube)
            {
                if (item is Socio)
                {
                    total++;

                }
            }

            return total;
        }
       /* public int GetCountAtletas()
        {
            int total = 0;
            foreach (var item in Global.clube.listaPessoasClube)
            {
                if (item is Atleta)
                {
                    total++;


                }
            }
            return total;
        }*/


        // Colocar aqui mais métodos para gerir a lista de pessoas: Procura, eliminação,...)
    }
}
