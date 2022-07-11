using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.ConexaoDall;

namespace system_infuture.Apresentação
{
    public partial class FrmReceberDados : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        protected String ID, Nome, Rg, Cpf, DataNascimento, Telefone, Celular, Bairro, endereco, Observacoes, Numero, Cidade;

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmConsulta().ShowDialog();
            this.Close();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmAgenda().ShowDialog();
            this.Close();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.CadCliente obj = new Model.CadCliente();

            obj.ID_Paciente = int.Parse(Campo_Codigo.Text = string.Empty);

            CadClienteDAO dAO = new CadClienteDAO();
            dAO.ExcluirCadastro(obj);
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo_Codigo.Text = string.Empty;
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

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //1 INSTANCIAR O MODEL.
            Model.CadCliente obj = new Model.CadCliente();

            //2 PASSO - DEFINIR OS CAMPOS, PARA RECEBEREM OS DADOS.
            obj.ID_Paciente = int.Parse( Campo_Codigo.Text);
            obj.nome = Campo_Nome.Text;
            obj.Rg = Campo_Rg.Text;
            obj.Cpf = Campo_Cpf.Text;
            obj.Dt_Nascimento = DateTime.Parse(campo_Dt_Nascimento.Text);
            obj.Telefone = Campo_Telefone.Text;
            obj.Celular = Campo_Celular.Text;
            obj.Bairro = Campo_Bairro.Text;
            obj.Endereco = Campo_endereco.Text;
            obj.Observacoes = Campo_Observacoes.Text;
            obj.Numero = int.Parse(Campo_Numero.Text);
            obj.Cidade = Campo_Cidade.Text;

            CadClienteDAO pacienteDAO = new CadClienteDAO();
            pacienteDAO.EditarCliente(obj);
        }

        private void FrmReceberDados_Load(object sender, EventArgs e)
        {
            Campo_Codigo.Text = ID;
            Campo_Nome.Text = Nome;
            Campo_Rg.Text = Rg;
            Campo_Cpf.Text = Cpf;
            campo_Dt_Nascimento.Text = DataNascimento;
            Campo_Telefone.Text = Telefone;
            Campo_Celular.Text = Celular;
            Campo_Bairro.Text = Bairro;
            Campo_endereco.Text = endereco;
            Campo_Observacoes.Text = Observacoes;
            Campo_Numero.Text = Numero;
            Campo_Cidade.Text = Cidade;
        }

        public FrmReceberDados(string IdCliente ,string NomeCliente,string RgCliente,string CpfCliente,string DataNascimentoCliente,string TelefoneCliente,string CelularCliente,string BairroCliente,string EnderecoCliente,string ObservacoesCliente,string NumeroCliente,string CidadeCliente)
        {
            InitializeComponent();

            ID = IdCliente;
            Nome = NomeCliente;
            Rg = RgCliente;
            Cpf = CpfCliente;
            DataNascimento = DataNascimentoCliente;
            Telefone = TelefoneCliente;
            Celular = CelularCliente;
            Bairro = BairroCliente;
            endereco = EnderecoCliente;
            Observacoes = ObservacoesCliente;
            Numero = NumeroCliente;
            Cidade = CidadeCliente;
        }

        private void Menu_BuscarCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmLocalizarCliente().ShowDialog();
            this.Close();
        }
    }
}
