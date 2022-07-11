using System.Configuration;
using System.Data.SqlClient;

namespace system_infuture.conexao
{
    public class ConnectionFactory
    {
        // Metodo para conectar o banco de dados
        public static SqlConnection GetConnection()
        {
            // Acessando a string de conexão
            string conexao = ConfigurationManager.ConnectionStrings["system_infuture.Properties.Settings.SqlServerConnectionString"].ConnectionString;

            return new SqlConnection(conexao);
        }

    }
}
