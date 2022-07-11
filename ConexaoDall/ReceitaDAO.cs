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
    public class ReceitaDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public ReceitaDAO()
        {
            conexao.Open();
        }
        #region Metodo de cadastro de receita
        public void CadastrarReceita (ReceitaMODEL obj)
        {
            try
            {
                string Comando = @" INSERT INTO tbl_receita (longe_od_esferico, longe_oe_esferico, od_cilindrico, oe_cilindrico, od_eixo, oe_eixo, 
                                                         perto_od_esferico, perto_oe_esferico, perto_od_cilindrico, perto_oe_cilindrico, adicao, 
                                                         observacoes,ativo, id_cliente, id_consulta)
                                                         
                                                         values
                                                         (@longe_od_esferico, @longe_oe_esferico, @od_cilindrico, @oe_cilindrico, @od_eixo, @oe_eixo, 
                                                         @perto_od_esferico, @perto_oe_esferico, @perto_od_cilindrico, @perto_oe_cilindrico, @adicao, 
                                                         @observacoes,@ativo, @id_cliente, @id_consulta)";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                ExecutaComando.Parameters.AddWithValue("@longe_od_esferico", obj.longe_od_esferico);
                ExecutaComando.Parameters.AddWithValue("@longe_oe_esferico", obj.longe_oe_esferico);
                ExecutaComando.Parameters.AddWithValue("@od_cilindrico", obj.od_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@oe_cilindrico", obj.oe_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@od_eixo", obj.od_eixo);
                ExecutaComando.Parameters.AddWithValue("@oe_eixo", obj.oe_eixo);
                ExecutaComando.Parameters.AddWithValue("@perto_od_esferico", obj.perto_od_esferico);
                ExecutaComando.Parameters.AddWithValue("@perto_oe_esferico", obj.perto_oe_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@perto_od_cilindrico", obj.perto_od_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@perto_oe_cilindrico", obj.perto_oe_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@adicao", obj.adicao);
                ExecutaComando.Parameters.AddWithValue("@observacoes", obj.observacoes);
                ExecutaComando.Parameters.AddWithValue("@ativo", obj.ativo);
                ExecutaComando.Parameters.AddWithValue("@id_cliente", obj.IdCliente);
                ExecutaComando.Parameters.AddWithValue("@id_consulta", obj.IdConsulta);

                ExecutaComando.ExecuteNonQuery();

                MessageBox.Show("Receita cadastrada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
                conexao.Close();
            }

        }
        #endregion
        #region Metodo de alterar de receita
        public void AlterarReceita(ReceitaMODEL obj)
        {
            try
            {
                string Comando = @" UPDATE tbl_receita SET longe_od_esferico= @longe_od_esferico, longe_oe_esferico= @longe_oe_esferico, od_cilindrico= @od_cilindrico,
                                                            oe_cilindrico= @oe_cilindrico, od_eixo= @od_eixo, oe_eixo= @oe_eixo, 
                                                            perto_od_esferico= @perto_od_esferico, perto_oe_esferico= @perto_oe_esferico, perto_od_cilindrico= @perto_od_cilindrico,
                                                            perto_oe_cilindrico= @perto_oe_cilindrico, adicao= @adicao, 
                                                            observacoes= @observacoes, id_cliente= @id_cliente, id_consulta= @id_consulta";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                ExecutaComando.Parameters.AddWithValue("@longe_od_esferico", obj.longe_od_esferico);
                ExecutaComando.Parameters.AddWithValue("@longe_oe_esferico", obj.longe_oe_esferico);
                ExecutaComando.Parameters.AddWithValue("@od_cilindrico", obj.od_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@oe_cilindrico", obj.oe_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@od_eixo", obj.od_eixo);
                ExecutaComando.Parameters.AddWithValue("@oe_eixo", obj.oe_eixo);
                ExecutaComando.Parameters.AddWithValue("@perto_od_esferico", obj.perto_od_esferico);
                ExecutaComando.Parameters.AddWithValue("@perto_oe_esferico", obj.perto_oe_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@perto_od_cilindrico", obj.perto_od_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@perto_oe_cilindrico", obj.perto_oe_cilindrico);
                ExecutaComando.Parameters.AddWithValue("@adicao", obj.adicao);
                ExecutaComando.Parameters.AddWithValue(" @observacoes", obj.observacoes);
                ExecutaComando.Parameters.AddWithValue("@id_cliente", obj.IdCliente);
                ExecutaComando.Parameters.AddWithValue("@id_consulta", obj.IdConsulta);

                ExecutaComando.ExecuteNonQuery();

                MessageBox.Show("Receita alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
                conexao.Close();
            }

        }
        #endregion
        #region Metodo de excluir de receita
        public void ExcluirReceita(ReceitaMODEL obj)
        {
            try
            {
                string Comando = @" DELETE tbl_receita where id_receita= @id_receita";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                ExecutaComando.Parameters.AddWithValue("@id_receita", obj.IdConsulta);

                ExecutaComando.ExecuteNonQuery();

                MessageBox.Show("Receita excluido com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
                conexao.Close();
            }

        }
        #endregion
    }
}
