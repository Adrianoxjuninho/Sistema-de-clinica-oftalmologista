using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.ConexaoDall;

namespace system_infuture.Apresentação
{
    public partial class FrmConsulta : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();        

        public FrmConsulta()
        {
            InitializeComponent();
            conexao.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgenda FormAgentamento = new FrmAgenda();
            FormAgentamento.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadCliente CadastroDePaciente = new FrmCadCliente();
            CadastroDePaciente.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //avaliacao FichaDeAvaliacao = new avaliacao();
            //FichaDeAvaliacao.ShowDialog();
            //Form1 form = new Form1();
            //form.ShowDialog();
        }

        private void consulta_Load(object sender, EventArgs e)
        {
            AvaliacaoDAO dAO = new AvaliacaoDAO();
            dg1.DataSource = dAO.ListarClientes();
            conexao.Close();
        }

        private void dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdCliente  = dg1.SelectedCells[0].Value.ToString();
            string NomeCliente = dg1.SelectedCells[1].Value.ToString();
            string IdConsulta = dg1.SelectedCells[8].Value.ToString();
            string ativo = dg1.SelectedCells[7].Value.ToString();

            FrmAvaliacao avaliacao = new FrmAvaliacao(IdCliente, NomeCliente, IdConsulta, ativo);
            avaliacao.Show();
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
