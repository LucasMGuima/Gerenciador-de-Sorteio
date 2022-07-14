using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sorteio
{
    static class Escriba
    {
        /// <summary>
        /// Tenta criar um arquivo txt para guardar os participantes do sorteio.
        /// </summary>
        /// <param name="nomeSorteio">Nome do sorteio.</param>
        /// <returns>True se criou o txt, False se não criou.</returns>
        public static bool CriarTxt(string nomeSorteio)
        {
            string filePath = $"C:..\\..\\Participantes\\{nomeSorteio}.txt";
            if (File.Exists(filePath))
            {
                //Txt ja existe, não precisa criar
                return false;
            }
            else
            {
                //Criou o txt
                File.Create(filePath).Close();
                return true;
            }
        }
        /// <summary>
        /// Le e carrega os participantes do sortei.
        /// </summary>
        /// <param name="nomeSorteio">Nome do sorteio</param>
        /// <returns>Lista de strings das linhas do txt</returns>
        public static List<string> CarregaParticipantes(string nomeSorteio)
        {
            List<string> participantes = new List<string>();
            string filePath = $"C:..\\..\\Participantes\\{nomeSorteio}.txt";
            StreamReader arquivo;
            try
            {
                arquivo = new StreamReader(filePath);
            }catch(IOException e)
            {
                CriarTxt(nomeSorteio);
                arquivo = new StreamReader(filePath);
            }
            string linha;
            while((linha = arquivo.ReadLine()) != null)
            {
                Console.WriteLine("Carregando.");
                Console.Clear();
                participantes.Add(linha);
                Console.WriteLine("Carregando..");
                Console.Clear();
            }
            arquivo.Close();
            return participantes;
        }

        /// <summary>
        /// Salva os participantes do sorteio no arquivo correspondente.
        /// </summary>
        /// <param name="sorteio">Sorteio a ser salvo</param>
        public static void SalvarParticipante(Sorteio sorteio)
        {
            string filePath = $"C:..\\..\\Participantes\\{sorteio.nome}.txt";
            StreamWriter arquivo = new StreamWriter(filePath);
            foreach(Participante p in sorteio.participantes)
            {
                arquivo.WriteLine(p.nome + "," + p.contato);
            }
            arquivo.Close();
        }

        /// <summary>
        /// Carrega os sorteios guardados para dentro do programa.
        /// </summary>
        /// <param name="sorteios">Lista dos sorteios</param>
        public static void CarregarSorteios(List<Sorteio> sorteios)
        {
            string filePath = $"C:..\\..\\Sorteios\\sorteios.txt";
            if (File.Exists(filePath))
            {
                StreamReader arquivo = new StreamReader(filePath);
                string linha;
                while((linha = arquivo.ReadLine()) != null)
                {
                    Sorteio sorteio = new Sorteio(linha.Trim());
                    sorteios.Add(sorteio);
                }
                arquivo.Close();
            }
            else
            {
                File.Create(filePath);
            }
        }

        /// <summary>
        /// Salva os sorteios.
        /// </summary>
        /// <param name="sorteios">Lista dos sorteios</param>
        public static void SalvarSorteios(List<Sorteio> sorteios)
        {
            string filePath = $"C:..\\..\\Sorteios\\sorteios.txt";
            StreamWriter arquivo = new StreamWriter(filePath);
            foreach (Sorteio sorteio in sorteios)
            {
                arquivo.WriteLine(sorteio.nome);
            }
            arquivo.Close();
        }

        ///<summary>
        /// Remove um sorteio da lista de sorteios.
        /// </summary>
        /// <param name="sroteio">Nome do sorteio a ser removido</param>
        public static void RemoverSorteio(string nome)
        {
            string filePath = $"C:..\\..\\Sorteios\\sorteios.txt";
            StreamReader lerArquivo = new StreamReader(filePath);

            List<string> linhasArquivo = new List<string>();
            //le o arquivo
            string linha;
            while ((linha = lerArquivo.ReadLine()) != null)
            {
                if(linha.Equals(nome) == false)
                {
                    linhasArquivo.Add(linha);
                }
            }

            lerArquivo.Close();

            StreamWriter escArquivo = new StreamWriter(filePath);

            foreach(string novaLinha in linhasArquivo)
            {
                escArquivo.WriteLine(novaLinha);
            }
            escArquivo.Close();
        }
    }
}
