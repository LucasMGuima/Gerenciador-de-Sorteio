using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria o random com uma seed sendo os segundos atuais
            Random random = new Random(DateTime.Now.Second);
            
            List <Participante> participantes = new List<Participante>();
            participantes.Add(new Participante("Ze", "11223344556"));
            participantes.Add(new Participante("Re", "99885533221"));
            participantes.Add(new Participante("Te", "55667788990"));

            Menu(participantes, random);
        }

        private static void Menu(List<Participante> participantes, Random random)
        {
            int op;

            do
            {
                Console.WriteLine("MVP - Sorteio");
                Console.WriteLine("Escolha uma opcao");
                Console.WriteLine("1 - Adcionar participante");
                Console.WriteLine("2 - Remover participante");
                Console.WriteLine("3 - Ver participantes");
                Console.WriteLine("4 - Efetuar sorteio");
                Console.WriteLine("0 - Sair");

                Console.Write("Entre com o valor da opção: ");
                op = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    //Adciona um novo participante
                    case 1:
                        AdicionarParaticipante(participantes);
                        break;
                    //Remove um participante
                    case 2:
                        RemoveParticipante(participantes);
                        break;
                    //Mostra os participantes
                    case 3:
                        ListarParticipantes(participantes);
                        break;
                    //Efetua o sorteio
                    case 4:
                        EfetuarSorteio(participantes, random);
                        break;
                }

            } while (op != 0);

            return;
        }

        private static void EfetuarSorteio(List<Participante> participantes, Random random)
        {
            int numSorteio = random.Next(participantes.Count());
            Console.WriteLine("O sorteado foi:");
            Console.WriteLine(participantes.ElementAt(numSorteio));

            Console.WriteLine("===================================");
            Console.WriteLine("Aperte Enter para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void ListarParticipantes(List<Participante> participantes)
        {
            foreach(Participante p in participantes)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("===================================");
            Console.WriteLine("Aperte Enter para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void AdicionarParaticipante(List<Participante> participantes)
        {
            Console.Write("Entre com o nome do participante: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o numero do participante: ");
            string contato = Console.ReadLine();

            participantes.Add(new Participante(nome, contato));

            Console.WriteLine("===================================");
            Console.WriteLine("Aperte Enter para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void RemoveParticipante(List<Participante> participantes)
        {
            Console.Write("Entre com o nome a ser removido: ");
            string nome = Console.ReadLine();

            foreach(Participante p in participantes)
            {
                if(string.Equals(p.nome, nome))
                {
                    //acho o cara e remove
                    participantes.Remove(p);
                    return;
                }
            }
        }
    }
}
