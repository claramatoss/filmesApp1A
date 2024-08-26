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
    public partial class frmNovoFilme : Form
    {
        Contexto db;
        public frmNovoFilme()
        {
            InitializeComponent();

            this.db = new Contexto();

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;
        }

        private void frmNovoFilme_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;
        }

        private void frmNovoFilme_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
        }

        public void Recarregar(string busca)
        {
            List<Filme> filmes = this.db.Filme
               .Where(f => f.Nome.ToUpper().Contains(busca.ToUpper()))
               .ToList();
        }

        private void btCadastrarFilme_Click(object sender, EventArgs e)
        {
            if (cbxNacionalidade.SelectedIndex > -1)
            {
                Filme novo = new Filme();
                novo.Nome = txtNome.Text;
                novo.AnoLancamento = (int)numAnoLancamento.Value;

                Pais pais = this.db.Pais
                      .Where(p => p.Nome == cbxNacionalidade.SelectedItem.ToString())
                      .First();

                novo.Nacionalidade = pais;

                this.db.Filme.Add(novo);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso");
                this.Close();
            }
        }
    }
}
