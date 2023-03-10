using System;
using System.Windows.Forms;

namespace Gestor
{
    public partial class frmContasLancadas : Form
    {
        public frmContasLancadas()
        {
            InitializeComponent();
        }

        private void frmContasLancadas_Load(object sender, EventArgs e)
        {
            this.tblContaTableAdapter.Fill(this.aCGestorDataSet.tblConta);

        }

        private void dgv_ListagemContas_DoubleClick(object sender, EventArgs e)
        {

            DataGridViewRow Linha = new DataGridViewRow();
            Linha = dgv_ListagemContas.SelectedRows[0];

            string id = Linha.Cells[0].Value.ToString();

            MessageBox.Show(id.ToString());

        }
    }
}
