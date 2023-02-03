
namespace Gestor
{
    partial class frmContas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.txtDataLancamento = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpInformacoesGerais = new System.Windows.Forms.GroupBox();
            this.chkLancamentoIncerto = new System.Windows.Forms.CheckBox();
            this.grpPagamento = new System.Windows.Forms.GroupBox();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.grpDuracao = new System.Windows.Forms.GroupBox();
            this.rdbEventual = new System.Windows.Forms.RadioButton();
            this.rdbParcelada = new System.Windows.Forms.RadioButton();
            this.rdbFixa = new System.Windows.Forms.RadioButton();
            this.txtDataPagar = new System.Windows.Forms.TextBox();
            this.lblDataPagar = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.grpInformacoesAdicionais = new System.Windows.Forms.GroupBox();
            this.cmbQtdeParcelas = new System.Windows.Forms.ComboBox();
            this.cmbParcelaAtual = new System.Windows.Forms.ComboBox();
            this.cmbCartao = new System.Windows.Forms.ComboBox();
            this.lblCartao = new System.Windows.Forms.Label();
            this.lblQtdeParcelas = new System.Windows.Forms.Label();
            this.lblParcelaAtual = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpRegistro.SuspendLayout();
            this.grpInformacoesGerais.SuspendLayout();
            this.grpPagamento.SuspendLayout();
            this.grpDuracao.SuspendLayout();
            this.grpInformacoesAdicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.txtDataLancamento);
            this.grpRegistro.Controls.Add(this.txtCodigo);
            this.grpRegistro.Controls.Add(this.lblDataLancamento);
            this.grpRegistro.Controls.Add(this.lblCodigo);
            this.grpRegistro.Location = new System.Drawing.Point(12, 12);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(327, 71);
            this.grpRegistro.TabIndex = 0;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "REGISTRO";
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.Enabled = false;
            this.txtDataLancamento.Location = new System.Drawing.Point(167, 38);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Size = new System.Drawing.Size(154, 20);
            this.txtDataLancamento.TabIndex = 16;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(164, 21);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(81, 13);
            this.lblDataLancamento.TabIndex = 1;
            this.lblDataLancamento.Text = "LANÇAMENTO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO";
            // 
            // grpInformacoesGerais
            // 
            this.grpInformacoesGerais.Controls.Add(this.chkLancamentoIncerto);
            this.grpInformacoesGerais.Controls.Add(this.grpPagamento);
            this.grpInformacoesGerais.Controls.Add(this.grpDuracao);
            this.grpInformacoesGerais.Controls.Add(this.txtDataPagar);
            this.grpInformacoesGerais.Controls.Add(this.lblDataPagar);
            this.grpInformacoesGerais.Controls.Add(this.txtDataEmissao);
            this.grpInformacoesGerais.Controls.Add(this.lblDataEmissao);
            this.grpInformacoesGerais.Controls.Add(this.txtObservacao);
            this.grpInformacoesGerais.Controls.Add(this.lblObservacao);
            this.grpInformacoesGerais.Controls.Add(this.cmbTipoConta);
            this.grpInformacoesGerais.Controls.Add(this.lblTipoConta);
            this.grpInformacoesGerais.Controls.Add(this.txtValor);
            this.grpInformacoesGerais.Controls.Add(this.txtConta);
            this.grpInformacoesGerais.Controls.Add(this.lblValor);
            this.grpInformacoesGerais.Controls.Add(this.lblConta);
            this.grpInformacoesGerais.Location = new System.Drawing.Point(12, 89);
            this.grpInformacoesGerais.Name = "grpInformacoesGerais";
            this.grpInformacoesGerais.Size = new System.Drawing.Size(634, 247);
            this.grpInformacoesGerais.TabIndex = 4;
            this.grpInformacoesGerais.TabStop = false;
            this.grpInformacoesGerais.Text = "INFORMAÇÕES GERAIS";
            // 
            // chkLancamentoIncerto
            // 
            this.chkLancamentoIncerto.AutoSize = true;
            this.chkLancamentoIncerto.Location = new System.Drawing.Point(125, 155);
            this.chkLancamentoIncerto.Name = "chkLancamentoIncerto";
            this.chkLancamentoIncerto.Size = new System.Drawing.Size(409, 17);
            this.chkLancamentoIncerto.TabIndex = 20;
            this.chkLancamentoIncerto.Text = "LANÇAMENTO INCERTO, CONFIRMAR INFORMAÇÕES POSTERIORMENTE.";
            this.chkLancamentoIncerto.UseVisualStyleBackColor = true;
            // 
            // grpPagamento
            // 
            this.grpPagamento.Controls.Add(this.rdbDebito);
            this.grpPagamento.Controls.Add(this.rdbDinheiro);
            this.grpPagamento.Controls.Add(this.rdbCredito);
            this.grpPagamento.Location = new System.Drawing.Point(302, 183);
            this.grpPagamento.Name = "grpPagamento";
            this.grpPagamento.Size = new System.Drawing.Size(249, 47);
            this.grpPagamento.TabIndex = 19;
            this.grpPagamento.TabStop = false;
            this.grpPagamento.Text = "PAGAMENTO";
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Location = new System.Drawing.Point(100, 21);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(65, 17);
            this.rdbDebito.TabIndex = 10;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "DÉBITO";
            this.rdbDebito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbDebito.UseVisualStyleBackColor = true;
            this.rdbDebito.CheckedChanged += new System.EventHandler(this.rdbDebito_CheckedChanged);
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(16, 21);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(78, 17);
            this.rdbDinheiro.TabIndex = 9;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "DINHEIRO";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            this.rdbDinheiro.CheckedChanged += new System.EventHandler(this.rdbDinheiro_CheckedChanged);
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(171, 21);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(73, 17);
            this.rdbCredito.TabIndex = 11;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "CRÉDITO";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // grpDuracao
            // 
            this.grpDuracao.Controls.Add(this.rdbEventual);
            this.grpDuracao.Controls.Add(this.rdbParcelada);
            this.grpDuracao.Controls.Add(this.rdbFixa);
            this.grpDuracao.Location = new System.Drawing.Point(46, 183);
            this.grpDuracao.Name = "grpDuracao";
            this.grpDuracao.Size = new System.Drawing.Size(251, 47);
            this.grpDuracao.TabIndex = 6;
            this.grpDuracao.TabStop = false;
            this.grpDuracao.Text = "DURAÇÃO";
            // 
            // rdbEventual
            // 
            this.rdbEventual.AutoSize = true;
            this.rdbEventual.Location = new System.Drawing.Point(159, 21);
            this.rdbEventual.Name = "rdbEventual";
            this.rdbEventual.Size = new System.Drawing.Size(82, 17);
            this.rdbEventual.TabIndex = 3;
            this.rdbEventual.TabStop = true;
            this.rdbEventual.Text = "EVENTUAL";
            this.rdbEventual.UseVisualStyleBackColor = true;
            // 
            // rdbParcelada
            // 
            this.rdbParcelada.AutoSize = true;
            this.rdbParcelada.Location = new System.Drawing.Point(16, 21);
            this.rdbParcelada.Name = "rdbParcelada";
            this.rdbParcelada.Size = new System.Drawing.Size(89, 17);
            this.rdbParcelada.TabIndex = 1;
            this.rdbParcelada.TabStop = true;
            this.rdbParcelada.Text = "PARCELADA";
            this.rdbParcelada.UseVisualStyleBackColor = true;
            // 
            // rdbFixa
            // 
            this.rdbFixa.AutoSize = true;
            this.rdbFixa.Location = new System.Drawing.Point(108, 21);
            this.rdbFixa.Name = "rdbFixa";
            this.rdbFixa.Size = new System.Drawing.Size(48, 17);
            this.rdbFixa.TabIndex = 2;
            this.rdbFixa.TabStop = true;
            this.rdbFixa.Text = "FIXA";
            this.rdbFixa.UseVisualStyleBackColor = true;
            // 
            // txtDataPagar
            // 
            this.txtDataPagar.Location = new System.Drawing.Point(456, 79);
            this.txtDataPagar.Name = "txtDataPagar";
            this.txtDataPagar.Size = new System.Drawing.Size(172, 20);
            this.txtDataPagar.TabIndex = 4;
            // 
            // lblDataPagar
            // 
            this.lblDataPagar.AutoSize = true;
            this.lblDataPagar.Location = new System.Drawing.Point(456, 63);
            this.lblDataPagar.Name = "lblDataPagar";
            this.lblDataPagar.Size = new System.Drawing.Size(44, 13);
            this.lblDataPagar.TabIndex = 13;
            this.lblDataPagar.Text = "PAGAR";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Location = new System.Drawing.Point(301, 79);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(149, 20);
            this.txtDataEmissao.TabIndex = 3;
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(299, 63);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(55, 13);
            this.lblDataEmissao.TabIndex = 11;
            this.lblDataEmissao.Text = "EMISSAO";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(10, 123);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(618, 20);
            this.txtObservacao.TabIndex = 5;
            this.txtObservacao.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(8, 107);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(80, 13);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "OBSERVAÇÃO";
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Location = new System.Drawing.Point(8, 78);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(289, 21);
            this.cmbTipoConta.TabIndex = 2;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(5, 62);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(72, 13);
            this.lblTipoConta.TabIndex = 4;
            this.lblTipoConta.Text = "TIPO CONTA";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(480, 38);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(148, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(8, 38);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(466, 20);
            this.txtConta.TabIndex = 0;
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(477, 21);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "VALOR";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(8, 21);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(44, 13);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "CONTA";
            // 
            // grpInformacoesAdicionais
            // 
            this.grpInformacoesAdicionais.Controls.Add(this.cmbQtdeParcelas);
            this.grpInformacoesAdicionais.Controls.Add(this.cmbParcelaAtual);
            this.grpInformacoesAdicionais.Controls.Add(this.cmbCartao);
            this.grpInformacoesAdicionais.Controls.Add(this.lblCartao);
            this.grpInformacoesAdicionais.Controls.Add(this.lblQtdeParcelas);
            this.grpInformacoesAdicionais.Controls.Add(this.lblParcelaAtual);
            this.grpInformacoesAdicionais.Enabled = false;
            this.grpInformacoesAdicionais.Location = new System.Drawing.Point(12, 342);
            this.grpInformacoesAdicionais.Name = "grpInformacoesAdicionais";
            this.grpInformacoesAdicionais.Size = new System.Drawing.Size(634, 78);
            this.grpInformacoesAdicionais.TabIndex = 11;
            this.grpInformacoesAdicionais.TabStop = false;
            this.grpInformacoesAdicionais.Text = "INFORMAÇÕES ADICIONAIS";
            // 
            // cmbQtdeParcelas
            // 
            this.cmbQtdeParcelas.FormattingEnabled = true;
            this.cmbQtdeParcelas.Location = new System.Drawing.Point(105, 36);
            this.cmbQtdeParcelas.Name = "cmbQtdeParcelas";
            this.cmbQtdeParcelas.Size = new System.Drawing.Size(92, 21);
            this.cmbQtdeParcelas.TabIndex = 21;
            // 
            // cmbParcelaAtual
            // 
            this.cmbParcelaAtual.FormattingEnabled = true;
            this.cmbParcelaAtual.Location = new System.Drawing.Point(9, 36);
            this.cmbParcelaAtual.Name = "cmbParcelaAtual";
            this.cmbParcelaAtual.Size = new System.Drawing.Size(92, 21);
            this.cmbParcelaAtual.TabIndex = 20;
            // 
            // cmbCartao
            // 
            this.cmbCartao.FormattingEnabled = true;
            this.cmbCartao.Location = new System.Drawing.Point(201, 36);
            this.cmbCartao.Name = "cmbCartao";
            this.cmbCartao.Size = new System.Drawing.Size(424, 21);
            this.cmbCartao.TabIndex = 14;
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Location = new System.Drawing.Point(201, 21);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(51, 13);
            this.lblCartao.TabIndex = 7;
            this.lblCartao.Text = "CARTÃO";
            // 
            // lblQtdeParcelas
            // 
            this.lblQtdeParcelas.AutoSize = true;
            this.lblQtdeParcelas.Location = new System.Drawing.Point(104, 21);
            this.lblQtdeParcelas.Name = "lblQtdeParcelas";
            this.lblQtdeParcelas.Size = new System.Drawing.Size(96, 13);
            this.lblQtdeParcelas.TabIndex = 3;
            this.lblQtdeParcelas.Text = "QTDE PARCELAS";
            // 
            // lblParcelaAtual
            // 
            this.lblParcelaAtual.AutoSize = true;
            this.lblParcelaAtual.Location = new System.Drawing.Point(8, 21);
            this.lblParcelaAtual.Name = "lblParcelaAtual";
            this.lblParcelaAtual.Size = new System.Drawing.Size(94, 13);
            this.lblParcelaAtual.TabIndex = 0;
            this.lblParcelaAtual.Text = "PARCELA ATUAL";
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(345, 19);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(70, 64);
            this.bntSalvar.TabIndex = 12;
            this.bntSalvar.Text = "SALVAR";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(421, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 64);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(497, 19);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(70, 64);
            this.bntLimpar.TabIndex = 14;
            this.bntLimpar.Text = "LIMPAR";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(573, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 64);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 431);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.grpInformacoesAdicionais);
            this.Controls.Add(this.grpInformacoesGerais);
            this.Controls.Add(this.grpRegistro);
            this.Name = "frmContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTAS A PAGAR";
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.grpInformacoesGerais.ResumeLayout(false);
            this.grpInformacoesGerais.PerformLayout();
            this.grpPagamento.ResumeLayout(false);
            this.grpPagamento.PerformLayout();
            this.grpDuracao.ResumeLayout(false);
            this.grpDuracao.PerformLayout();
            this.grpInformacoesAdicionais.ResumeLayout(false);
            this.grpInformacoesAdicionais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.TextBox txtDataLancamento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpInformacoesGerais;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtDataPagar;
        private System.Windows.Forms.Label lblDataPagar;
        private System.Windows.Forms.TextBox txtDataEmissao;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.GroupBox grpInformacoesAdicionais;
        private System.Windows.Forms.Label lblParcelaAtual;
        private System.Windows.Forms.RadioButton rdbFixa;
        private System.Windows.Forms.RadioButton rdbParcelada;
        private System.Windows.Forms.ComboBox cmbCartao;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblQtdeParcelas;
        private System.Windows.Forms.GroupBox grpPagamento;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.GroupBox grpDuracao;
        private System.Windows.Forms.RadioButton rdbEventual;
        private System.Windows.Forms.ComboBox cmbQtdeParcelas;
        private System.Windows.Forms.ComboBox cmbParcelaAtual;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckBox chkLancamentoIncerto;
    }
}

