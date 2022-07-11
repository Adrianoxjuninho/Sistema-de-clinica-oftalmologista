using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using system_infuture.conexao;
using system_infuture.ConexaoDall;
using system_infuture.Model;

namespace system_infuture.Apresentação
{
    public partial class FrmAvaliacao : Form
    {
        SqlConnection conexao = ConnectionFactory.GetConnection();
        protected String linha0, linha1, linha2, linha3;

        public FrmAvaliacao(string IdCliente, string NomeCliente, string IdConsulta, string ativo)
        {
            linha0 = IdCliente;
            linha1 = NomeCliente;
            linha2 = IdConsulta;
            linha3 = ativo;
            InitializeComponent();
            conexao.Open();
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AvalicaoMODEL obj = new AvalicaoMODEL();
            // RECEBENDO OS DADOS DA TEXBOX DA TABELA ANAMNESE, PASSANDO PARA O OBJET.
            obj.m_p_c = tbM_P_C.Text;
            obj.ant_Pessoais = tbAnt_Pessoais.Text;
            obj.ant_Familiar = tbAnt_Familiar.Text;
            obj.oD_Esferico = tbEsferico.Text;
            obj.oE_Esferico = tbEsfericoEsquerdo.Text;
            obj.oD_Cilindrico = tbCilindrico.Text;
            obj.oE_Cilindrico = tbCilindricoEsquerdo.Text;
            obj.oD_Eixo = tbEixo.Text;
            obj.oE_Eixo = tbEixoEsquerdo.Text;
            obj.adicao = tbAdicao.Text;
            obj.oD_Av = tbAvOD.Text;
            obj.oD_P_P = tbAVCCP_P_OD.Text;
            obj.oE_Av = tbAvOE.Text;
            obj.oE_P_P = tbP_P_OE.Text;
            obj.oD_CC = tbAVCC_OD.Text;
            obj.oD_P_P_CC = tbAVCCP_P_OD.Text;
            obj.oE_CC = tbAVCC_OE.Text;
            obj.oE_P_P_CC = tbAVCC_P_P_OE.Text;
            obj.seg_Posterior = tbSG_Posterior.Text;
            obj.seg_Anterior = tb_SG_Anterior.Text;
            obj.ativo = txtStatus.Text;

            //CHAVES ESTRANGEIRAS 
            obj.IdCliente = int.Parse(txIdCliente.Text);
            obj.IdConsulta = int.Parse(txIdConsulta.Text);
            // FIM DOS CAMPOS DA TABELA ANAMNESE

            ReceitaMODEL obj2 = new ReceitaMODEL();
            // RECEBENDO OS DADOS DA TEXBOX DA TABELA RECEITA, PASSANDO PARA O OBJET.
            obj2.longe_od_esferico = txtEsfericoOD.Text;
            obj2.longe_oe_esferico = txtEsfericoOE.Text;
            obj2.od_cilindrico = txtCilindricoOD.Text;
            obj2.oe_cilindrico = txtCilindricoOE.Text;
            obj2.od_eixo = txtEixoOD.Text;
            obj2.oe_eixo = txtEixoOE.Text;
            obj2.perto_od_esferico = txtEsfericoPertoOD.Text;
            obj2.perto_oe_esferico = txtEsfericoPertoOE.Text;
            obj2.perto_od_cilindrico = txtCilindricoOD.Text;
            obj2.perto_oe_cilindrico = txtCilindricoOE.Text;
            obj2.adicao = txtAdicao.Text;
            obj2.observacoes = txtObservacoesReceita.Text;
            obj2.ativo = txtStatus.Text;

            //CHAVES ESTRANGEIRAS
            obj2.IdCliente = int.Parse(txIdCliente.Text);
            obj2.IdConsulta = int.Parse(txIdConsulta.Text);
            // FIM DOS CAMPOS DA TABELA RECEITA

            EncaminhamentoMODEL obj3 = new EncaminhamentoMODEL();
            //RECEBENDO OS DADOS DA TEXBOX DA TABELA ENCAMINHAMENTO, PASSANDO PARA O OBJET

            obj3.observacoes = txtObservacoesReceita.Text;
            obj3.ativo = txtStatus.Text;

            //CHAVES ESTRANGEIRAS   
            obj3.IdCliente = int.Parse(txIdCliente.Text);
            obj3.IdConsulta = int.Parse(txIdConsulta.Text);

            //Avaliação + executar comando para salvar no banco de dados
            AvaliacaoDAO avaliacao = new AvaliacaoDAO();
            avaliacao.CadastrarAnamnese(obj);

            // Receita + executar comando para salvar no banco de dados
            ReceitaDAO receita = new ReceitaDAO();
            receita.CadastrarReceita(obj2);

            //Encaminhamento + executar comando para salvar no banco de dados
            EncamminhamentoDAO encamminhamento = new EncamminhamentoDAO();
            encamminhamento.CadastrarEncaminhamento(obj3);

            Agendamento obj4 = new Agendamento();

            obj4.ativo = txtStatus.Text;
            obj4.id_consulta = int.Parse(txIdConsulta.Text);

            statusDAO status = new statusDAO();
            status.atualizarstatus(obj4);
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda frmAgenda = new FrmAgenda();
            frmAgenda.Show();
        }

        private void Cadastro_menu_Click(object sender, EventArgs e)
        {
            FrmCadCliente cadCliente = new FrmCadCliente();
            cadCliente.Show();
        }

        private void avaliacao_Load(object sender, EventArgs e)
        {
            txIdCliente.Text = linha0;
            txNome.Text = linha1;
            txIdConsulta.Text = linha2;
            NomePaciente.Text = linha1;
            txtCodigoavaliacao.Text = linha0;
            txtEncaminhamentoNome.Text = linha1;
            txtStatus.Text = linha3;
        }
    }
}
