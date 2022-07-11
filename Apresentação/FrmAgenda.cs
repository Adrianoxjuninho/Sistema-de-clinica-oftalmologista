using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.ConexaoDall;
using system_infuture.Model;

namespace system_infuture.Apresentação
{
    public partial class FrmAgenda : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public FrmAgenda()
        {
            InitializeComponent();
            conexao.Open();
        }

        #region Metodo de carregar o medico no formulario
        private void agentamento_Load(object sender, EventArgs e)
        {
            AgendaDAO dao = new AgendaDAO();
            Campo_idMedico.DataSource = dao.ListarMedico();

            Campo_idMedico.DisplayMember = "nome";
            Campo_idMedico.ValueMember = "id_medico";

            conexao.Close();
        }
        #endregion
        #region Metodo de buscar Paciente por cpf
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //1-Passo = Comando SQL para realizar a consulta no banco
                SqlCommand cmd = new SqlCommand("select * from tbl_cliente where cpf like '%" + Campo_Pesquisar.Text + "%'", conexao);

                //2-Passo = Definiar o Parametro de consulta
                cmd.Parameters.Add("@cpf", SqlDbType.Char).Value = Campo_Pesquisar.Text;
                conexao.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                //3-Passo = Definiar os campos a receber os dados do banco 
                Campo_idCliente.Text = rdr[0].ToString();
                tbNome.Text = rdr[1].ToString();
                tbTelefone.Text = rdr[5].ToString();
                Campo_Celular.Text = rdr[6].ToString();

                conexao.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show("!" + EX);
                //MessageBox.Show("CPF não encontrado, por favor digite um CPF valido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
            }
        }
        #endregion

        #region Metodo de salvar a consulta com cliente
        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agendamento obj = new Agendamento();

            obj.dt_consulta = DateTime.Parse(Campo_DataConsulta.Text);
            obj.horario = DateTime.Parse(Campo_Horario.Text);
            obj.retorno = Campo_Retorno.Text;
            obj.motivo_consulta = Campo_MotivoConsulta.Text;
            obj.ativo = cbAtivo.Text;
            // CHAVE PRIMARIA DO ID_CLIENTE 
            obj.id_cliente = int.Parse(Campo_idCliente.Text);
            obj.id_medico = int.Parse(Campo_idMedico.SelectedValue.ToString());

            AgendamentoDAO dAO = new AgendamentoDAO();
            dAO.CadastrarConsulta(obj);
        }
        #endregion
        #region Metodo de atalho, para voltar a tela principal
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmPrincipal().ShowDialog();
            this.Close();
        }
        #endregion
        #region Metodo de atalho, para ir para tela de consulta
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmConsulta().ShowDialog();
            this.Close();
        }
        #endregion
        #region Metodo de alterar a consulta
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento obj = new Agendamento();

            obj.dt_consulta = DateTime.Parse(Campo_DataConsulta.Text);
            obj.horario = DateTime.Parse(Campo_Horario.Text);
            obj.retorno = Campo_Retorno.Text;
            obj.motivo_consulta = Campo_MotivoConsulta.Text;
            obj.ativo = cbAtivo.Text;
            // CHAVE PRIMARIA DO ID_CLIENTE 
            obj.id_cliente = int.Parse(Campo_idCliente.Text);
            obj.id_medico = int.Parse(Campo_idMedico.SelectedValue.ToString());

            AgendamentoDAO dAO = new AgendamentoDAO();
            dAO.AlterarConsulta(obj);
        }
        #endregion
        #region Metodo de excluir a consulta
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento obj = new Agendamento();

            obj.dt_consulta = DateTime.Parse(Campo_DataConsulta.Text);
            obj.horario = DateTime.Parse(Campo_Horario.Text);
            obj.retorno = Campo_Retorno.Text;
            obj.motivo_consulta = Campo_MotivoConsulta.Text;
            obj.ativo = cbAtivo.Text;
            // CHAVE PRIMARIA DO ID_CLIENTE 
            obj.id_cliente = int.Parse(Campo_idCliente.Text);
            obj.id_medico = int.Parse(Campo_idMedico.SelectedValue.ToString());

            AgendamentoDAO dAO = new AgendamentoDAO();
            dAO.ExcluirCadastro(obj);
        }
        #endregion

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmCadCliente().ShowDialog();
            this.Close();
        }
    }
}