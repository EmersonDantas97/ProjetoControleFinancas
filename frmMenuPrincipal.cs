using System;
using System.Windows.Forms;

namespace Gestor
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContas f = new frmContas();
            f.MdiParent = this;
            f.Show();
        }

        private void contasLançadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasLancadas f = new frmContasLancadas();
            f.MdiParent = this;
            f.Show();
        }

        private void recebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecebimentos f = new frmRecebimentos();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
