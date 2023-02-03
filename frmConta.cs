using System;
using System.Windows.Forms;


namespace Gestor
{
    public partial class frmContas : Form
    {
        public frmContas()
        {
            InitializeComponent();

            novoCadastro();

            #region Carregando opções de cartão
            cmbCartao.Items.Clear();
            cmbCartao.Items.Add("NU");
            cmbCartao.Items.Add("WILL");
            cmbCartao.Items.Add("C6");
            #endregion

            #region Carregando opções de parcelamento
            for (int i = 1; i < 50; i++)
            {
                cmbParcelaAtual.Items.Add(i.ToString());
                cmbQtdeParcelas.Items.Add(i.ToString());
            }
            #endregion

            #region Carregando opções de tipo de conta
            cmbTipoConta.Items.Clear();
            cmbTipoConta.Items.Add("FARMÁCIA".ToUpper());
            cmbTipoConta.Items.Add("MERCADO".ToUpper());
            cmbTipoConta.Items.Add("COMBUSTÍVEL".ToUpper());
            cmbTipoConta.Items.Add("LAZER".ToUpper());
            cmbTipoConta.Items.Add("FIXA");
            #endregion
        }


        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        /// <summary>
        /// String criada para retornar a data atual.
        /// </summary>
        /// <returns></returns>
        public string DataAtual()
        {
            return DateTime.Today.ToString("d");
        }

        void habilitaCampos()
        {
            if (rdbFixa.Checked || rdbParcelada.Checked || rdbEventual.Checked)
            {
                if (rdbCredito.Checked && rdbFixa.Checked)
                {
                    grpInformacoesAdicionais.Enabled = true;
                    cmbParcelaAtual.Enabled = false;
                    cmbQtdeParcelas.Enabled = false;
                }
                if ((rdbParcelada.Checked && rdbDinheiro.Checked) || (rdbParcelada.Checked && rdbDebito.Checked))
                {
                    grpInformacoesAdicionais.Enabled = true;
                    cmbParcelaAtual.Enabled = true;
                    cmbQtdeParcelas.Enabled = true;
                    cmbCartao.Enabled = false;
                }
                if (rdbFixa.Checked && rdbCredito.Checked)
                {
                    grpInformacoesAdicionais.Enabled = true;
                    cmbParcelaAtual.Enabled = false;
                    cmbQtdeParcelas.Enabled = false;
                    cmbCartao.Enabled = true;
                }
                if (rdbParcelada.Checked && rdbCredito.Checked)
                {
                    grpInformacoesAdicionais.Enabled = true;
                    cmbParcelaAtual.Enabled = true;
                    cmbQtdeParcelas.Enabled = true;
                    cmbCartao.Enabled = true;
                }
                if ((rdbFixa.Checked && rdbDinheiro.Checked) || (rdbFixa.Checked && rdbDebito.Checked))
                {
                    grpInformacoesAdicionais.Enabled = false;
                }
                if (rdbEventual.Checked && rdbCredito.Checked)
                {
                    grpInformacoesAdicionais.Enabled = true;
                    cmbParcelaAtual.Enabled = false;
                    cmbQtdeParcelas.Enabled = false;
                    cmbCartao.Enabled = true;
                }
                if ((rdbEventual.Checked && rdbDebito.Checked) || (rdbEventual.Checked && rdbDinheiro.Checked))
                {
                    grpInformacoesAdicionais.Enabled = false;
                }
            }
            else // Caso o usuario não tenha escolhido a duração
            {
                MessageBox.Show("Necessário escolher a DURAÇÃO da conta!", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (!(txtValor.Text == ""))
            {
                string a = txtValor.Text;

                double vlrTemp;

                if (double.TryParse(a, out vlrTemp))
                {
                    txtValor.Text = vlrTemp.ToString("F");
                }
            }

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            novoCadastro();
        }

        public void novoCadastro()
        {
            txtCodigo.Text = "000001";
            txtDataLancamento.Text = DateTime.Now.ToString();
            txtDataEmissao.Text = DataAtual();
            txtDataPagar.Text = DataAtual();
            txtConta.Text = "";
            txtValor.Text = "";
            txtObservacao.Text = "";

            cmbParcelaAtual.Text = "";
            cmbQtdeParcelas.Text = "";
            cmbTipoConta.Text = "";
            cmbCartao.Text = "";

            rdbCredito.Checked = false;
            rdbDebito.Checked = false;
            rdbDinheiro.Checked = false;
            rdbFixa.Checked = false;
            rdbEventual.Checked = false;
            rdbParcelada.Checked = false;

            grpInformacoesAdicionais.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {
            txtConta.Text = txtConta.Text.ToUpper();
        }

        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            txtObservacao.Text = txtObservacao.Text.ToUpper();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Conta.Unit c = new Conta.Unit();

            c.ConfirmarDepois = false;

            c.Id = Convert.ToInt32(txtCodigo.Text);
            c.DataLancamento = txtDataLancamento.Text;
            c.NomeConta = txtConta.Text;
            c.TipoConta = cmbTipoConta.Text;
            c.DataEmissao = txtDataEmissao.Text;
            c.DataPagar = txtDataPagar.Text;
            c.Observacao = txtObservacao.Text;

            c.QtdParcelas = cmbQtdeParcelas.SelectedIndex;
            c.ParcelaAtual = cmbParcelaAtual.SelectedIndex;
            c.Cartao = cmbCartao.SelectedIndex;

            if (rdbCredito.Checked)
                c.TipoPagamento = 1;
            if (rdbDebito.Checked)
                c.TipoPagamento = 0;
            if (rdbDinheiro.Checked)
                c.TipoPagamento = 2;

            if (chkLancamentoIncerto.Checked)
                c.ConfirmarDepois = true;

            if (rdbEventual.Checked)
                c.Duracao = 0;
            if (rdbFixa.Checked)
                c.Duracao = 1;
            if (rdbParcelada.Checked)
                c.Duracao = 2;

            string varJson = Conta.SerializarClasseUnit(c);

            Fichario f = new Fichario("D:\\FINANCAS\\GestorDados");

            f.Incluir(c.Id.ToString(),varJson);

            novoCadastro();

            MessageBox.Show("Conta salva com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
