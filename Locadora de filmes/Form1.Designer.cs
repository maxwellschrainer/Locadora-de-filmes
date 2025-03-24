namespace Locadora_de_filmes
{
    partial class locMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.locBase = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.MenuStrip();
            this.locNovoFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.locSalvarDados = new System.Windows.Forms.ToolStripMenuItem();
            this.locCarregarDados = new System.Windows.Forms.ToolStripMenuItem();
            this.locSair = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.locBase)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // locBase
            // 
            this.locBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locBase.Location = new System.Drawing.Point(0, 24);
            this.locBase.Name = "locBase";
            this.locBase.Size = new System.Drawing.Size(800, 426);
            this.locBase.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locNovoFilme,
            this.locSalvarDados,
            this.locCarregarDados,
            this.locSair});
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 24);
            this.Header.TabIndex = 1;
            this.Header.Text = "menuStrip1";
            // 
            // locNovoFilme
            // 
            this.locNovoFilme.Name = "locNovoFilme";
            this.locNovoFilme.Size = new System.Drawing.Size(80, 20);
            this.locNovoFilme.Text = "Novo Filme";
            this.locNovoFilme.Click += new System.EventHandler(this.locNovoFilme_Click);
            // 
            // locSalvarDados
            // 
            this.locSalvarDados.Name = "locSalvarDados";
            this.locSalvarDados.Size = new System.Drawing.Size(86, 20);
            this.locSalvarDados.Text = "Salvar Dados";
            this.locSalvarDados.Click += new System.EventHandler(this.locSalvarDados_Click);
            // 
            // locCarregarDados
            // 
            this.locCarregarDados.Name = "locCarregarDados";
            this.locCarregarDados.Size = new System.Drawing.Size(100, 20);
            this.locCarregarDados.Text = "Carregar Dados";
            this.locCarregarDados.Click += new System.EventHandler(this.locCarregarDados_Click);
            // 
            // locSair
            // 
            this.locSair.Name = "locSair";
            this.locSair.Size = new System.Drawing.Size(38, 20);
            this.locSair.Text = "Sair";
            this.locSair.Click += new System.EventHandler(this.locSair_Click);
            // 
            // locMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.locBase);
            this.Controls.Add(this.Header);
            this.MainMenuStrip = this.Header;
            this.Name = "locMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.locBase)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView locBase;
        private System.Windows.Forms.MenuStrip Header;
        private System.Windows.Forms.ToolStripMenuItem locNovoFilme;
        private System.Windows.Forms.ToolStripMenuItem locSalvarDados;
        private System.Windows.Forms.ToolStripMenuItem locCarregarDados;
        private System.Windows.Forms.ToolStripMenuItem locSair;
    }
}

