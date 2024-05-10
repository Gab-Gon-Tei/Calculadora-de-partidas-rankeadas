using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_partidas_rankeadas
{
    internal class Herói
    {
        public string nome;
        public int vitorias;
        public int derrotas;
        public int saldo;
        public string rank;

        public void Calculadora()
        {
            saldo = (vitorias - derrotas);
        }

       
    }
}
