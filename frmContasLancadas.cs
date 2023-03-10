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
    public partial class frmContasLancadas : Form
    {
        public frmContasLancadas()
        {
            InitializeComponent();
        }

        private void frmContasLancadas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aCGestorDataSet.tblConta'. Você pode movê-la ou removê-la conforme necessário.
            this.tblContaTableAdapter.Fill(this.aCGestorDataSet.tblConta);

        }
    }
}
