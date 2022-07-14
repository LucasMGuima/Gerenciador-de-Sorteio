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
    public partial class RemoverSorteio : Form
    {
        public string nome{ get; private set; }

        public RemoverSorteio()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("O campo de nome é obrigatório.");
                return;
            }

            this.nome = txtNome.Text;
            this.Close();
        }
    }
}
