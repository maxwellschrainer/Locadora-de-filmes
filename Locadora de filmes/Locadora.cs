using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_de_filmes
{
    public partial class locMain : Form
    {
        private DataTable dt = new DataTable();
        public locMain()
        {
            InitializeComponent();
        }

        #region Inserir Filmes
        private void locNovoFilme_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Título:", typeof(string));
            dt.Columns.Add("Diretor:", typeof(string));
            dt.Columns.Add("Gênero:", typeof(string));
            dt.Columns.Add("Data de lançamento:", typeof(DateTime));
            dt.Columns.Add("Duração:", typeof(int));
            dt.Columns.Add("Avaliação", typeof(float));

            locBase.DataSource = dt;
        }
        #endregion

        #region Salvar Dados
        private void locSalvarDados_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                dt.WriteXml("dados.xml", XmlWriteMode.WriteSchema);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Não há dados para salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

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

        private void locBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void locMain_Load(object sender, EventArgs e)
        {

        }

        private void Header_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
