namespace Gestor
{
    partial class frmRecebimentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvCartoes = new System.Windows.Forms.DataGridView();
            this.txtNomeRecebimento = new System.Windows.Forms.TextBox();
            this.lblNomeCartao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDataRecebimento = new System.Windows.Forms.TextBox();
            this.lblRecebido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartoes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // dgvCartoes
            // 
            this.dgvCartoes.AllowUserToAddRows = false;
            this.dgvCartoes.AllowUserToDeleteRows = false;
            this.dgvCartoes.AllowUserToOrderColumns = true;
            this.dgvCartoes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCartoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartoes.Location = new System.Drawing.Point(11, 53);
            this.dgvCartoes.Name = "dgvCartoes";
            this.dgvCartoes.ReadOnly = true;
            this.dgvCartoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartoes.Size = new System.Drawing.Size(407, 214);
            this.dgvCartoes.TabIndex = 2;
            // 
            // txtNomeRecebimento
            // 
            this.txtNomeRecebimento.Location = new System.Drawing.Point(81, 26);
            this.txtNomeRecebimento.Name = "txtNomeRecebimento";
            this.txtNomeRecebimento.Size = new System.Drawing.Size(160, 20);
            this.txtNomeRecebimento.TabIndex = 4;
            // 
            // lblNomeCartao
            // 
            this.lblNomeCartao.AutoSize = true;
            this.lblNomeCartao.Location = new System.Drawing.Point(81, 10);
            this.lblNomeCartao.Name = "lblNomeCartao";
            this.lblNomeCartao.Size = new System.Drawing.Size(101, 13);
            this.lblNomeCartao.TabIndex = 3;
            this.lblNomeCartao.Text = "Nome Recebimento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(91, 277);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(172, 277);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(253, 277);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(247, 10);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(247, 26);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(83, 20);
            this.txtValor.TabIndex = 4;
            // 
            // txtDataRecebimento
            // 
            this.txtDataRecebimento.Location = new System.Drawing.Point(335, 26);
            this.txtDataRecebimento.Name = "txtDataRecebimento";
            this.txtDataRecebimento.Size = new System.Drawing.Size(83, 20);
            this.txtDataRecebimento.TabIndex = 9;
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Location = new System.Drawing.Point(335, 10);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(73, 13);
            this.lblRecebido.TabIndex = 8;
            this.lblRecebido.Text = "Recebido em:";
            // 
            // frmRecebimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 313);
            this.Controls.Add(this.txtDataRecebimento);
            this.Controls.Add(this.lblRecebido);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNomeRecebimento);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNomeCartao);
            this.Controls.Add(this.dgvCartoes);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmRecebimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Recebimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvCartoes;
        private System.Windows.Forms.TextBox txtNomeRecebimento;
        private System.Windows.Forms.Label lblNomeCartao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDataRecebimento;
        private System.Windows.Forms.Label lblRecebido;
    }
}