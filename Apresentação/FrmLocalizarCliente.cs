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
using system_infuture.Model;

namespace system_infuture.Apresentação
{
    public partial class FrmLocalizarCliente : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();

        public FrmLocalizarCliente()
        {
            InitializeComponent();
            conexao.Open();
        }

        protected void FrmLocalizarCliente_Load(object sender, EventArgs e)
        {
            // referencia do DataGridView dos clientes
            LocalizarDAO dAO = new LocalizarDAO();
            dg1.DataSource = dAO.ListarClientes();

            // Referencia dos nomes carregados pelo ComoBox
            LocalizarDAO dAO1 = new LocalizarDAO();
            ComoBox.DataSource = dAO1.FiltroSql();

            //carrega as informacoes no combo
            ComoBox.DisplayMember = "COLUMN_NAME";
            ComoBox.ValueMember = "COLUMN_NAME";

            conexao.Close();
        }
        #region Metodo de passar os dados do DataGridView para formulario de cadastro
        protected void dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdCliente = dg1.CurrentRow.Cells[0].Value.ToString();
            string NomeCliente = dg1.CurrentRow.Cells[1].Value.ToString();
            string RgCliente = dg1.CurrentRow.Cells[2].Value.ToString();
            string CpfCliente = dg1.CurrentRow.Cells[3].Value.ToString();
            string DataNascimentoCliente = dg1.CurrentRow.Cells[4].Value.ToString();
            string TelefoneCliente = dg1.CurrentRow.Cells[5].Value.ToString();
            string CelularCliente = dg1.CurrentRow.Cells[6].Value.ToString();
            string BairroCliente = dg1.CurrentRow.Cells[7].Value.ToString();
            string EnderecoCliente = dg1.CurrentRow.Cells[8].Value.ToString();
            string ObservacoesCliente = dg1.CurrentRow.Cells[10].Value.ToString();
            string NumeroCliente = dg1.CurrentRow.Cells[9].Value.ToString();
            string CidadeCliente = dg1.CurrentRow.Cells[11].Value.ToString();

            // Carregando o DataGridView com os dados e passando para o formulario de cadastro, e fechando o mesmo.
            this.Visible = false;
            FrmReceberDados frmReceber = new FrmReceberDados( IdCliente ,NomeCliente, RgCliente, CpfCliente, DataNascimentoCliente, TelefoneCliente, CelularCliente, BairroCliente, EnderecoCliente, ObservacoesCliente, NumeroCliente, CidadeCliente);
            frmReceber.ShowDialog();
            this.Close();
        }
        #endregion
        #region Metodo de buscar cliente no banco
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string sql_query = @" SELECT id_cliente 'Codigo', nome 'Nome', rg 'Rg', cpf 'CPF', dt_Nascimento 'Data de Nascimento',
                                         telefone 'Telefone', celular 'Celular', bairro 'Bairro', cidade, numero, endereco, observacoes 
                                                                         
                                                           FROM tbl_cliente where " + ComoBox.Text + " like '%" + conteudo.Text + "%'";

            SqlDataAdapter data = new SqlDataAdapter(sql_query, conexao);
            DataSet tabela = new DataSet();
            SqlCommandBuilder cmd = new SqlCommandBuilder(data);
            data.Fill(tabela);
            dg1.DataSource = tabela.Tables[0];
        }
        #endregion
        #region Metodo de fechar o formulario
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
