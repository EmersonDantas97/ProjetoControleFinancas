using Gestor.Classes;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Data;
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
            var Cartoes = Cartao.Unit.TrazerCartoesCadastrados();

            for (int i = 0; i < Cartoes.Rows.Count; i++)
            {
                cmbCartao.Items.Add(Cartoes.Rows[i][1].ToString());
            }
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
            // cmbTipoConta.DataSource = 
            #endregion

            #region Dica de ferramenta para os botões

            ToolTip dicaFerramenta = new ToolTip(); // Instanciando classe ToolTip para ser criadas as dicas de ferramentas.
            dicaFerramenta.SetToolTip(btnSalvar, "Tecla de atalho F1"); // Criando dica de ferramenta para o botão.
            dicaFerramenta.SetToolTip(btnSair, "Tecla de atalho F2"); // Criando dica de ferramenta para o botão.
            dicaFerramenta.SetToolTip(btnLimpar, "Tecla de atalho F3"); // Criando dica de ferramenta para o botão.
            dicaFerramenta.SetToolTip(btnExcluir, "Tecla de atalho F4"); // Criando dica de ferramenta para o botão.


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

            string codigo = Conta.Unit.UltimoCodigo();

            txtCodigo.Text = codigo;
            txtDataLancamento.Text = DateTime.Now.ToString();
            txtDataLancamento.Text = "";
            txtDataEmissao.Text = Util.DataAtual();
            txtDataPagar.Text = DateTime.Now.AddDays(30).ToString("d");
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
            Conta.Unit c = LeituraFormulario();

            if (c.ValidaClasse())
            {
                c.Salvar();
                MessageBox.Show("Conta salva com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                novoCadastro();
            }
            else
            {
                MessageBox.Show("Para proceder com o salvamento da conta, é necessário pelo menos preencher as informações: Id, Nome da Conta e Valor da Conta.", "Impossível salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PreencheFormulario(Conta.Unit c)
        {

            this.txtCodigo.Text = c.Id;
            this.txtDataLancamento.Text = c.DataLancamento;
            this.txtConta.Text = c.NomeConta;
            this.txtValor.Text = c.ValorConta;
            this.cmbTipoConta.Text = c.TipoConta;
            this.txtObservacao.Text = c.Observacao;

            if (c.Duracao == "EVENTUAL")
                rdbEventual.Checked = true;
            if (c.Duracao == "FIXA")
                rdbFixa.Checked = true;
            if (c.Duracao == "PARCELADA")
                rdbParcelada.Checked = true;

            if (c.TipoPagamento == "CRÉDITO")
                rdbCredito.Checked = true;
            if (c.TipoPagamento == "DÉBITO")
                rdbDebito.Checked = true;
            if (c.TipoPagamento == "DINHEIRO")
                rdbDinheiro.Checked = true;

            if (c.ConfirmarDepois == "S")
                chkLancamentoIncerto.Checked = true;
            else
                chkLancamentoIncerto.Checked = false;

            if (c.Cartao != "-1")
                cmbCartao.Text = c.Cartao;


        }

        Conta.Unit LeituraFormulario()
        {
            var c = new Conta.Unit();

            c.ConfirmarDepois = "N";

            c.Id = txtCodigo.Text;
            c.DataLancamento = txtDataLancamento.Text;
            c.NomeConta = txtConta.Text;
            c.TipoConta = cmbTipoConta.Text;
            c.DataEmissao = txtDataEmissao.Text;
            c.DataPagar = txtDataPagar.Text;
            c.Observacao = txtObservacao.Text;
            c.ValorConta = txtValor.Text.Replace(",", ".");

            if (cmbQtdeParcelas.SelectedIndex == -1)
                c.QtdParcelas = "0";
            else
                c.QtdParcelas = cmbQtdeParcelas.Text;

            if (cmbParcelaAtual.SelectedIndex == -1)
                c.ParcelaAtual = "0";
            else
                c.ParcelaAtual = cmbParcelaAtual.Text;

            c.Cartao = cmbCartao.Text;

            if (rdbCredito.Checked)
                c.TipoPagamento = "CRÉDITO";
            if (rdbDebito.Checked)
                c.TipoPagamento = "DÉBITO";
            if (rdbDinheiro.Checked)
                c.TipoPagamento = "DINHEIRO";

            if (chkLancamentoIncerto.Checked)
                c.ConfirmarDepois = "S";
            else
                c.ConfirmarDepois = "N";

            if (rdbEventual.Checked)
                c.Duracao = "EVENTUAL";
            if (rdbFixa.Checked)
                c.Duracao = "FIXA";
            if (rdbParcelada.Checked)
                c.Duracao = "PARCELADA";

            return c;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!(this.txtCodigo.Text == Conta.Unit.UltimoCodigo()))
            {
                PreencheFormulario(Conta.Unit.Buscar(this.txtCodigo.Text));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja prosseguir com a exclusão deste registro?", "Confirmação", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Conta.Unit.ExcluirConta(this.txtCodigo.Text);
                MessageBox.Show("Registro excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                novoCadastro();
            }
        }

        private void frmContas_KeyDown(object sender, KeyEventArgs e) // Quando pressionado alguma tecla do formulario, este evento será acionado.
        {

            if (e.KeyCode == Keys.Escape) // Comparando se a tecla que foi pressionada é igual ao parâmetro passado.
                this.Close(); // Comando para Fechar a aplicação.

            if (e.KeyCode == Keys.F1) // Comparando se a tecla que foi pressionada é igual ao parâmetro passado.
                this.btnSalvar.PerformClick(); // Chamando o evento de clique no botão.

            if (e.KeyCode == Keys.F2) // Comparando se a tecla que foi pressionada é igual ao parâmetro passado.
                this.btnSair.PerformClick();// Chamando o evento de clique no botão.

            if (e.KeyCode == Keys.F3) // Comparando se a tecla que foi pressionada é igual ao parâmetro passado.
                this.btnLimpar.PerformClick();// Chamando o evento de clique no botão.

            if (e.KeyCode == Keys.F4) // Comparando se a tecla que foi pressionada é igual ao parâmetro passado.
                this.btnExcluir.PerformClick();// Chamando o evento de clique no botão.

        }
    }
}

// TODO 01: ADICIONAR MENU QUE SE ABRE COM O CLIQUE DO BOTÃO ESQUERDO. COLOCAR OPÇÕES:
// 01. PAGAR, 01.1 REMOVER REMOVER PAGAMENTO, 02. EXCLUIR, 03. MOVER PRÓXIMO MÊS.

// TODO 02: COLOCAR CHECK BOX PARA QUE SEJA CONCATENADO POR CARTÃO SOMANDO TODOS OS VALORES.

// TODO 03: COLOCAR DISTINÇÃO DOS QUE PRECISAM AINDA DE CONFIRMAÇÃO.

