namespace filmesApp1A
{
    partial class frmNovoFilme
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
            cbxNacionalidade = new ComboBox();
            txtNome = new TextBox();
            btCadastrarFilme = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(121, 67);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(200, 23);
            cbxNacionalidade.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 8;
            // 
            // btCadastrarFilme
            // 
            btCadastrarFilme.Location = new Point(141, 118);
            btCadastrarFilme.Name = "btCadastrarFilme";
            btCadastrarFilme.Size = new Size(75, 23);
            btCadastrarFilme.TabIndex = 7;
            btCadastrarFilme.Text = "Cadastrar";
            btCadastrarFilme.UseVisualStyleBackColor = true;
            btCadastrarFilme.Click += btCadastrarFilme_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 70);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 6;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 170);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(btCadastrarFilme);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovoFilme";
            Text = "frmNovoFilme";
            FormClosing += frmNovoFilme_FormClosing;
            Load += frmNovoFilme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxNacionalidade;
        private TextBox txtNome;
        private Button btCadastrarFilme;
        private Label label2;
        private Label label1;
    }
}