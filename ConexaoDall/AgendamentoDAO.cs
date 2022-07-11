using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.Model;

namespace system_infuture.ConexaoDall
{
    public class AgendamentoDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public AgendamentoDAO()
        {
            conexao.Open();
        }
        #region Metodo de salvar a consulta com o cliente
        public void CadastrarConsulta(Agendamento obj)
        {
            try
            {
                // 1 Passo - DEFINIR O COMADO SQL
                string sql_query = @"INSERT INTO tbl_consulta (dt_consulta,horario,motivo_da_consulta,retorno,ativo,id_cliente,id_medico) 
                                            VALUES (@dt_consulta,@horario,@motivo_da_consulta,@retorno,@ativo,@id_cliente,@id_medico)";

                SqlCommand sqlCommand = new SqlCommand(sql_query, conexao);
                //3 PASSO - RECEBER OS DADOS E PASSSAR PARA O BANCO DE DADOS
                sqlCommand.Parameters.AddWithValue("@dt_consulta", obj.dt_consulta);
                sqlCommand.Parameters.AddWithValue("@horario", obj.horario);
                sqlCommand.Parameters.AddWithValue("@motivo_da_consulta", obj.motivo_consulta);
                sqlCommand.Parameters.AddWithValue("@retorno", obj.retorno);
                sqlCommand.Parameters.AddWithValue("@ativo", obj.ativo);
                sqlCommand.Parameters.AddWithValue("@id_cliente", obj.id_cliente);
                sqlCommand.Parameters.AddWithValue("@id_medico", obj.id_medico);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Agendamento realizado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }
        }
        #endregion
        #region Metodo de Alterar a consulta com o cliente
        public void AlterarConsulta(Agendamento obj)
        {
            try
            {
                // 1 Passo - DEFINIR O COMADO SQL
                string sql_query = @" UPDATE tbl_consulta SET dt_consulta= @dt_consulta, horario= @horario,motivo_da_consulta= @motivo_da_consulta,
                                                              retorno=@retorno,ativo=@ativo,id_cliente=@id_cliente,id_medico=@id_medico

                                                              WHERE id_consulta=@id_consulta"; 

                SqlCommand sqlCommand = new SqlCommand(sql_query, conexao);
                //3 PASSO - RECEBER OS DADOS E PASSSAR PARA O BANCO DE DADOS
                sqlCommand.Parameters.AddWithValue("@dt_consulta", obj.dt_consulta);
                sqlCommand.Parameters.AddWithValue("@horario", obj.horario);
                sqlCommand.Parameters.AddWithValue("@motivo_da_consulta", obj.motivo_consulta);
                sqlCommand.Parameters.AddWithValue("@retorno", obj.retorno);
                sqlCommand.Parameters.AddWithValue("@ativo", obj.ativo);
                sqlCommand.Parameters.AddWithValue("@id_cliente", obj.id_cliente);
                sqlCommand.Parameters.AddWithValue("@id_medico", obj.id_medico);


                sqlCommand.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }
        }
        #endregion
        #region Metodo de Excluir a consulta com o cliente
        public void ExcluirCadastro( Agendamento obj)
        {
            try
            {
                // 1 Passo - DEFINIR O COMADO SQL
                string comandosql = @"delet tbl_consulta where id_consulta = @id_consulta";


                //2 PASSO - EXECUTAR O COMANDO SQL
                SqlCommand sqlCommand = new SqlCommand(comandosql, conexao);

                //3 PASSO - RECEBER OS DADOS E PASSSAR PARA O BANCO DE DADOS
                sqlCommand.Parameters.AddWithValue("@id_consulta", obj.id_consulta);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Consulta excluida com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }
        }
        #endregion

        #region Metodo de listar o cliente
        public DataTable ListarCliente(Agendamento obj)
        {
            string sql = @"select * from tbl_cliente where cpf=cpf";

            SqlCommand executarSql = new SqlCommand(sql, conexao);

            conexao.Open();
            executarSql.ExecuteNonQuery();

            DataTable tblCliente = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(executarSql);

            da.Fill(tblCliente);
            conexao.Close();

            return tblCliente;

        }
        #endregion
    }
}
