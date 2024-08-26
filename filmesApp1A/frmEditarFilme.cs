using filmesApp1A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp1A
{
    public partial class frmEditarFilme : Form
    {
        Filme filme;
        Contexto db;
        public frmEditarFilme()
        {
            InitializeComponent();
            this.db = new Contexto();

            this.filme = filme;

            cbxNacionalidade.DataSource = this.db.Pais.ToList();

            txtNome.Text = filme.Nome;
            numAnoLancamento.Value = filme.AnoLancamento;

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;

            cbxNacionalidade.SelectedIndex =
                cbxNacionalidade.FindStringExact(filme.Nacionalidade.Nome);

            cbxNacionalidade.SelectedIndex = cbxNacionalidade.FindStringExact(filme.Nacionalidade.Nome);

            dgvAtores.DataSource = filme.Atores;
        }

        private void frmEditarFilme_Load(object sender, EventArgs e)
        {

        }

        private void btSalvarFilme_Click(object sender, EventArgs e)
        {
            if (cbxNacionalidade.SelectedIndex > 0)
            {
                filme.Nome = txtNome.Text;
                filme.AnoLancamento = (int)numAnoLancamento.Value;
                Pais pais = this.db.Pais
                            .Where(p => p.Nome == cbxNacionalidade.SelectedItem.ToString())
                            .First();
                filme.Nacionalidade = pais;

                this.db.Filme.Update(filme);
                this.db.SaveChanges();

                MessageBox.Show("Sucesso");
            }
        }

        private void frmEditarFilme_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
        }

        private void dgvAtores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
