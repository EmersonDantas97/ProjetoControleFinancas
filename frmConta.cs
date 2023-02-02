using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
            cmbCartao.Items.Add("NU BANK");
            cmbCartao.Items.Add("WILL BANK");
            cmbCartao.Items.Add("C6 BANK");
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
            cmbTipoConta.Items.Add("Farmácia".ToUpper());
            cmbTipoConta.Items.Add("Mercado".ToUpper());
            cmbTipoConta.Items.Add("Combustível".ToUpper());
            cmbTipoConta.Items.Add("Lazer".ToUpper());
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

                double valor = Convert.ToDouble(a);

                txtValor.Text = valor.ToString("C");
            }

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            novoCadastro();
        }

        public void novoCadastro()
        {
            txtCodigo.Text = "000000";
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

        private void cmbParcelaAtual_Leave(object sender, EventArgs e)
        {
            cmbQtdeParcelas.Items.Clear();

            for (int i = 1; i <= Convert.ToInt32(cmbParcelaAtual.Text); i++)
                cmbQtdeParcelas.Items.Add(i.ToString());
        }
    }
}
