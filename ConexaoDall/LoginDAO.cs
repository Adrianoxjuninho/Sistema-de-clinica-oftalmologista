using System.Data;
using System.Data.SqlClient;
using system_infuture.conexao;

namespace system_infuture.Controle
{
    public class LoginDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public DataTable ListarTodosUsuarios()
        {
            string sql = @"select usuario from tb_login ";

            SqlCommand executarSql = new SqlCommand(sql, conexao);

            conexao.Open();
            executarSql.ExecuteNonQuery();

            DataTable TabelaLoginn = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(executarSql);

            da.Fill(TabelaLoginn);
            conexao.Close();

            return TabelaLoginn;

        }
    }
}
