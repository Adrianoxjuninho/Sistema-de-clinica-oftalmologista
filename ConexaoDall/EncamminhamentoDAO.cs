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
    public class EncamminhamentoDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public EncamminhamentoDAO()
        {
            conexao.Open();
        }
        #region Metodo de cadastro de encaminhamento
        public void CadastrarEncaminhamento( EncaminhamentoMODEL obj)
        {
            try
            {
                string Comando = @" INSERT INTO tbl_encaminhamento (observacao, ativo, id_cliente, id_consulta)
                                                         values(@observacao, @ativo ,@id_cliente, @id_consulta)";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                ExecutaComando.Parameters.AddWithValue("@observacao", obj.observacoes);
                ExecutaComando.Parameters.AddWithValue("@ativo", obj.ativo);
                ExecutaComando.Parameters.AddWithValue("@id_cliente", obj.IdCliente);
                ExecutaComando.Parameters.AddWithValue("@id_consulta", obj.IdConsulta);

                ExecutaComando.ExecuteNonQuery();

                MessageBox.Show("Encaminhamento realizado com sucesso!");
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
