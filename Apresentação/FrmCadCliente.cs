using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.ConexaoDall;
using system_infuture.Model;

namespace system_infuture.Apresentação
{
    public partial class FrmCadCliente : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public FrmCadCliente()
        {
            InitializeComponent();
        }

        #region Método de pesquisar Paciente no Banco de Dados
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Model.CadCliente obj = new Model.CadCliente();

            obj.nome = Campo_Nome.Text = string.Empty;

            CadClienteDAO dAO = new CadClienteDAO();
            dAO.ListarTodosCliente(obj);
        }
        #endregion

        #region Metodo de fechar a janela do modo cadastro de cliente
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodo de salvar o cadastro do cliente 
        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //1 INSTANCIAR O MODEL.
            Model.CadCliente obj = new Model.CadCliente();

            //2 PASSO - DEFINIR OS CAMPOS, PARA RECEBEREM OS DADOS.
            obj.nome = Campo_Nome.Text = string.Empty;
            obj.Rg = Campo_Rg.Text = string.Empty;
            obj.Cpf = Campo_Cpf.Text = string.Empty;
            obj.Dt_Nascimento = DateTime.Parse(campo_Dt_Nascimento.Text = string.Empty);
            obj.Telefone = Campo_Telefone.Text = string.Empty;
            obj.Celular = Campo_Celular.Text = string.Empty;
            obj.Bairro = Campo_Bairro.Text = string.Empty;
            obj.Endereco = Campo_endereco.Text = string.Empty;
            obj.Observacoes = Campo_Observacoes.Text = string.Empty;
            obj.Numero = int.Parse(Campo_Numero.Text = string.Empty);
            obj.Cidade = Campo_Cidade.Text = string.Empty;

            CadClienteDAO pacienteDAO = new CadClienteDAO();
            pacienteDAO.CadastrarPaciente(obj);
        }
        #endregion

        #region Metodo de excluir o cadastro do cliente
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.CadCliente obj = new Model.CadCliente();

            obj.ID_Paciente = int.Parse(Campo_Codigo.Text = string.Empty);

            CadClienteDAO dAO = new CadClienteDAO();
            dAO.ExcluirCadastro(obj);
        }
        #endregion

        #region Abertura do formulario de localizar o cliente
        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmLocalizarCliente().ShowDialog();
            this.Close();
        }
        #endregion

        #region Abertura do Formulario de Agendamento
        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmAgenda().ShowDialog();
            this.Close();
        }
        #endregion

        #region Abertura do Formulario de consulta
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmConsulta().ShowDialog();
            this.Close();
        }
        #endregion

        #region Metodo de limpar os campos
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo_Nome.Text = string.Empty;
            Campo_Rg.Text = string.Empty;
            Campo_Cpf.Text = string.Empty;
            campo_Dt_Nascimento.Text = string.Empty;
            Campo_Telefone.Text = string.Empty;
            Campo_Celular.Text = string.Empty;
            Campo_Bairro.Text = string.Empty;
            Campo_endereco.Text = string.Empty;
            Campo_Observacoes.Text = string.Empty;
            Campo_Numero.Text = string.Empty;
            Campo_Cidade.Text = string.Empty;
        }
        #endregion

    }
}
