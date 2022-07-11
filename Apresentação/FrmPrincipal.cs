using System;
using System.Threading;
using System.Windows.Forms;
using system_infuture.Apresentação;

namespace system_infuture
{
    public partial class FrmPrincipal : Form
    {
        Thread logar;

        public FrmPrincipal()
        {
            InitializeComponent();
            label2.Text = $"Seja bem-vindo(a) {Apresentação.FrmLogin.usuarioConectado }";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            logar = new Thread(Login);
            logar.SetApartmentState(ApartmentState.STA);
            logar.Start();
        }

        private void Login()
        {
            Application.Run(new FrmLogin());
        }

        private void cadastroPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Admin" )
            {
                FrmCadCliente CadastroDePaciente = new FrmCadCliente();
                CadastroDePaciente.Show();
            }
            else
            {
                cadastroToolStripMenuItem.Enabled = false;
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta formConsulta = new FrmConsulta();
            formConsulta.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda FormAgendamento = new FrmAgenda();
            FormAgendamento.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario CadastroDeUsuario = new FrmUsuario();
            CadastroDeUsuario.ShowDialog();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalizarCliente HistoricoPaciente = new FrmLocalizarCliente();
            HistoricoPaciente.ShowDialog();
        }
    }
}
