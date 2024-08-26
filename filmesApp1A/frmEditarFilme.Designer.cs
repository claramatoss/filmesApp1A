namespace filmesApp1A
{
    partial class frmEditarFilme
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
            btSalvarFilme = new Button();
            dgvAtores = new DataGridView();
            cbxNacionalidade = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            numAnoLancamento = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).BeginInit();
            SuspendLayout();
            // 
            // btSalvarFilme
            // 
            btSalvarFilme.Location = new Point(200, 141);
            btSalvarFilme.Name = "btSalvarFilme";
            btSalvarFilme.Size = new Size(75, 23);
            btSalvarFilme.TabIndex = 13;
            btSalvarFilme.Text = "Salvar";
            btSalvarFilme.UseVisualStyleBackColor = true;
            btSalvarFilme.Click += btSalvarFilme_Click;
            // 
            // dgvAtores
            // 
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Location = new Point(26, 213);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(471, 197);
            dgvAtores.TabIndex = 12;
            dgvAtores.CellContentClick += dgvAtores_CellContentClick;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(142, 63);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(244, 23);
            cbxNacionalidade.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 23);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 184);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Filmes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 66);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 106);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 14;
            label4.Text = "Ano Lancamento:";
            // 
            // numAnoLancamento
            // 
            numAnoLancamento.Location = new Point(142, 104);
            numAnoLancamento.Name = "numAnoLancamento";
            numAnoLancamento.Size = new Size(244, 23);
            numAnoLancamento.TabIndex = 15;
            numAnoLancamento.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // frmEditarFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 434);
            Controls.Add(numAnoLancamento);
            Controls.Add(label4);
            Controls.Add(btSalvarFilme);
            Controls.Add(dgvAtores);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditarFilme";
            Text = "Editar Filme";
            FormClosing += frmEditarFilme_FormClosing;
            Load += frmEditarFilme_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalvarFilme;
        private DataGridView dgvAtores;
        private ComboBox cbxNacionalidade;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private NumericUpDown numAnoLancamento;
    }
}