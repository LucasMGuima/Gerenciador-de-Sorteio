﻿using System;
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

        public static List<string> CarregaParticipantes(string nomeSorteio)
        {
            List<string> participantes = new List<string>();
            string filePath = $"C:..\\..\\Participantes\\{nomeSorteio}.txt";
            StreamReader arquivo = new StreamReader(filePath);
            
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
    }
}
