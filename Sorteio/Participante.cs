using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio
{
    class Participante : IFormattable
    {
        public string nome { get; private set; }
        public string contato { get; private set; }

        public Participante(string nome, string contato)
        {
            this.nome = nome;
            this.contato = contato;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            string str = $"{this.nome} -> {this.contato}";
            return str;
        }
    }
}
