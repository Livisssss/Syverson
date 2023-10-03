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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ferragem
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
  
        private void btIncluirCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("IncluirCliente", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeCliente.Text) ||
                    string.IsNullOrWhiteSpace(dtpDataNascCliente.Text) ||
                    string.IsNullOrWhiteSpace(txIdadeCliente.Text) ||
                    string.IsNullOrWhiteSpace(mtxCPFCliente.Text) ||
                    string.IsNullOrWhiteSpace(txEmailCliente.Text) ||
                    string.IsNullOrWhiteSpace(mtxTelCliente.Text) ||
                    string.IsNullOrWhiteSpace(cbCidadeCliente.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string existingCPF = CheckExistingCPF(0, mtxCPFCliente.Text);

                if (existingCPF != null)
                {
                    MessageBox.Show($"O CPF já está cadastrado para o cliente com ID {existingCPF}. Verifique o CPF e tente novamente.", "Erro de CPF duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime dataNascimento;
                if (DateTime.TryParse(dtpDataNascCliente.Text, out dataNascimento))
                {
                    comm.Parameters.AddWithValue("@data_nasc", dataNascimento);
                }
                else
                {
                    MessageBox.Show("A data de nascimento é inválida. Insira uma data no formato correto (AAAA-MM-DD).", "Erro de data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                comm.Parameters.AddWithValue("@nome", txNomeCliente.Text);
                comm.Parameters.AddWithValue("@idade", txIdadeCliente.Text);
                comm.Parameters.AddWithValue("@cpf", mtxCPFCliente.Text);
                comm.Parameters.AddWithValue("@email", txEmailCliente.Text);
                comm.Parameters.AddWithValue("@telefone", mtxTelCliente.Text);
                comm.Parameters.AddWithValue("@cidade_nome", cbCidadeCliente.Text);

                comm.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fERRAGEMdb2.VW_DGV_CLIENTES' table. You can move, or remove it, as needed.
            this.vW_DGV_CLIENTESTableAdapter.Fill(this.fERRAGEMdb.VW_DGV_CLIENTES);
            // TODO: This line of code loads data into the 'fERRAGEMdb2.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.fERRAGEMdb.Cidades);
            // TODO: This line of code loads data into the 'fERRAGEMdb2.VW_DGV_CLIENTES' table. You can move, or remove it, as needed.
            this.vW_DGV_CLIENTESTableAdapter.Fill(this.fERRAGEMdb.VW_DGV_CLIENTES);
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ConsultarCliente", conn);

            if (string.IsNullOrWhiteSpace(txNomeCliente.Text) &&
                string.IsNullOrWhiteSpace(mtxCPFCliente.Text))
            {
                MessageBox.Show("Por favor, preencha o NOME ou CPF do Cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(txNomeCliente.Text) ? (object)DBNull.Value : txNomeCliente.Text);
            comm.Parameters.AddWithValue("@cpf", string.IsNullOrEmpty(mtxCPFCliente.Text) ? (object)DBNull.Value : mtxCPFCliente.Text);

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
                        txIDCliente.Text = reader["id_cliente"].ToString();
                        txNomeCliente.Text = reader["nome"].ToString();
                        mtxCPFCliente.Text = reader["cpf"].ToString();
                        dtpDataNascCliente.Text = reader["data_nascimento"].ToString();
                        txIdadeCliente.Text = reader["idade"].ToString();
                        txEmailCliente.Text = reader["email"].ToString();
                        mtxTelCliente.Text = reader["telefone"].ToString();
                        cbCidadeCliente.Text = reader["cidade_nome"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!");
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

        private void LimparCampos()
        {
            txIDCliente.Text = string.Empty;
            txNomeCliente.Text = string.Empty;
            mtxCPFCliente.Text = string.Empty;
            txIdadeCliente.Text = string.Empty;
            dtpDataNascCliente.Value = DateTime.Now;
            txEmailCliente.Text = string.Empty;
            mtxTelCliente.Text = string.Empty;
            cbCidadeCliente.SelectedIndex = -1;
        }

        private void btLimparCliente_Click(object sender, EventArgs e)
        {
            DialogResult quest = MessageBox.Show("Limpar todos os campos?\n"
                    , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quest == DialogResult.Yes)
            {
                LimparCampos();
            }
        }

        private void btExcluirCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ExcluirCliente", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeCliente.Text) ||
                    string.IsNullOrWhiteSpace(dtpDataNascCliente.Text) ||
                    string.IsNullOrWhiteSpace(txIdadeCliente.Text) ||
                    string.IsNullOrWhiteSpace(mtxCPFCliente.Text) ||
                    string.IsNullOrWhiteSpace(txEmailCliente.Text) ||
                    string.IsNullOrWhiteSpace(mtxTelCliente.Text) ||
                    string.IsNullOrWhiteSpace(cbCidadeCliente.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult quest = MessageBox.Show("Tem certeza que deseja excluir o cliente?\n"
                    , "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (quest == DialogResult.Yes)
                {
                    int clienteID = int.Parse(txIDCliente.Text);
                    comm.Parameters.AddWithValue("@id_cliente", clienteID);

                    int rowsAffected = comm.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        AtualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado ou não foi possível excluí-lo.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("AtualizarCliente", conn);
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

                if (string.IsNullOrWhiteSpace(txNomeCliente.Text) ||
                    string.IsNullOrWhiteSpace(dtpDataNascCliente.Text) ||
                    string.IsNullOrWhiteSpace(txIdadeCliente.Text) ||
                    string.IsNullOrWhiteSpace(mtxCPFCliente.Text) ||
                    string.IsNullOrWhiteSpace(txEmailCliente.Text) ||
                    string.IsNullOrWhiteSpace(mtxTelCliente.Text) ||
                    string.IsNullOrWhiteSpace(cbCidadeCliente.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult quest = MessageBox.Show("Tem certeza que deseja atualizar o cadastro do cliente?\n"
                    , "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (quest == DialogResult.Yes)
                {
                    string existingCPF = CheckExistingCPF(int.Parse(txIDCliente.Text), mtxCPFCliente.Text);
                    if (existingCPF != null)
                    {
                        MessageBox.Show($"O CPF já está cadastrado para o cliente com ID {existingCPF}. Verifique o CPF e tente novamente.", "Erro de CPF duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    comm.Parameters.AddWithValue("@id_cliente", int.Parse(txIDCliente.Text));
                    comm.Parameters.AddWithValue("@cpf", mtxCPFCliente.Text);
                    comm.Parameters.AddWithValue("@nome", txNomeCliente.Text);
                    comm.Parameters.AddWithValue("@data_nasc", dtpDataNascCliente.Text);
                    comm.Parameters.AddWithValue("@idade", txIdadeCliente.Text);
                    comm.Parameters.AddWithValue("@email", txEmailCliente.Text);
                    comm.Parameters.AddWithValue("@telefone", mtxTelCliente.Text);
                    comm.Parameters.AddWithValue("@cidade_nome", cbCidadeCliente.Text);

                    comm.ExecuteNonQuery();

                    MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AtualizarDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();

                string queryAtualizacao = "SELECT * FROM VW_DGV_CLIENTES";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conn);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                vWDGVCLIENTESBindingSource.DataSource = dataSetAtualizado.Tables[0];
            }
        }

        private void txIdadeCliente_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;

            conn = new SqlConnection(connectionString);

            conn.Open();

            comm = new SqlCommand("SELECT dbo.CalculaIdade(@Date)", conn);

            DateTime dataNascimento;
            if (DateTime.TryParse(dtpDataNascCliente.Text, out dataNascimento))
            {
                comm.Parameters.AddWithValue("@Date", dataNascimento);
                int idade = (int)comm.ExecuteScalar();
                txIdadeCliente.Text = idade.ToString();
            }
            else
            {
                MessageBox.Show("Data de nascimento inválida. Insira uma data no formato correto.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            conn.Close();
        }

        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Year;

            if (dataNascimento.Date > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }

        private void dtpDataNascCliente_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataNascimento = dtpDataNascCliente.Value;
            int idade = CalcularIdade(dataNascimento);
            txIdadeCliente.Text = idade.ToString();
        }
        private string CheckExistingCPF(int clienteId, string newCPF)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.FERRAGEMConnectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT id_cliente FROM Clientes WHERE cpf = @cpf AND id_cliente != @id_cliente", conn))
                {
                    comm.Parameters.AddWithValue("@cpf", newCPF);
                    comm.Parameters.AddWithValue("@id_cliente", clienteId);
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
