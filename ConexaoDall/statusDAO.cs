using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.Model;

namespace system_infuture.ConexaoDall
{
    internal class statusDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public statusDAO()
        {
            conexao.Open();
        }

        #region Metodo de cadastro de encaminhamento
        public void atualizarstatus(Agendamento obj)
        {
            try
            {
                string Comando = @"update tbl_consulta SET ativo=@ativo where id_consulta = @id_consulta";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                ExecutaComando.Parameters.AddWithValue("@ativo", obj.ativo);
                ExecutaComando.Parameters.AddWithValue("@id_consulta", obj.id_consulta);
                
                ExecutaComando.ExecuteNonQuery();                
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }
        }
        #endregion
    }
}
