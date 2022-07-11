using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.Model;

namespace system_infuture.ConexaoDall
{
    public class CadClienteDAO
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public CadClienteDAO()
        {
            //Abre a conexao
            conexao.Open();
        }

        #region Botão de cadastrar cliente
        public void CadastrarPaciente(CadCliente obj)
        {
            try
            {
                // 1 Passo - DEFINIR O COMADO SQL
                string comandosql = @"INSERT INTO tbl_cliente (nome, rg, cpf, dt_nascimento,telefone,celular,bairro,cidade,numero,endereco,observacoes) 
                                            VALUES (@nome,@rg,@cpf,@dt_nascimento,@telefone,@celular,@bairro,@cidade,@numero,@endereco,@observacoes)";

                //2 PASSO - EXECUTAR O COMANDO SQL
                SqlCommand sqlCommand = new SqlCommand(comandosql, conexao);

                //3 PASSO - RECEBER OS DADOS E PASSSAR PARA O BANCO DE DADOS
                sqlCommand.Parameters.AddWithValue("@nome", obj.nome);
                sqlCommand.Parameters.AddWithValue("@rg", obj.Rg);
                sqlCommand.Parameters.AddWithValue("@cpf", obj.Cpf);
                sqlCommand.Parameters.AddWithValue("@dt_nascimento", obj.Dt_Nascimento);
                sqlCommand.Parameters.AddWithValue("@telefone", obj.Telefone);
                sqlCommand.Parameters.AddWithValue("@celular", obj.Celular);
                sqlCommand.Parameters.AddWithValue("@bairro", obj.Bairro);
                sqlCommand.Parameters.AddWithValue("@cidade", obj.Cidade);
                sqlCommand.Parameters.AddWithValue("@numero", obj.Numero);
                sqlCommand.Parameters.AddWithValue("@endereco", obj.Endereco);
                sqlCommand.Parameters.AddWithValue("@observacoes", obj.Observacoes);

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

        #region Botão de alterar cadastro
        public void EditarCliente(CadCliente obj)
        {
            try
            {
                // 1 Passo - DEFINIR O COMADO SQL
                string comandosql = @"update tbl_cliente set nome= @nome, rg= @rg, cpf= @cpf, dt_nascimento= @dt_nascimento, telefone= @telefone,
                                                             celular= @celular, bairro= @bairro, cidade= @cidade, numero= @numero, endereco= @endereco,
                                                             observacoes= @observacoes

                                                              where id_cliente = @id_cliente";


                //2 PASSO - EXECUTAR O COMANDO SQL
                SqlCommand sqlCommand = new SqlCommand(comandosql, conexao);

                //3 PASSO - RECEBER OS DADOS E PASSSAR PARA O BANCO DE DADOS
                sqlCommand.Parameters.AddWithValue("@id_cliente", obj.ID_Paciente);
                sqlCommand.Parameters.AddWithValue("@nome", obj.nome);
                sqlCommand.Parameters.AddWithValue("@rg", obj.Rg);
                sqlCommand.Parameters.AddWithValue("@cpf", obj.Cpf);
                sqlCommand.Parameters.AddWithValue("@dt_nascimento", obj.Dt_Nascimento);
                sqlCommand.Parameters.AddWithValue("@telefone", obj.Telefone);
                sqlCommand.Parameters.AddWithValue("@celular", obj.Celular);
                sqlCommand.Parameters.AddWithValue("@bairro", obj.Bairro);
                sqlCommand.Parameters.AddWithValue("@cidade", obj.Cidade);
                sqlCommand.Parameters.AddWithValue("@numero", obj.Numero);
                sqlCommand.Parameters.AddWithValue("@endereco", obj.Endereco);
                sqlCommand.Parameters.AddWithValue("@observacoes", obj.Observacoes);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }
        }
        #endregion

        #region Botão de excluir cadastro
        public void ExcluirCadastro(CadCliente obj)
        {
            try
            {
                // 1 Passo - DEFINIR O COMADO SQL
                string comandosql = @"delet tbl_cliente where id_cliente = @id_cliente";


                //2 PASSO - EXECUTAR O COMANDO SQL
                SqlCommand sqlCommand = new SqlCommand(comandosql, conexao);

                //3 PASSO - RECEBER OS DADOS E PASSSAR PARA O BANCO DE DADOS
                sqlCommand.Parameters.AddWithValue("@id_cliente", obj.nome);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluido com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro :" + erro);
                conexao.Close();
            }
        }
        #endregion

        #region  Botão de Pesquisar Cliente
        public void ListarTodosCliente(CadCliente obj)
        {
            try
            {
                //1-Passo = Comando SQL para realizar a consulta no banco.
                string cmd = @"select cli.id_cliente 'Código', cli.nome 'Paciente', con.dt_consulta 'Data da consulta', con.horario 'Horario',+
                                                         con.retorno 'Retorno', con.motivo_da_consulta 'Motivo da consulta' 
                                                        from tbl_cliente as cli
                                                        join tbl_consulta as con on cli.id_cliente = con.id_cliente ";

                SqlCommand sqlCommand = new SqlCommand(cmd, conexao);

                //2-Passo = Definiar o Parametro de consulta
                sqlCommand.Parameters.AddWithValue("@nome", obj.nome);

                conexao.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Aconteceu um erro :" + EX);
                conexao.Close();
            }
        }

        #endregion
    }
}
