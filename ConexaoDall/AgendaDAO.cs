using System.Data;
using System.Data.SqlClient;
using system_infuture.conexao;

namespace system_infuture.ConexaoDall
{
    public class AgendaDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public DataTable ListarMedico()
        {
            string sql = @"select * from tbl_medico";

            SqlCommand executarSql = new SqlCommand(sql, conexao);

            conexao.Open();
            executarSql.ExecuteNonQuery();

            DataTable tblMedico = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(executarSql);

            da.Fill(tblMedico);
            conexao.Close();

            return tblMedico;

        }
    }
}
