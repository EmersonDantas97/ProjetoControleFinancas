using Gestor.Classes;
using System;
using System.Windows.Forms;

namespace Gestor
{
    public partial class frmCadastroCartao : Form
    {
        public frmCadastroCartao()
        {
            InitializeComponent();
            CriandoDicasFerramentas();
            CarregaGrid();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var c = new Cartao.Unit();
            c.CadastrarCartao(txtNomeCartao.Text.Trim());
            MessageBox.Show("Cadastro realizado com sucesso!", "Registro salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregaGrid();
            LimpaCampo();
        }

        public void LimpaCampo()
        {
            txtNomeCartao.Text = "";
        }

        private void CriandoDicasFerramentas()
        {
            // Instanciando classe ToolTip para ser criadas as dicas de ferramentas.
            ToolTip dicaFerramenta = new ToolTip();

            // Criando dica de ferramenta para o botão.
            dicaFerramenta.SetToolTip(btnSalvar, "Tecla de atalho F1");
            dicaFerramenta.SetToolTip(btnExcluir, "Tecla de atalho F2");
            dicaFerramenta.SetToolTip(btnNovo, "Tecla de atalho F3");
        }

        private void frmCadastroCartao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnSalvar.PerformClick();

            if (e.KeyCode == Keys.F2)
                btnExcluir.PerformClick();

            if (e.KeyCode == Keys.F3)
                btnNovo.PerformClick();

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        public void CarregaGrid()
        {
            dgvCartoes.DataSource = Cartao.Unit.TrazerCartoesCadastrados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Deseja excluir o cartão selecionado na grid?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (R == DialogResult.Yes)
            {
                string linha = dgvCartoes.SelectedRows[0].Cells[0].Value.ToString();
                Cartao.Unit.ExcluirRegistro(linha);
                MessageBox.Show("Registro EXCLUÍDO com sucesso!", "Registro salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
                LimpaCampo();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            txtNomeCartao.Focus();
        }
    }
}
