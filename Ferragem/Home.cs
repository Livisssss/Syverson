using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Clientes frmClientes = new Clientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Fornecedores frmFornecedores  = new Fornecedores();
            frmFornecedores.MdiParent = this;
            frmFornecedores.Show();
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            NotaEntrada frmNotaEntarda = new NotaEntrada();
            frmNotaEntarda.MdiParent = this;
            frmNotaEntarda.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Produtos frmProdutos = new Produtos();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }
    }
}
