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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        public class Usuarios
        {
            public string Usuario { get; set; }
            public string Senha { get; set; }

            public static Usuarios ValidarLogin(string _usuario, string _senha)
            {
                SqlConnection conn;
                SqlCommand comm;
                SqlDataReader reader;

                string connectionString = Properties.Settings.Default.FERRAGEMConnectionString;
                conn = new SqlConnection(connectionString);

                conn.Open();

                comm = new SqlCommand("SELECT nome_user, senha_user FROM Usuarios WHERE nome_user=@nome_user and senha_user=@senha_user", conn);

                comm.Parameters.Add(new SqlParameter("@nome_user", _usuario));
                comm.Parameters.Add(new SqlParameter("@senha_user", _senha));

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    Usuarios obj = new Usuarios();
                    obj.Usuario = reader["nome_user"].ToString();
                    obj.Senha = reader["senha_user"].ToString();

                    return obj;
                }
                else
                    return null;
            }
        }

        public Usuarios UsuarioLogado { get; set; }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btEntrar;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txUsuario.Text))
                {
                    if (!String.IsNullOrEmpty(txSenha.Text))
                    {
                        UsuarioLogado = Usuarios.ValidarLogin(txUsuario.Text, txSenha.Text);

                        if (UsuarioLogado != null)
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            txUsuario.Text = txSenha.Text = "";
                            labelStatus.Text = "Usuario / Senha inválido";
                        }
                    }
                    else
                    {
                        labelStatus.Text = "Informe a senha do usuário";
                        txSenha.Focus();
                    }
                }
                else
                {
                    labelStatus.Text = "Informe o nome de usuário";
                    txUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = ex.Message;
            }
        }
    }
}
