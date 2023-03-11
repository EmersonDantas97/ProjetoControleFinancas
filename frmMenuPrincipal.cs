using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
