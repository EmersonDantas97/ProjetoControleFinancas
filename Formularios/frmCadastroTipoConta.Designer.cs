namespace Gestor.Formularios
{
    partial class frmCadastroTipoConta
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
            this.dgvTipoConta = new System.Windows.Forms.DataGridView();
            this.txtTipoConta = new System.Windows.Forms.TextBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoConta)).BeginInit();
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
            // dgvTipoConta
            // 
            this.dgvTipoConta.AllowUserToAddRows = false;
            this.dgvTipoConta.AllowUserToDeleteRows = false;
            this.dgvTipoConta.AllowUserToOrderColumns = true;
            this.dgvTipoConta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTipoConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoConta.Location = new System.Drawing.Point(11, 53);
            this.dgvTipoConta.Name = "dgvTipoConta";
            this.dgvTipoConta.ReadOnly = true;
            this.dgvTipoConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoConta.Size = new System.Drawing.Size(277, 214);
            this.dgvTipoConta.TabIndex = 2;
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.Location = new System.Drawing.Point(81, 26);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.Size = new System.Drawing.Size(206, 20);
            this.txtTipoConta.TabIndex = 4;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(81, 10);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(59, 13);
            this.lblTipoConta.TabIndex = 3;
            this.lblTipoConta.Text = "Tipo Conta";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(28, 278);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(109, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(190, 278);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmCadastroTipoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 313);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTipoConta);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.dgvTipoConta);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroTipoConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tipo de Conta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroTipoConta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvTipoConta;
        private System.Windows.Forms.TextBox txtTipoConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
    }
}