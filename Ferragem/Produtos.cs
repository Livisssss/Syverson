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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fERRAGEMdb.VW_DGV_PRODUTOS' table. You can move, or remove it, as needed.
            this.vW_DGV_PRODUTOSTableAdapter.Fill(this.fERRAGEMdb.VW_DGV_PRODUTOS);
            // TODO: This line of code loads data into the 'fERRAGEMdb.VW_DGV_PRODUTOS' table. You can move, or remove it, as needed.
            this.vW_DGV_PRODUTOSTableAdapter.Fill(this.fERRAGEMdb.VW_DGV_PRODUTOS);
            // TODO: This line of code loads data into the 'fERRAGEMdb.VW_DGV_PRODUTOS' table. You can move, or remove it, as needed.
            this.vW_DGV_PRODUTOSTableAdapter.Fill(this.fERRAGEMdb.VW_DGV_PRODUTOS);
        }

        private void btConsultarProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ConsultarProduto", conn);

            if (string.IsNullOrWhiteSpace(txNomeProduto.Text))
            {
                MessageBox.Show("Por favor, preencha o NOME do Produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(txNomeProduto.Text) ? (object)DBNull.Value : txNomeProduto.Text);

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao tentar abrir o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        txIDProduto.Text = reader["id_produto"].ToString();
                        txNomeProduto.Text = reader["nome"].ToString();
                        txDescricaoProduto.Text = reader["descricao"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao tentar executar o comando SQL.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("IncluirProduto", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeProduto.Text) ||
                    string.IsNullOrWhiteSpace(txDescricaoProduto.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string existingProduto = CheckExistingProductName(0, txNomeProduto.Text);

                if (existingProduto != null)
                {
                    MessageBox.Show($"Já existe um Produto com esse nome, se trata do ID {existingProduto}. Verifique o Produto e tente novamente.", "Erro de Produto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                comm.Parameters.AddWithValue("@nome", txNomeProduto.Text);
                comm.Parameters.AddWithValue("@descricao", txDescricaoProduto.Text);

                comm.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btAtualizarProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("AtualizarProduto", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeProduto.Text) ||
                    string.IsNullOrWhiteSpace(txDescricaoProduto.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult quest = MessageBox.Show("Tem certeza que deseja atualizar o cadastro do produto?\n"
                    , "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (quest == DialogResult.Yes)
                {
                    string existingProduto = CheckExistingProductName(int.Parse(txIDProduto.Text), txNomeProduto.Text);
                    if (existingProduto != null)
                    {
                        MessageBox.Show($"Já existe um Produto com esse nome, se trata do ID {existingProduto}. Verifique o Produto e tente novamente.", "Erro de Produto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    comm.Parameters.AddWithValue("@id_produto", int.Parse(txIDProduto.Text));
                    comm.Parameters.AddWithValue("@nome", txNomeProduto.Text);
                    comm.Parameters.AddWithValue("@descricao", txDescricaoProduto.Text);

                    comm.ExecuteNonQuery();

                    MessageBox.Show("Produto atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ExcluirProduto", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeProduto.Text) ||
                     string.IsNullOrWhiteSpace(txDescricaoProduto.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult quest = MessageBox.Show("Tem certeza que deseja excluir o produto?\n"
                    , "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (quest == DialogResult.Yes)
                {
                    int produtoID = int.Parse(txIDProduto.Text);
                    comm.Parameters.AddWithValue("@id_produto", produtoID);

                    int rowsAffected = comm.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produto excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        AtualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado ou não foi possível excluí-lo.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btLimparProduto_Click(object sender, EventArgs e)
        {
            DialogResult quest = MessageBox.Show("Limpar todos os campos?\n"
                    , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quest == DialogResult.Yes)
            {
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txIDProduto.Text = string.Empty;
            txNomeProduto.Text = string.Empty;
            txDescricaoProduto.Text = string.Empty;
        }

        private void AtualizarDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();

                string queryAtualizacao = "SELECT * FROM VW_DGV_PRODUTOS";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conn);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                dgvProdutos.DataSource = dataSetAtualizado.Tables[0];
            }
        }

        private string CheckExistingProductName(int produtoId, string newProductName)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT id_produto FROM Produtos WHERE nome = @nome AND id_produto != @id_produto", conn))
                {
                    comm.Parameters.AddWithValue("@nome", newProductName);
                    comm.Parameters.AddWithValue("@id_produto", produtoId);
                    object result = comm.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }
    }
}
