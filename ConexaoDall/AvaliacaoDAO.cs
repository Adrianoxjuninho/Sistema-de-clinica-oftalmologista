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
    public class AvaliacaoDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();
        public AvaliacaoDAO()
        {
            conexao.Open();
        }

        #region Metodo de Listar todos os clientes do sistema
        public DataTable ListarClientes()
        {
            //1 PASSO - DEFINIR O COMANDO SQL -
            //string sql = @"select cli.id_cliente 'Código', cli.nome 'Paciente', con.dt_consulta 'Data da consulta', con.horario 'Horario',med.nome'Médico',
            //con.retorno 'Retorno', con.motivo_da_consulta 'Motivo da consulta', con.ativo 'Status', con.id_consulta 'FK_FOREIGN' 
            //from tbl_cliente as cli 
            //join tbl_consulta as con on cli.id_cliente = con.id_cliente
            //join tbl_medico as med on med.id_medico = con.id_medico";

            string sql = @"select cli.id_cliente 'Código', cli.nome 'Paciente', con.dt_consulta 'Data da consulta', con.horario 'Horario',med.nome'Médico',
                                                    con.retorno 'Retorno', con.motivo_da_consulta 'Motivo da consulta', con.ativo 'Status', con.id_consulta 'FK_FOREIGN' 
                                                    from tbl_cliente as cli 
													join tbl_consulta as con on cli.id_cliente = con.id_cliente
													join tbl_medico as med on med.id_medico = con.id_medico
													
													where con.ativo = 'aguardando'";

            //2 PASSO - EXECUTAR O COMANDO SQL -
            SqlCommand executarSql = new SqlCommand(sql, conexao);
            executarSql.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(executarSql);

            //3 PASSO - CRIAR A TABELA PARA RECEBER OS DADOS
            DataTable tbl_cliente = new DataTable();

            da.Fill(tbl_cliente);
            conexao.Close();

            return tbl_cliente;
        }
        #endregion

        #region Metodo de cadastrar anamnese
        public void CadastrarAnamnese(AvalicaoMODEL obj)
        {
            try
            {
                string Comando = @"INSERT INTO tbl_anamnese (m_p_c, ant_pessoais, ant_familiar, od_esferico, oe_esferico, od_cilindrico, oe_cilindrico, 
                                                           od_eixo, oe_eixo, adicao, od_av, od_p_p, oe_av, oe_p_p, od_cc, od_p_p_cc, oe_cc, oe_p_p_cc, 
                                                           seg_posterior, seg_anterior, ativo, id_cliente, id_consulta)

                                                           VALUES 
                                                           (@m_p_c, @ant_pessoais, @ant_familiar, @od_esferico, @oe_esferico, @od_cilindrico, 
                                                           @oe_cilindrico, @od_eixo, @oe_eixo, @adicao, @od_av, @od_p_p, @oe_av, @oe_p_p, @od_cc, 
                                                           @od_p_p_cc, @oe_cc, @oe_p_p_cc, @seg_posterior, @seg_anterior, @ativo,
                                                           @id_cliente, @id_consulta)";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                // OBJETOS QUE IRAM RECEBER OS DADOS E PASSAR PARA O BANCO DE DADOS
                ExecutaComando.Parameters.AddWithValue("@m_p_c", obj.m_p_c);
                ExecutaComando.Parameters.AddWithValue("@ant_pessoais", obj.ant_Pessoais);
                ExecutaComando.Parameters.AddWithValue("@ant_familiar", obj.ant_Familiar);
                ExecutaComando.Parameters.AddWithValue("@od_esferico", obj.oD_Esferico);
                ExecutaComando.Parameters.AddWithValue("@oe_esferico", obj.oE_Esferico);
                ExecutaComando.Parameters.AddWithValue("@od_cilindrico", obj.oD_Cilindrico);
                ExecutaComando.Parameters.AddWithValue("@oe_cilindrico", obj.oE_Cilindrico);
                ExecutaComando.Parameters.AddWithValue("@od_eixo", obj.oD_Eixo);
                ExecutaComando.Parameters.AddWithValue("@oe_eixo", obj.oE_Eixo);
                ExecutaComando.Parameters.AddWithValue("@adicao", obj.adicao);
                ExecutaComando.Parameters.AddWithValue("@od_av", obj.oD_Av);
                ExecutaComando.Parameters.AddWithValue("@od_p_p", obj.oD_P_P);
                ExecutaComando.Parameters.AddWithValue("@oe_av", obj.oE_Av);
                ExecutaComando.Parameters.AddWithValue("@oe_p_p", obj.oE_P_P);
                ExecutaComando.Parameters.AddWithValue("@od_cc", obj.oD_CC);
                ExecutaComando.Parameters.AddWithValue("@od_p_p_cc", obj.oD_P_P_CC);
                ExecutaComando.Parameters.AddWithValue("@oe_cc", obj.oE_CC);
                ExecutaComando.Parameters.AddWithValue("@oe_p_p_cc", obj.oE_P_P_CC);
                ExecutaComando.Parameters.AddWithValue("@seg_posterior", obj.seg_Posterior);
                ExecutaComando.Parameters.AddWithValue("@seg_anterior", obj.seg_Anterior);
                ExecutaComando.Parameters.AddWithValue("@ativo", obj.ativo);
                ExecutaComando.Parameters.AddWithValue("@id_cliente", obj.IdCliente);
                ExecutaComando.Parameters.AddWithValue("@id_consulta", obj.IdConsulta);

                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Anamnese cadastrada com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }

        }

        #endregion

        #region Metodo de editar anamnese
        public void EditarAnamnese(AvalicaoMODEL obj)
        {
            try
            {
                string Comando = @" UPDATE tbl_anamnese SET m_p_c=@m_p_c, Ant_Pessoais= @Ant_Pessoais, Ant_Familiar= @Ant_Familiar, OD_Esferico= @OD_Esferico,
                                                            OE_Esferico= @OE_Esferico, OD_Cilindrico= @OD_Cilindrico, OE_Cilindrico= @OE_Cilindrico, 
                                                            OD_Eixo= @OD_Eixo, OE_Eixo= @OE_Eixo, Adicao= @Adicao, OD_Av= @OD_Av, OD_P_P= @OD_P_P,
                                                            OE_Av= @OE_Av, OE_P_P= @OE_P_P, OD_CC= @OD_CC, OD_P_P_CC= @OD_P_P_CC, OE_CC= @OE_CC,
                                                            OE_P_P_CC= @OE_P_P_CC, Seg_Posterior= @Seg_Posterior, Seg_Anterior= @Seg_Anterior,
                                                            ativo= @ativo, id_cliente= @id_cliente, id_consulta= @id_consulta where id_anamnese = @id";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                // OBJETOS QUE IRAM RECEBER OS DADOS E PASSAR PARA O BANCO DE DADOS
                ExecutaComando.Parameters.AddWithValue("@m_p_c", obj.m_p_c);
                ExecutaComando.Parameters.AddWithValue("@ant_pessoais", obj.ant_Pessoais);
                ExecutaComando.Parameters.AddWithValue("@Ant_Familiar", obj.ant_Familiar);
                ExecutaComando.Parameters.AddWithValue("@OD_Esferico", obj.oD_Esferico);
                ExecutaComando.Parameters.AddWithValue("@OE_Esferico", obj.oE_Esferico);
                ExecutaComando.Parameters.AddWithValue("@OD_Cilindrico", obj.oD_Cilindrico);
                ExecutaComando.Parameters.AddWithValue("@OE_Cilindrico", obj.oE_Cilindrico);
                ExecutaComando.Parameters.AddWithValue("@OD_Eixo", obj.oD_Eixo);
                ExecutaComando.Parameters.AddWithValue("@OE_Eixo", obj.oE_Eixo);
                ExecutaComando.Parameters.AddWithValue("@Adicao", obj.adicao);
                ExecutaComando.Parameters.AddWithValue("@OD_Av", obj.oD_Av);
                ExecutaComando.Parameters.AddWithValue("@OD_P_P", obj.oD_P_P);
                ExecutaComando.Parameters.AddWithValue("@OE_Av", obj.oE_Av);
                ExecutaComando.Parameters.AddWithValue("@OE_P_P", obj.oE_P_P);
                ExecutaComando.Parameters.AddWithValue("@OD_CC", obj.oD_CC);
                ExecutaComando.Parameters.AddWithValue("@OD_P_P_CC", obj.oD_P_P_CC);
                ExecutaComando.Parameters.AddWithValue("@OE_CC", obj.oE_CC);
                ExecutaComando.Parameters.AddWithValue("@OE_P_P_CC", obj.oE_P_P_CC);
                ExecutaComando.Parameters.AddWithValue("@Seg_Posterior", obj.seg_Posterior);
                ExecutaComando.Parameters.AddWithValue("@Seg_Anterior", obj.seg_Anterior);
                ExecutaComando.Parameters.AddWithValue("@ativo", obj.ativo);
                ExecutaComando.Parameters.AddWithValue("@id_cliente", obj.IdCliente);
                ExecutaComando.Parameters.AddWithValue("@id_consulta", obj.IdConsulta);

                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }

        }

        #endregion

        #region Metodo de deletar anamnese
        public void ExcluirAnamnese(AvalicaoMODEL obj)
        {
            try
            {
                string Comando = @" DELETE tbl_anamnese where id_anamnese = @id_anamnese";

                SqlCommand ExecutaComando = new SqlCommand(Comando, conexao);

                // OBJETOS QUE IRAM RECEBER OS DADOS E PASSAR PARA O BANCO DE DADOS
                ExecutaComando.Parameters.AddWithValue("@id_anamnese", obj.IdAnamnese);

                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Dados excluido com sucesso!");

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
