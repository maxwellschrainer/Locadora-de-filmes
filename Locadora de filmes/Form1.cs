using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_de_filmes
{
    public partial class locMain : Form
    {
        public locMain()
        {
            InitializeComponent();
        }

        private void locNovoFilme_Click(object sender, EventArgs e)
        {

        }

        private void locSalvarDados_Click(object sender, EventArgs e)
        {

        }

        private void locCarregarDados_Click(object sender, EventArgs e)
        {

        }

        #region Fechar o sistema.
        private void locSair_Click(object sender, EventArgs e)
        {
            DialogResult fecharSistema = MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Fechar o sistema?", MessageBoxButtons.YesNo);
            if (fecharSistema == DialogResult.Yes)
            {
                this.Close();
            }
            else if (fecharSistema == DialogResult.No)
            {
                this.Refresh();
            }
        }
        #endregion
    }
}
