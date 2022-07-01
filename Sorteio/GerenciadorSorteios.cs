﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class GerenciadorSorteios : Form
    {
        private List<Sorteio> sorteios;
        private Sorteio sorteio;
        public GerenciadorSorteios()
        {
            this.sorteios = new List<Sorteio>();
            this.sorteio = null;
            InitializeComponent();
        }

        private void GerenciadorSorteios_Load(object sender, EventArgs e)
        {
            CarregarSorteios();
        }

        private void CarregarSorteios()
        {
            Escriba.CarregarSorteios(this.sorteios);
            foreach (Sorteio sorteio in this.sorteios)
            {
                cbbSorteios.Items.Add(sorteio.nome);
            }
        }

        private void btnCarregarSorteio_Click(object sender, EventArgs e)
        {
            lstParticipantes.Items.Clear();

            string nomeSorteio = (string)cbbSorteios.SelectedItem;
            if (nomeSorteio == null)
            {
                //Se nada foi celecionado, faz nada
                return;
            }

            if (this.sorteio == null)
            {
                //N existe sorteio ainda
                this.sorteio = new Sorteio(nomeSorteio);
                List<string> lstParticipantes = Escriba.CarregaParticipantes(nomeSorteio);
                foreach(string p in lstParticipantes)
                {
                    string[] parte = p.Split(',');
                    this.sorteio.AdicionarParaticipante(parte[0].Trim(), parte[1].Trim());
                }
            }

            foreach (Participante participante in this.sorteio.participantes)
            {
                lstParticipantes.Items.Add(participante.ToString("", null));
            }
        }

        private void btnAddParticipante_Click(object sender, EventArgs e)
        {
            NovoParticipante novoParticipante = new NovoParticipante();
            novoParticipante.ShowDialog();
            if(novoParticipante.nome != null && novoParticipante.contato != null)
            {
                this.sorteio.AdicionarParaticipante(novoParticipante.nome, novoParticipante.contato);
                //recarrega a lista de participantes
                btnCarregarSorteio_Click(sender, e);
            }
        }
    }
}