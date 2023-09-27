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
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fERRAGEMdb.VW_DGV_FORNECEDORES' table. You can move, or remove it, as needed.
            this.vW_DGV_FORNECEDORESTableAdapter.Fill(this.fERRAGEMdb.VW_DGV_FORNECEDORES);
            // TODO: This line of code loads data into the 'fERRAGEMdb.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.fERRAGEMdb.Cidades);
        }

        private void btAtualizarFornecedor_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("AtualizarFornecedor", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(mtxCNPJFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(txIEFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(txEmailFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(mtxTelFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(cbCidadeFornecedor.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult quest = MessageBox.Show("Tem certeza que deseja atualizar o cadastro do fornecedor?\n"
                    , "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (quest == DialogResult.Yes)
                {
                    int idFornecedor = int.Parse(txIDFornecedor.Text);
                    string existingCNPJ = CheckExistingCNPJ(idFornecedor, mtxCNPJFornecedor.Text);

                    if (existingCNPJ != null)
                    {
                        MessageBox.Show($"O CNPJ já está cadastrado para o fornecedor com ID {existingCNPJ}. Verifique o CNPJ e tente novamente.", "Erro de CNPJ duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string existingIE = CheckExistingIE(idFornecedor, txIEFornecedor.Text);

                    if (existingIE != null)
                    {
                        MessageBox.Show($"A Inscrição Estadual já está cadastrada para o fornecedor com ID {existingIE}. Verifique a IE e tente novamente.", "Erro de IE duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    comm.Parameters.AddWithValue("@id_fornecedor", int.Parse(txIDFornecedor.Text));
                    comm.Parameters.AddWithValue("@nome", txNomeFornecedor.Text);
                    comm.Parameters.AddWithValue("@cnpj", mtxCNPJFornecedor.Text);
                    comm.Parameters.AddWithValue("@ie", txIEFornecedor.Text);
                    comm.Parameters.AddWithValue("@email", txEmailFornecedor.Text);
                    comm.Parameters.AddWithValue("@telefone", mtxTelFornecedor.Text);
                    comm.Parameters.AddWithValue("@cidade_nome", cbCidadeFornecedor.Text);

                    comm.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btIncluirFornecedor_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("IncluirFornecedor", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(mtxCNPJFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(txIEFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(txEmailFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(mtxTelFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(cbCidadeFornecedor.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string existingCNPJ = CheckExistingCNPJ(0, mtxCNPJFornecedor.Text);
                if (existingCNPJ != null)
                {
                    MessageBox.Show($"O CNPJ já está cadastrado para o fornecedor com ID {existingCNPJ}. Verifique o CNPJ e tente novamente.", "Erro de CNPJ duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string existingIE = CheckExistingIE(0, txIEFornecedor.Text);
                if (existingIE != null)
                {
                    MessageBox.Show($"A Inscrição Estadual já está cadastrada para o fornecedor com ID {existingIE}. Verifique a IE e tente novamente.", "Erro de IE duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                comm.Parameters.AddWithValue("@nome", txNomeFornecedor.Text);
                comm.Parameters.AddWithValue("@cnpj", mtxCNPJFornecedor.Text);
                comm.Parameters.AddWithValue("@ie", txIEFornecedor.Text);
                comm.Parameters.AddWithValue("@email", txEmailFornecedor.Text);
                comm.Parameters.AddWithValue("@telefone", mtxTelFornecedor.Text);
                comm.Parameters.AddWithValue("@cidade_nome", cbCidadeFornecedor.Text);

                comm.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btConsultarFornecedor_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ConsultarFornecedor", conn);

            if (string.IsNullOrWhiteSpace(txNomeFornecedor.Text) &&
                string.IsNullOrWhiteSpace(mtxCNPJFornecedor.Text) &&
                string.IsNullOrWhiteSpace(txIEFornecedor.Text))
            {
                MessageBox.Show("Por favor, preencha o NOME, CNPJ ou Inscrição Estadual do Fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(txNomeFornecedor.Text) ? (object)DBNull.Value : txNomeFornecedor.Text);
            comm.Parameters.AddWithValue("@cnpj", string.IsNullOrEmpty(mtxCNPJFornecedor.Text) ? (object)DBNull.Value : mtxCNPJFornecedor.Text);
            comm.Parameters.AddWithValue("@ie", string.IsNullOrEmpty(txIEFornecedor.Text) ? (object)DBNull.Value : txIEFornecedor.Text);

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
                        txIDFornecedor.Text = reader["id_fornecedor"].ToString();
                        txNomeFornecedor.Text = reader["nome"].ToString();
                        mtxCNPJFornecedor.Text = reader["cnpj"].ToString();
                        txIEFornecedor.Text = reader["ie"].ToString();
                        txEmailFornecedor.Text = reader["email"].ToString();
                        mtxTelFornecedor.Text = reader["telefone"].ToString();
                        cbCidadeFornecedor.Text = reader["cidade_nome"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado!");
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
        private void btExcluirFornecedor_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ExcluirFornecedor", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(mtxCNPJFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(txIEFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(txEmailFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(mtxTelFornecedor.Text) ||
                    string.IsNullOrWhiteSpace(cbCidadeFornecedor.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult quest = MessageBox.Show("Tem certeza que deseja excluir o fornecedor?\n"
                    , "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (quest == DialogResult.Yes)
                {
                    int fornecedorID = int.Parse(txIDFornecedor.Text);
                    comm.Parameters.AddWithValue("@id_fornecedor", fornecedorID);

                    int rowsAffected = comm.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Fornecedor excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        AtualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado ou não foi possível excluí-lo.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LimparCampos()
        {
            txIDFornecedor.Text = string.Empty;
            txNomeFornecedor.Text = string.Empty;
            mtxCNPJFornecedor.Text = string.Empty;
            txIEFornecedor.Text= string.Empty;
            txEmailFornecedor.Text = string.Empty;
            mtxTelFornecedor.Text = string.Empty;
            cbCidadeFornecedor.SelectedIndex = -1;
        }

        private void AtualizarDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();

                string queryAtualizacao = "SELECT * FROM VW_DGV_FORNECEDORES";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conn);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                dgvFornecedor.DataSource = dataSetAtualizado.Tables[0];
            }
        }

        private string CheckExistingCNPJ(int fornecedorId, string newCNPJ)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT id_fornecedor FROM Fornecedores WHERE cnpj = @cnpj AND id_fornecedor != @id_fornecedor", conn))
                {
                    comm.Parameters.AddWithValue("@cnpj", newCNPJ);
                    comm.Parameters.AddWithValue("@id_fornecedor", fornecedorId);
                    object result = comm.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }

        private string CheckExistingIE(int fornecedorId, string newIE)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT id_fornecedor FROM Fornecedores WHERE ie = @ie AND id_fornecedor != @id_fornecedor", conn))
                {
                    comm.Parameters.AddWithValue("@ie", newIE);
                    comm.Parameters.AddWithValue("@id_fornecedor", fornecedorId);
                    object result = comm.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }

        private void btLimparFornecedor_Click(object sender, EventArgs e)
        {
            DialogResult quest = MessageBox.Show("Limpar todos os campos?\n"
                    , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quest == DialogResult.Yes)
            {
                LimparCampos();
            }
        }
    }
}
