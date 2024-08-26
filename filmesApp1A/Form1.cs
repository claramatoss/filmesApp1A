using filmesApp1A.Models;

namespace filmesApp1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAtores f = new frmAtores(this);
            f.Show();
            this.Hide();
        }
    }
}
