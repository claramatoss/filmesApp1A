namespace filmesApp1A
{
    partial class frmFilmes
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
            txtBuscaFilmes = new TextBox();
            btBuscarFilmes = new Button();
            dgvFilmes = new DataGridView();
            btAdicionarFilme = new Button();
            btEditarFilme = new Button();
            btRemoverFilme = new Button();
            btGerenciarElenco = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            SuspendLayout();
            // 
            // txtBuscaFilmes
            // 
            txtBuscaFilmes.Location = new Point(12, 12);
            txtBuscaFilmes.Name = "txtBuscaFilmes";
            txtBuscaFilmes.Size = new Size(589, 23);
            txtBuscaFilmes.TabIndex = 1;
            // 
            // btBuscarFilmes
            // 
            btBuscarFilmes.Location = new Point(607, 12);
            btBuscarFilmes.Name = "btBuscarFilmes";
            btBuscarFilmes.Size = new Size(75, 23);
            btBuscarFilmes.TabIndex = 2;
            btBuscarFilmes.Text = "Buscar";
            btBuscarFilmes.UseVisualStyleBackColor = true;
            btBuscarFilmes.Click += btBuscarFilmes_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Location = new Point(11, 52);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(667, 362);
            dgvFilmes.TabIndex = 3;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick;
            // 
            // btAdicionarFilme
            // 
            btAdicionarFilme.Location = new Point(12, 420);
            btAdicionarFilme.Name = "btAdicionarFilme";
            btAdicionarFilme.Size = new Size(126, 23);
            btAdicionarFilme.TabIndex = 4;
            btAdicionarFilme.Text = "Adicionar Filme";
            btAdicionarFilme.UseVisualStyleBackColor = true;
            btAdicionarFilme.Click += btAdicionarFilme_Click;
            // 
            // btEditarFilme
            // 
            btEditarFilme.Enabled = false;
            btEditarFilme.Location = new Point(506, 420);
            btEditarFilme.Name = "btEditarFilme";
            btEditarFilme.Size = new Size(78, 23);
            btEditarFilme.TabIndex = 5;
            btEditarFilme.Text = "Editar Filme";
            btEditarFilme.UseVisualStyleBackColor = true;
            btEditarFilme.Click += btEditarFilme_Click;
            // 
            // btRemoverFilme
            // 
            btRemoverFilme.Enabled = false;
            btRemoverFilme.Location = new Point(590, 420);
            btRemoverFilme.Name = "btRemoverFilme";
            btRemoverFilme.Size = new Size(88, 23);
            btRemoverFilme.TabIndex = 6;
            btRemoverFilme.Text = "Excluir Filme";
            btRemoverFilme.UseVisualStyleBackColor = true;
            btRemoverFilme.Click += btRemoverFilme_Click;
            // 
            // btGerenciarElenco
            // 
            btGerenciarElenco.Enabled = false;
            btGerenciarElenco.Location = new Point(394, 420);
            btGerenciarElenco.Name = "btGerenciarElenco";
            btGerenciarElenco.Size = new Size(106, 23);
            btGerenciarElenco.TabIndex = 7;
            btGerenciarElenco.Text = "Gerenciar Elenco";
            btGerenciarElenco.UseVisualStyleBackColor = true;
            // 
            // frmFilmes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(btGerenciarElenco);
            Controls.Add(btRemoverFilme);
            Controls.Add(btEditarFilme);
            Controls.Add(btAdicionarFilme);
            Controls.Add(dgvFilmes);
            Controls.Add(btBuscarFilmes);
            Controls.Add(txtBuscaFilmes);
            Name = "frmFilmes";
            Text = "Filmes";
            FormClosing += frmFilmes_FormClosing;
            Load += frmFilmes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscaFilmes;
        private Button btBuscarFilmes;
        private DataGridView dgvFilmes;
        private Button btAdicionarFilme;
        private Button btEditarFilme;
        private Button btRemoverFilme;
        private Button btGerenciarElenco;
    }
}