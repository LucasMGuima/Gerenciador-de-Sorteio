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
    public partial class CriarSorteio : Form
    {
        public string nome { get; private set; }
        public CriarSorteio()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            this.nome = txtNome.Text;
            if(this.nome.Trim() == "")
            {
                //não foi entrado nada no campo
                MessageBox.Show("O campo de nome é obrigatório.");
                return;
            }

            //foi entrada algo no campo
            this.Close();
        }
    }
}
