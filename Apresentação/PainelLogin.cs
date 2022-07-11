using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.Controle;

namespace system_infuture
{
    public partial class PainelLogin : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public static string usuarioConectado;
        public PainelLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm = new SqlCommand("select * from tb_login where usuario = @usuario And senha = @senha", conexao);

                comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tbUsers.Text;
                comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = Campo_senha.Text;
                conexao.Open();

                int i = (int)comm.ExecuteScalar();

                if ((tbUsers.Text != "") && (Campo_senha.Text != ""))

                {
                    SqlDataReader reader = null;
                    //lê as linhas de uma base de dados SQL Server
                    reader = comm.ExecuteReader();

                    //Se tiver coisa pra lê faça:
                    if (reader.Read())
                    {
                        //Variaveil usuarioConectado foi criada no inicio da tela e recebe campo usuariotextBox.Text
                        usuarioConectado = tbUsers.Text.ToString();
                    }
                    this.Visible = false;
                    new FrmPrincipal().ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Usuário e/ou Senha inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexao.Close();
        }

        private void NovoForm()
        {
            Application.Run(new FrmPrincipal());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AcceptButton = btnLogar;
        }

        private void PainelLogin_Load(object sender, EventArgs e)
        {
            LoginDAO dao = new LoginDAO();
            tbUsers.DataSource = dao.ListarTodosUsuarios();

            tbUsers.DisplayMember = "usuario";
        }

        private void tbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
