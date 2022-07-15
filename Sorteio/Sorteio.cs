using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio
{
    internal class Sorteio
    {
        public String nome{ get; private set; }
        public List<Participante> participantes { get; private set; }

        ///<summary>
        ///Cria um novo sorteio com a lista de participantes vazia.
        ///</summary>
        public Sorteio(string nome)
        {
            this.nome = nome;
            this.participantes = new List<Participante>();
        }

        /// <summary>
        /// Encontra o participante na posição sorteada.
        /// </summary>
        /// <param name="valorSorteado">Valor que representa a posição sorteada</param>
        public void EfetuarSorteio(int valorSorteado)
        {
            Console.WriteLine("O sorteado foi:");
            Console.WriteLine(this.participantes.ElementAt(valorSorteado));
        }
        /// <summary>
        /// Encontra e retorna o participante na posição sorteada.
        /// </summary>
        /// <param name="valorSorteado">Valor que representa a posição sorteada</param>
        /// <returns>Um elemento do tipo Participante, que representa o participante ganhador.</returns>
        public Participante RetornarSorteado(int valorSorteado)
        {
            Participante ganhador;
            ganhador = this.participantes.ElementAt(valorSorteado);
            return ganhador;
        }
        /// <summary>
        /// Imprime na tela todos os participantes cadastrados do sorteio, e seus contatos.
        /// </summary>
        public void ListarParticipantes()
        {
            foreach (Participante p in participantes)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Adicona um novo participante ao sorteio.
        /// </summary>
        /// <param name="nome">Nome do participante.</param>
        /// <param name="contato">Contato do participante</param>
        public void AdicionarParaticipante(string nome, string contato)
        {
            participantes.Add(new Participante(nome, contato));
        }
        /// <summary>
        /// Remove o participante especificado do sorteio.
        /// </summary>
        /// <param name="nome">Nome do participante a ser removido.</param>
        public void RemoveParticipante(string nome)
        {
            foreach (Participante p in this.participantes)
            {
                if (string.Equals(p.nome, nome))
                {
                    //acho o cara e remove
                    this.participantes.Remove(p);
                    return;
                }
            }
        }
    }
}
