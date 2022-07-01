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
    public partial class NovoParticipante : Form
    {
        public string nome { get; private set; }
        public string contato { get; private set; }

        public NovoParticipante()
        {
            this.nome = null;
            this.contato = null;
            InitializeComponent();
        }

        private void btnConfrimar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Equals("") || txtContato.Text.Equals(""))
            {
                //algum campo está vazio
                MessageBox.Show("Aviso: Ambos os campos são obrigatórios");
            }
            else
            {
                this.nome = txtNome.Text;
                this.contato = txtContato.Text;
                this.Close();
            }
        }
    }
}
