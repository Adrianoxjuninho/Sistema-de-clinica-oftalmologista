using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system_infuture.conexao;

namespace system_infuture.ConexaoDall
{
    public class HistoricoPacienteDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();
        public HistoricoPacienteDAO()
        {
            conexao.Open();
        }
        public DataTable ListarPaciente()
        {
                string sql_query = @"select cli.id_cliente 'Código', cli.nome 'Paciente',con.dt_consulta 'Data da consulta', con.horario 'Horario',med.nome 'Médico', con.retorno 'Retorno',
													con.motivo_da_consulta 'Motivo da consulta', rec.ativo 'Status', con.id_consulta 'FOREIGN',
													rec.longe_od_esferico 'OD Esferico', rec.longe_oe_esferico 'OE Esferico', rec.od_cilindrico 'OD Cilindrico',
													rec.oe_cilindrico 'OE Cilindrico',	rec.od_eixo 'OD Eixo', rec.oe_eixo 'OE Eixo' 

													from tbl_cliente as cli 
													join tbl_consulta con on cli.id_cliente=con.id_cliente
													join tbl_medico as med on med.id_cliente=cli.id_cliente
													join tbl_receita as rec on rec.id_cliente=cli.id_cliente";

                SqlCommand Comando = new SqlCommand(sql_query, conexao);
                Comando.ExecuteNonQuery();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Comando);
                DataTable ListarPaciente = new DataTable();

                sqlDataAdapter.Fill(ListarPaciente); 
                conexao.Close();

                return ListarPaciente;
        }
    }
}
