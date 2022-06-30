using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO:
// [x] Poder ocorrer mais de um sorteio por vez
// [] Interface gráfica
// [x] Tratamento de erros

namespace Sorteio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de sorteios existentes
            List<Sorteio> sorteios = new List<Sorteio>();
            Escriba.CarregarSorteios(sorteios);
            Menu(sorteios);
        }

        private static void Menu(List<Sorteio> sorteios)
        {
            int op;
            do
            {
                Console.WriteLine("--Gerenciador de sorteios--");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Criar um novo sorteio");
                Console.WriteLine("2 - Remover um sorteio");
                Console.WriteLine("3 - Abrir um sorteio existente");
                Console.WriteLine("0 - Fechar");

                Console.Write("Entre com o valor da opção: ");
                if(Int32.TryParse(Console.ReadLine(),out op))
                {
                    switch (op)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.Clear();
                            //Cria um novo sorteio
                            NovoSorteio(sorteios);
                            break;
                        case 2:
                            Console.Clear();
                            //Remove um sorteio
                            RemoverSorteio(sorteios);
                            break;
                        case 3:
                            Console.Clear();
                            //Abre um sorteio existente
                            AbrirSorteio(sorteios);
                            break;
                        default:
                            Console.WriteLine("Entrada invalida");
                            Proceguir();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    op = -1;
                    Proceguir();
                }

            } while (op != 0);
            Escriba.SalvarSorteios(sorteios);
        }

        private static void AbrirSorteio(List<Sorteio> sorteios)
        {
            Console.WriteLine("--Sorteios--");
            int cont = 0;
            foreach(Sorteio sorteio in sorteios)
            {
                Console.WriteLine($"{cont} -> {sorteio.nome}");
                cont++;
            }
            Console.Write("Entre com o nume do sorteio a ser aberto: ");
            int num = Int32.Parse(Console.ReadLine());
            MenuSorteio(sorteios.ElementAt<Sorteio>(num));
        }

        private static void RemoverSorteio(List<Sorteio> sorteios)
        {
            Console.WriteLine("--Remover Sorteio--");
            Console.Write("Entre com o nome do sorteio a ser removido: ");
            string nome = Console.ReadLine();

            foreach(Sorteio sorteio in sorteios)
            {
                if (sorteio.nome.Equals(nome))
                {
                    sorteios.Remove(sorteio);
                }
            }
        }

        private static void NovoSorteio(List<Sorteio> sorteios)
        {
            Console.WriteLine("--Novo Sorteio--");
            Console.Write("Entre com o nome do novo sorteio: ");
            string nome = Console.ReadLine();
            sorteios.Add(new Sorteio(nome));
            Proceguir();
        }

        private static void MenuSorteio(Sorteio sorteio)
        {
            ChecarParticipantes(sorteio);
            //Cria o random com uma seed sendo os segundos atuais
            Random random = new Random(DateTime.Now.Second);
            int op;

            do
            {
                Console.WriteLine($"Sorteio {sorteio.nome}");
                Console.WriteLine("Escolha uma opcao");
                Console.WriteLine("1 - Adcionar participante");
                Console.WriteLine("2 - Remover participante");
                Console.WriteLine("3 - Ver participantes");
                Console.WriteLine("4 - Efetuar sorteio");
                Console.WriteLine("0 - Voltar");

                Console.Write("Entre com o valor da opção: ");
                if(Int32.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 0:
                            break;
                        //Adciona um novo participante
                        case 1:
                            Console.Clear();
                            AdicionarParticipante(sorteio);
                            break;
                        //Remove um participante
                        case 2:
                            Console.Clear();
                            RemoveParticipante(sorteio);
                            break;
                        //Mostra os participantes
                        case 3:
                            Console.Clear();
                            Console.WriteLine("--Particpantes--");
                            sorteio.ListarParticipantes();
                            Proceguir();
                            break;
                        //Efetua o sorteio
                        case 4:
                            Console.Clear();
                            EfetuarSorteio(sorteio, random);
                            break;
                        default:
                            Console.WriteLine("Entrada invalida");
                            Proceguir();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    op = -1;
                    Proceguir();
                }


            } while (op != 0);
            Escriba.SalvarParticipante(sorteio);
            return;
        }

        private static void ChecarParticipantes(Sorteio sorteio)
        {
            if (Escriba.CriarTxt(sorteio.nome) == false) //Não preciso cria o txt, logo existe participantes armazenados
            {
                //Carrega esses participantes
                List<string> particpantes = Escriba.CarregaParticipantes(sorteio.nome);
                foreach (string p in particpantes)
                {
                    string[] participante = p.Split(',');
                    sorteio.AdicionarParaticipante(participante[0], participante[1].Trim());
                }
            }
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
