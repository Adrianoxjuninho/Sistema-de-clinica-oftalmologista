using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.Model;

namespace system_infuture.ConexaoDall
{
    public class CadUsersDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public CadUsersDAO()
        {
            conexao.Open();
        }
        #region Metodo de salvar os usuarios
        public void SalvarUsuario (CadUsersMODEL obj)
        {
            try
            {
                string comandosql = "insert into tb_login (usuario, senha, tipo_usuario ) values (@usuario, @senha, @tipo_usuario";

                SqlCommand sqlCommand = new SqlCommand(comandosql, conexao);

                sqlCommand.Parameters.AddWithValue("@usuario", obj.usuario);
                sqlCommand.Parameters.AddWithValue("@senha", obj.senha);
                sqlCommand.Parameters.AddWithValue("@tipo_usuario", obj.tipo_usuario);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Cadastro salvo com sucesso!");
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao cadastrar usuario,", "ATENÇÃO !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
            }
        }
        #endregion

        #region Metodo de alterar os dados do usuarios
        public void EditarUsers(CadUsersMODEL obj)
        {
            try
            {
                // 1 Passo - DEFINIR O COMADO SQL
                string comandosql = @"update tbl_login set usuario= @usuario, senha= @sennha, tipo_usuario= @tipo_usuario 

                                                              where id_login = @id_login";


                //2 PASSO - EXECUTAR O COMANDO SQL
                SqlCommand sqlCommand = new SqlCommand(comandosql, conexao);

                //3 PASSO - RECEBER OS DADOS E PASSSAR PARA O BANCO DE DADOS
                sqlCommand.Parameters.AddWithValue("@usuario", obj.usuario);
                sqlCommand.Parameters.AddWithValue("@senha", obj.senha);
                sqlCommand.Parameters.AddWithValue("@tipo_usuario", obj.tipo_usuario);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Aconteceu um erro:", "ATENÇÃO !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
            }
        }
        #endregion

        #region Metodo de carregador todos os usuarios
        public DataTable CarregarUsuario()
        {
            string comandosql = "select * from tbl_login";

            SqlCommand sqlCommand = new SqlCommand(comandosql, conexao);

            sqlCommand.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            //3 PASSO - CRIAR A TABELA PARA RECEBER OS DADOS
            DataTable tbl_login = new DataTable();

            da.Fill(tbl_login);
            conexao.Close();

            return tbl_login;
        }
        #endregion
    }
}
