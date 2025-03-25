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
        private DataTable dt;
        public locMain()
        {
            InitializeComponent();
        }

        #region Inserir Filmes
        private void locNovoFilme_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.TableName = "Tabela";

            dt.Columns.Add("Título", typeof(string));
            dt.Columns.Add("Diretor", typeof(string));
            dt.Columns.Add("Gênero", typeof(string));
            dt.Columns.Add("Data de lançamento", typeof(DateTime));
            dt.Columns.Add("Duração", typeof(TimeSpan));
            dt.Columns.Add("Avaliação", typeof(double));

            locBase.DataSource = dt;
        }
        #endregion

        #region Salvar Dados
        private void locSalvarDados_Click(object sender, EventArgs e)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                using (SaveFileDialog salvarComo = new SaveFileDialog())
                {
                    salvarComo.Filter = "Arquivo XML (*.xml)|*.xml";
                    salvarComo.Title = "Salvar Como";
                    salvarComo.FileName = "dados";

                    if (salvarComo.ShowDialog() == DialogResult.OK)
                    {
                        dt.WriteXml(salvarComo.FileName, XmlWriteMode.WriteSchema);
                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há dados para salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Carregar Dados
        private void locCarregarDados_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrirArquivo = new OpenFileDialog())
            {
                abrirArquivo.Filter = "Arquivo XML (*xml)|*xml";
                abrirArquivo.Title = "Abrir arquivo";

                if (abrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        dt = new DataTable();
                        dt.ReadXml(abrirArquivo.FileName);
                        locBase.DataSource = dt;
                        MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region Fechar o sistema.
        private void locSair_Click(object sender, EventArgs e)
        {
            DialogResult fecharSistema = MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Fechar o sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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