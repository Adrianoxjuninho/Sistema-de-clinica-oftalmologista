using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_infuture.Apresentação
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Painel2.Width += 3;

            if(Painel2.Width >= 599)
            {
                timer1.Stop();
                this.Visible = false;
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
