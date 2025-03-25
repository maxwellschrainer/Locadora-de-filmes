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
            this.locNovoFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.locSalvarDados = new System.Windows.Forms.ToolStripMenuItem();
            this.locCarregarDados = new System.Windows.Forms.ToolStripMenuItem();
            this.locSair = new System.Windows.Forms.ToolStripMenuItem();
            this.Header = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.locBase)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // locBase
            // 
            this.locBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locBase.Location = new System.Drawing.Point(0, 25);
            this.locBase.Name = "locBase";
            this.locBase.Size = new System.Drawing.Size(800, 425);
            this.locBase.TabIndex = 0;
            this.locBase.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.locBase_DataError);
            // 
            // locNovoFilme
            // 
            this.locNovoFilme.Font = new System.Drawing.Font("Consolas", 10F);
            this.locNovoFilme.Name = "locNovoFilme";
            this.locNovoFilme.Size = new System.Drawing.Size(100, 21);
            this.locNovoFilme.Text = "&Novo Filme";
            this.locNovoFilme.Click += new System.EventHandler(this.locNovoFilme_Click);
            // 
            // locSalvarDados
            // 
            this.locSalvarDados.Font = new System.Drawing.Font("Consolas", 10F);
            this.locSalvarDados.Name = "locSalvarDados";
            this.locSalvarDados.Size = new System.Drawing.Size(116, 21);
            this.locSalvarDados.Text = "&Salvar Dados";
            this.locSalvarDados.Click += new System.EventHandler(this.locSalvarDados_Click);
            // 
            // locCarregarDados
            // 
            this.locCarregarDados.Font = new System.Drawing.Font("Consolas", 10F);
            this.locCarregarDados.Name = "locCarregarDados";
            this.locCarregarDados.Size = new System.Drawing.Size(132, 21);
            this.locCarregarDados.Text = "&Carregar Dados";
            this.locCarregarDados.Click += new System.EventHandler(this.locCarregarDados_Click);
            // 
            // locSair
            // 
            this.locSair.Font = new System.Drawing.Font("Consolas", 10F);
            this.locSair.Name = "locSair";
            this.locSair.Size = new System.Drawing.Size(52, 21);
            this.locSair.Text = "&Sair";
            this.locSair.Click += new System.EventHandler(this.locSair_Click);
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
            this.Header.Size = new System.Drawing.Size(800, 25);
            this.Header.TabIndex = 1;
            this.Header.Text = "menuStrip1";
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
            this.Text = "Locadora de Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.locBase)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView locBase;
        private System.Windows.Forms.ToolStripMenuItem locNovoFilme;
        private System.Windows.Forms.ToolStripMenuItem locSalvarDados;
        private System.Windows.Forms.ToolStripMenuItem locCarregarDados;
        private System.Windows.Forms.ToolStripMenuItem locSair;
        private System.Windows.Forms.MenuStrip Header;
    }
}

