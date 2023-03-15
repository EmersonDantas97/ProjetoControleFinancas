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

        private void tblRecebimentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblRecebimentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aCGestorDataSet);
        }

        private void frmRecebimentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aCGestorDataSet.tblRecebimentos'. Você pode movê-la ou removê-la conforme necessário.
            this.tblRecebimentosTableAdapter.Fill(this.aCGestorDataSet.tblRecebimentos);

        }

        private void frmRecebimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();


        }
    }
}
