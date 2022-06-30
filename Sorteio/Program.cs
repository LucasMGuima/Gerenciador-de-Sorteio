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

            //Cria um sorteio
            Sorteio sorteio = new Sorteio("Teste");

            if (Escriba.CriarTxt(sorteio.nome) == false) //Não preciso cria o txt, logo existe participantes aramzenados
            {
                List<string> particpantes = Escriba.CarregaParticipantes(sorteio.nome);
                foreach(string p in particpantes)
                {
                    string[] participante = p.Split(',');
                    sorteio.AdicionarParaticipante(participante[0], participante[1].Trim());
                }
            }
            Menu(random, sorteio);
        }

        private static void Menu(Random random, Sorteio sorteio)
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
                        AdicionarParticipante(sorteio);
                        break;
                    //Remove um participante
                    case 2:
                        RemoveParticipante(sorteio);
                        break;
                    //Mostra os participantes
                    case 3:
                        Console.WriteLine("--Particpantes--");
                        sorteio.ListarParticipantes();
                        Proceguir();
                        break;
                    //Efetua o sorteio
                    case 4:
                        EfetuarSorteio(sorteio, random);
                        break;
                }

            } while (op != 0);
            Escriba.SalvarParticipante(sorteio);
            return;
        }

        private static void RemoveParticipante(Sorteio sorteio)
        {
            Console.WriteLine("--Remover Participante--");
            Console.Write("Entre com o nome a ser removido: ");
            string nome = Console.ReadLine();
            sorteio.RemoveParticipante(nome);
            Proceguir();
        }

        private static void AdicionarParticipante(Sorteio sorteio)
        {
            Console.WriteLine("--Cadastrar um novo participante--");
            Console.Write("Entre com o nome do novo participante: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o contato do participante: ");
            string contato = Console.ReadLine();

            sorteio.AdicionarParaticipante(nome, contato);

            Proceguir();
        }

        private static void EfetuarSorteio(Sorteio sorteio, Random random)
        {
            int qtdParticipantes = sorteio.participantes.Count();
            int posSorteada = random.Next(qtdParticipantes);
            Console.WriteLine("--Sorteio--");
            sorteio.EfetuarSorteio(posSorteada);
            Proceguir();
        }

        private static void Proceguir()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Aperte Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
