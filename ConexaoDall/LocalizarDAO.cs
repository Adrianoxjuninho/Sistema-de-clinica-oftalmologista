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
    public class LocalizarDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();
        public LocalizarDAO()
        {
            conexao.Open();
        }
        #region Metodo de carregar os 10 clietes mais recentes e mostrar no DataGridview
        public DataTable ListarClientes ()
        {
            //1 PASSO - DEFINIR O COMANDO SQL -
            string sql = @" SELECT id_cliente 'Codigo', nome 'Nome', rg 'Rg', cpf 'CPF', dt_Nascimento 'Data de Nascimento', telefone 'Telefone',
                              celular 'Celular', bairro 'Bairro', cidade 'Cidade', numero 'Numero', endereco 'Endereço', observacoes 'Observação' 
                                                                         
                                                           FROM tbl_cliente  ORDER BY id_cliente desc SET ROWCOUNT 10";

            //2 PASSO - EXECUTAR O COMANDO SQL -
            SqlCommand executarSql = new SqlCommand(sql, conexao);
            executarSql.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(executarSql);

            //3 PASSO - CRIAR A TABELA PARA RECEBER OS DADOS
            DataTable tbl_clientes = new DataTable();

            da.Fill(tbl_clientes);
            conexao.Close();

            return tbl_clientes;
        }
        #endregion
        #region Metodo de carregar os nome da tabela de cliente na ComoBox 
        public DataTable FiltroSql()
        {
            string sql = @" SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbl_cliente' ";

            SqlCommand executarSql = new SqlCommand(sql, conexao);

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
