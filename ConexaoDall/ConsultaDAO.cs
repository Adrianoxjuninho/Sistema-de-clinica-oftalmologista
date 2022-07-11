using System.Data;
using System.Data.SqlClient;
using system_infuture.conexao;

namespace system_infuture.ConexaoDall
{
    public class ConsultaDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public ConsultaDAO()
        {
            conexao.Open();
        }

        public DataTable ListarMedicos()
        {
            string sql_query = @"select cli.id_cliente 'Código', cli.nome 'Paciente', con.dt_consulta 'Data da consulta', con.horario 'Horario',
                                        con.retorno 'Retorno', con.motivo_da_consulta 'Motivo da consulta'

                                        from tbl_cliente as cli join tbl_consulta as con on cli.id_cliente = con.id_cliente";

            DataTable tblMedico = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(sql_query, conexao);

            da.Fill(tblMedico);
            conexao.Close();

            return tblMedico;

        }
    }
}
