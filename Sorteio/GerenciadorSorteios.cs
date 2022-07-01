using System;
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
        public GerenciadorSorteios()
        {
            this.sorteios = new List<Sorteio>();
            InitializeComponent();
        }

        private void GerenciadorSorteios_Load(object sender, EventArgs e)
        {
            CarregarSorteios();
        }

        private void CarregarSorteios()
        {
            Escriba.CarregarSorteios(this.sorteios);
            foreach(Sorteio sorteio in this.sorteios)
            {
                cbbSorteios.Items.Add(sorteio.nome);
            }
        }

        private void btnCarregarSorteio_Click(object sender, EventArgs e)
        {
            lstParticipantes.Items.Clear();

            string nomeSorteio = (string) cbbSorteios.SelectedItem;
            if (nomeSorteio == null)
            {
                //Se nada foi celecionado, faz nada
                return;
            }
            //Carrega os participantes
            List<string> participantes = Escriba.CarregaParticipantes(nomeSorteio);
            foreach(string participante in participantes)
            {
                lstParticipantes.Items.Add(participante);
            }
        }
    }
}
