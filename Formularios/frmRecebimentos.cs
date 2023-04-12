using System;
using System.Windows.Forms;

namespace Gestor
{
    public partial class frmRecebimentos : Form
    {
        public frmRecebimentos()
        {
            InitializeComponent();
        }
        private void frmRecebimentos_Load(object sender, EventArgs e)
        {
        }

        private void frmRecebimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
