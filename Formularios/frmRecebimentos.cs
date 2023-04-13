using Gestor.Classes;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Recebimento.Unit r = new Recebimento.Unit();
            r.DataLancamento = txtDataRecebimento.Text;
            r.Valor = txtValor.Text;
            r.Observacao = txtNomeRecebimento.Text;
            r.DataLancamento = Util.DataAtual();
            r.Salvar();
        }
    }
}
