namespace filmesApp1A
{
    partial class frmAtores
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
            txtBuscaAtores = new TextBox();
            btBuscarAtores = new Button();
            dgvAtores = new DataGridView();
            btAdicionarAtor = new Button();
            btEditarAtor = new Button();
            btRemoverAtor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            SuspendLayout();
            // 
            // txtBuscaAtores
            // 
            txtBuscaAtores.Location = new Point(12, 12);
            txtBuscaAtores.Name = "txtBuscaAtores";
            txtBuscaAtores.Size = new Size(589, 23);
            txtBuscaAtores.TabIndex = 0;
            // 
            // btBuscarAtores
            // 
            btBuscarAtores.Location = new Point(607, 12);
            btBuscarAtores.Name = "btBuscarAtores";
            btBuscarAtores.Size = new Size(75, 23);
            btBuscarAtores.TabIndex = 1;
            btBuscarAtores.Text = "Buscar";
            btBuscarAtores.UseVisualStyleBackColor = true;
            btBuscarAtores.Click += btBuscar_Click;
            // 
            // dgvAtores
            // 
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Location = new Point(12, 51);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(667, 362);
            dgvAtores.TabIndex = 2;
            dgvAtores.CellClick += dgvAtores_CellClick;
            // 
            // btAdicionarAtor
            // 
            btAdicionarAtor.Location = new Point(12, 419);
            btAdicionarAtor.Name = "btAdicionarAtor";
            btAdicionarAtor.Size = new Size(126, 23);
            btAdicionarAtor.TabIndex = 3;
            btAdicionarAtor.Text = "Adicionar Ator";
            btAdicionarAtor.UseVisualStyleBackColor = true;
            btAdicionarAtor.Click += btAdicionar_Click;
            // 
            // btEditarAtor
            // 
            btEditarAtor.Enabled = false;
            btEditarAtor.Location = new Point(510, 419);
            btEditarAtor.Name = "btEditarAtor";
            btEditarAtor.Size = new Size(75, 23);
            btEditarAtor.TabIndex = 4;
            btEditarAtor.Text = "Editar Ator";
            btEditarAtor.UseVisualStyleBackColor = true;
            btEditarAtor.Click += btEditar_Click;
            // 
            // btRemoverAtor
            // 
            btRemoverAtor.Enabled = false;
            btRemoverAtor.Location = new Point(591, 419);
            btRemoverAtor.Name = "btRemoverAtor";
            btRemoverAtor.Size = new Size(88, 23);
            btRemoverAtor.TabIndex = 5;
            btRemoverAtor.Text = "Excluir Ator";
            btRemoverAtor.UseVisualStyleBackColor = true;
            btRemoverAtor.Click += btRemover_Click;
            // 
            // frmAtores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 450);
            Controls.Add(btRemoverAtor);
            Controls.Add(btEditarAtor);
            Controls.Add(btAdicionarAtor);
            Controls.Add(dgvAtores);
            Controls.Add(btBuscarAtores);
            Controls.Add(txtBuscaAtores);
            MaximizeBox = false;
            Name = "frmAtores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atores";
            FormClosing += frmAtores_FormClosing;
            Load += frmAtores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscaAtores;
        private Button btBuscarAtores;
        private DataGridView dgvAtores;
        private Button btAdicionarAtor;
        private Button btEditarAtor;
        private Button btRemoverAtor;
    }
}