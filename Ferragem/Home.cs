using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ferragem.Login;

namespace Ferragem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Login frmLogin = new Login();
            Login L1 = new Login();
            L1.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Clientes());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Fornecedores());
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new NotaEntrada());
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Produtos());
        }

        private Form formularioAberto = null;

        private void AbrirForm(Form novoFormulario)
        {
            if (formularioAberto != null && !formularioAberto.IsDisposed)
            {
                formularioAberto.Close();
            }

            novoFormulario.Owner = this;
            novoFormulario.Show();
            formularioAberto = novoFormulario;
        }

        private void strUsuario_Click(object sender, EventArgs e)
        {

        }

        private void strSaida_Click(object sender, EventArgs e)
        {

        }
    }
}
