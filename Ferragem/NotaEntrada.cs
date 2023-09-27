using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferragem
{
    public partial class NotaEntrada : Form
    {
        private DataTable dataTable;

        public NotaEntrada()
        {
            InitializeComponent();

            dataTable = new DataTable();
            dataTable.Columns.Add("n_nota", typeof(int));
            dataTable.Columns.Add("fornecedor_nome", typeof(string));
            dataTable.Columns.Add("produto_nome", typeof(string));
            dataTable.Columns.Add("qtde", typeof(int));
            dataTable.Columns.Add("valor_un_compra", typeof(double));

            // Configure o DataGridView para usar o DataTable como fonte de dados
            dgvProd.DataSource = dataTable;
        }

        private void NotaEntrada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fERRAGEMdb1.VW_DGV_NOTA_ENTRADA' table. You can move, or remove it, as needed.
            this.vW_DGV_NOTA_ENTRADATableAdapter.Fill(this.fERRAGEMdb1.VW_DGV_NOTA_ENTRADA);
            // TODO: This line of code loads data into the 'fERRAGEMdb1.VW_DGV_PROD_ENTRADA' table. You can move, or remove it, as needed.
            this.vW_DGV_PROD_ENTRADATableAdapter.Fill(this.fERRAGEMdb1.VW_DGV_PROD_ENTRADA);
            // TODO: This line of code loads data into the 'fERRAGEMdb1.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter2.Fill(this.fERRAGEMdb1.Produtos);
            // TODO: This line of code loads data into the 'fERRAGEMdb1.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter2.Fill(this.fERRAGEMdb1.Fornecedores);
        }

        private void btConsultarNotaE_Click(object sender, EventArgs e)
        {
            int nNota;
            if (int.TryParse(txNumNota.Text, out nNota))
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
                {
                    conn.Open();

                    using (SqlCommand comm = new SqlCommand("ConsultarNotaEntrada", conn))
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@n_nota", nNota);

                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            string fornecedorNome = dataTable.Rows[0]["fornecedor_nome"].ToString();

                            cbFornecedor.Text = fornecedorNome;

                            dgvProd.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Nota não encontrada.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Número de nota inválido. Insira um número válido.");
            }
        }


        private void btIncluirNotaE_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("IncluirNotaEntrada", conn);
            comm.CommandType = CommandType.StoredProcedure;

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao abrir conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (string.IsNullOrWhiteSpace(cbFornecedor.Text) || string.IsNullOrWhiteSpace(txNumNota.Text))
                {
                    MessageBox.Show("Por favor, preencha o fornecedor e o número da nota.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvProd.Rows.Count == 0)
                {
                    MessageBox.Show("Adicione pelo menos um produto à nota.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txNumNota.Text, out int nNota))
                {
                    MessageBox.Show("O número da nota deve ser um valor numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in dgvProd.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string produtoNome = row.Cells[0].Value.ToString();
                        int qtde = Convert.ToInt32(row.Cells[1].Value);
                        double valorUnCompra = Convert.ToDouble(row.Cells[2].Value);

                        using (SqlCommand command = new SqlCommand("IncluirNotaEntrada", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@fornecedor_nome", cbFornecedor.Text);
                            command.Parameters.AddWithValue("@produto_nome", produtoNome);
                            command.Parameters.AddWithValue("@n_nota", nNota);
                            command.Parameters.AddWithValue("@qtde", qtde);
                            command.Parameters.AddWithValue("@valor_un_compra", valorUnCompra);

                            command.ExecuteNonQuery();
                        }
                    }
                }

                AtualizarDataGridView();
                LimparCampos(); // Limpa os campos após atualizar o dgvProd

                MessageBox.Show("Produtos incluídos na nota com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produtos na nota: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btAtualizarNotaE_Click(object sender, EventArgs e)
        {

        }

        private void btExcluirNotaE_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ExcluirNotaEntrada", conn);
            comm.CommandType = CommandType.StoredProcedure;

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao abrir conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (string.IsNullOrWhiteSpace(txNumNota.Text))
                {
                    MessageBox.Show("Por favor, preencha o Número da Nota.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica se o texto em txIDNotaE.Text é um número válido
                if (int.TryParse(txNumNota.Text, out int notaN))
                {
                    DialogResult quest = MessageBox.Show("Tem certeza que deseja excluir a nota?\n", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (quest == DialogResult.Yes)
                    {
                        comm.Parameters.AddWithValue("@n_nota", notaN);

                        int rowsAffected = comm.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nota excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                            AtualizarDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Nota não encontrada ou não foi possível excluí-la.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Número de nota inválido. Insira um número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir nota: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btLimparNotaE_Click(object sender, EventArgs e)
        {
            DialogResult quest = MessageBox.Show("Limpar todos os campos?\n", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quest == DialogResult.Yes)
            {
                LimparCampos();

            }
        }


        private void LimparCampos()
        {
            cbProduto.SelectedIndex = -1;
            cbFornecedor.SelectedIndex = -1;
            txNumNota.Text = string.Empty;
            txQtde.Text = string.Empty;
            txValor_Compra.Text = string.Empty;

            dataTable.Clear();

            dgvProd.DataSource = dataTable;
        }

        private void txValor_Compra_TextChanged(object sender, EventArgs e)
        {
            string textoSemFormatacao = txValor_Compra.Text.Replace(",", "").Replace(".", "");

            if (decimal.TryParse(textoSemFormatacao, out decimal valor))
            {
                string valorFormatado = (valor / 100).ToString("N2");

                txValor_Compra.Text = valorFormatado;
                txValor_Compra.SelectionStart = txValor_Compra.Text.Length;
            }
        }

        private void btAdiciona_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            row["produto_nome"] = cbProduto.Text;
            row["qtde"] = Convert.ToInt32(txQtde.Text);
            row["valor_un_compra"] = Convert.ToDouble(txValor_Compra.Text);
            dataTable.Rows.Add(row);

            cbProduto.SelectedIndex = -1;
            txQtde.Clear();
            txValor_Compra.Clear();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                // Remove a última linha do DataTable
                dataTable.Rows.RemoveAt(dataTable.Rows.Count - 1);

                // Atualiza o DataGridView
                dgvProd.DataSource = null;
                dgvProd.DataSource = dataTable;
            }
        }

        private void AtualizarDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();

                string queryAtualizacao = "SELECT * FROM VW_DGV_NOTA_ENTRADA";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conn);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                vWDGVNOTAENTRADABindingSource.DataSource = dataSetAtualizado.Tables[0];
            }
        }

        private void txNumNota_TextChanged(object sender, EventArgs e)
        {
            if (txNumNota.Text.Length > 4)
            {
                MessageBox.Show("O número da nota não pode ter mais de 4 dígitos.");
                txNumNota.Text = txNumNota.Text.Substring(0, 4);
            }
            else if (!string.IsNullOrWhiteSpace(txNumNota.Text) && int.TryParse(txNumNota.Text, out int nNota))
            {
                // Verifica se o número da nota já existe no DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    int existingNota;
                    if (int.TryParse(row["n_nota"].ToString(), out existingNota) && existingNota == nNota)
                    {
                        MessageBox.Show("Este número de nota já foi utilizado.");
                        txNumNota.Text = string.Empty;
                        break;
                    }
                }
            }
        }

    }
}
