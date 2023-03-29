using Gestor.Classes;
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
    public partial class frmCadastroCartao : Form
    {
        public frmCadastroCartao()
        {
            InitializeComponent();

            // Instanciando classe ToolTip para ser criadas as dicas de ferramentas.
            ToolTip dicaFerramenta = new ToolTip();

            // Criando dica de ferramenta para o botão.
            dicaFerramenta.SetToolTip(btnSalvar, "Tecla de atalho F1"); 
            dicaFerramenta.SetToolTip(btnExcluir, "Tecla de atalho F2"); 
            dicaFerramenta.SetToolTip(btnNovo, "Tecla de atalho F3"); 
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var c = new Cartao.Unit();
            c.CadastrarCartao(txtNomeCartao.Text.Trim());
            MessageBox.Show("Cadastro realizado com sucesso!", "Registro salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCadastroCartao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnSalvar.PerformClick();

            //if (e.KeyCode == Keys.F2)
            //    btnSalvar.PerformClick();

            //if (e.KeyCode == Keys.F3)
            //    btnSalvar.PerformClick();

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
