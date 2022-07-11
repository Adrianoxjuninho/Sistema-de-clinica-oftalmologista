using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_infuture.Apresentação
{
    public partial class Form1 : Form
    {
        protected string m_p_c, ant_Pessoais, ant_Familiar, oD_Esferico, oE_Esferico, oD_Cilindrico, oE_Cilindrico, oD_Eixo, oE_Eixo, adicao, oD_Av, oD_P_P, oE_Av, oE_P_P, oD_CC, oD_P_P_CC, oE_CC, oE_P_P_CC, seg_Posterior, seg_Anterior, ativo;

        public Form1(string m_p_c, string ant_Pessoais, string ant_Familiar, string oD_Esferico, string oE_Esferico, string oD_Cilindrico, string oE_Cilindrico, string oD_Eixo, string oE_Eixo, string adicao, string oD_Av, string oD_P_P, string oE_Av, string oE_P_P, string oD_CC, string oD_P_P_CC, string oE_CC, string oE_P_P_CC, string seg_Posterior, string seg_Anterior, string ativo)
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            this.Width = Screen.PrimaryScreen.Bounds.Width;

            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
