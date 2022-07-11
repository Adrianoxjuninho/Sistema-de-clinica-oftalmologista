using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.ConexaoDall;
using system_infuture.Model;

namespace system_infuture.Apresentação
{
    public partial class FrmUsuario : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadUsersMODEL obj = new CadUsersMODEL();

            obj.usuario = Campo_usuario.Text;
            obj.senha = Campo_senha.Text;
            obj.tipo_usuario = Campo_tipo_usuario.Text;

            CadUsersDAO dAO = new CadUsersDAO();
            dAO.SalvarUsuario(obj);
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsersMODEL obj = new CadUsersMODEL();

            obj.usuario = Campo_usuario.Text;
            obj.senha = Campo_senha.Text;
            obj.tipo_usuario = Campo_tipo_usuario.Text;

            CadUsersDAO dAO = new CadUsersDAO();
            dAO.EditarUsers(obj);
        }
    }
}
