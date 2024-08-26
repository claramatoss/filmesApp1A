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
    public partial class frmFilmes : Form
    {
        Contexto db;
        Form anterior;

        public frmFilmes(Form anterior)
        {
            InitializeComponent();

            this.anterior = anterior;
        }
        public void Recarregar(string busca)
        {
            List<Filme> filmes =
                this.db.Filme.Where(
                    f => f.Nome.ToUpper().Contains(busca.ToUpper())
                ).ToList();

            dgvFilmes.DataSource = filmes;
        }


        private void frmFilmes_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            this.db.Database.EnsureCreated();
            Recarregar("");
        }

        private void btAdicionarFilme_Click(object sender, EventArgs e)
        {
            frmNovoFilme f = new frmNovoFilme();
            f.ShowDialog();
            Recarregar(txtBuscaFilmes.Text);
        }

        private void btBuscarFilmes_Click(object sender, EventArgs e)
        {
            Recarregar(txtBuscaFilmes.Text);
        }

        Filme selecionadoF;

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFilmes.SelectedCells[0].RowIndex;
            int id = (int)dgvFilmes.Rows[linha].Cells[0].Value;

            selecionadoF = this.db.Filme.Where(f => f.Id == id).First();

            btEditarFilme.Enabled = true;
            btRemoverFilme.Enabled = true;
            btGerenciarElenco.Enabled = true;
        }

        private void btRemoverFilme_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo excluir o filme " + selecionadoF.Nome + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Filme.Remove(selecionadoF);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso");
                Recarregar("");
                btEditarFilme.Enabled = false;
                btRemoverFilme.Enabled = false;
                btGerenciarElenco.Enabled = false;
            }
        }

        private void frmFilmes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
            this.anterior.Show();
        }

        private void btEditarFilme_Click(object sender, EventArgs e)
        {
            frmEditarFilme f = new frmEditarFilme(selecionadoF);
            f.ShowDialog();
            Recarregar(txtBuscaFilmes.Text);
        }
    }
}
