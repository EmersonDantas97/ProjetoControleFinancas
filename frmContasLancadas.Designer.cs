namespace Gestor
{
    partial class frmContasLancadas
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
            this.components = new System.ComponentModel.Container();
            this.tblContaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCGestorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCGestorDataSet = new Gestor.ACGestorDataSet();
            this.tblContaTableAdapter = new Gestor.ACGestorDataSetTableAdapters.tblContaTableAdapter();
            this.dgv_ListagemContas = new System.Windows.Forms.DataGridView();
            this.cntIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntNomeContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDescricaoCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntLancamentoIncertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntParcelaAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntObservacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntFormaPgtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDuracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblContaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCartaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCartaoTableAdapter = new Gestor.ACGestorDataSetTableAdapters.tblCartaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListagemContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblContaBindingSource
            // 
            this.tblContaBindingSource.DataMember = "tblConta";
            this.tblContaBindingSource.DataSource = this.aCGestorDataSetBindingSource;
            // 
            // aCGestorDataSetBindingSource
            // 
            this.aCGestorDataSetBindingSource.DataSource = this.aCGestorDataSet;
            this.aCGestorDataSetBindingSource.Position = 0;
            // 
            // aCGestorDataSet
            // 
            this.aCGestorDataSet.DataSetName = "ACGestorDataSet";
            this.aCGestorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblContaTableAdapter
            // 
            this.tblContaTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_ListagemContas
            // 
            this.dgv_ListagemContas.AllowUserToAddRows = false;
            this.dgv_ListagemContas.AllowUserToDeleteRows = false;
            this.dgv_ListagemContas.AllowUserToOrderColumns = true;
            this.dgv_ListagemContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListagemContas.AutoGenerateColumns = false;
            this.dgv_ListagemContas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ListagemContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListagemContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cntIdDataGridViewTextBoxColumn,
            this.cntNomeContaDataGridViewTextBoxColumn,
            this.cntValorDataGridViewTextBoxColumn,
            this.cntTipoDataGridViewTextBoxColumn,
            this.cntDescricaoCartaoDataGridViewTextBoxColumn,
            this.cntDataEmissaoDataGridViewTextBoxColumn,
            this.cntLancamentoIncertoDataGridViewTextBoxColumn,
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn,
            this.cntParcelaAtualDataGridViewTextBoxColumn,
            this.cntDataLancamentoDataGridViewTextBoxColumn,
            this.cntDataPagamentoDataGridViewTextBoxColumn,
            this.cntObservacaoDataGridViewTextBoxColumn,
            this.cntFormaPgtoDataGridViewTextBoxColumn,
            this.cntDuracaoDataGridViewTextBoxColumn});
            this.dgv_ListagemContas.DataSource = this.tblContaBindingSource1;
            this.dgv_ListagemContas.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_ListagemContas.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListagemContas.Name = "dgv_ListagemContas";
            this.dgv_ListagemContas.ReadOnly = true;
            this.dgv_ListagemContas.Size = new System.Drawing.Size(775, 426);
            this.dgv_ListagemContas.TabIndex = 0;
            this.dgv_ListagemContas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_ListagemContas_MouseDown);
            // 
            // cntIdDataGridViewTextBoxColumn
            // 
            this.cntIdDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Id";
            this.cntIdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cntIdDataGridViewTextBoxColumn.Name = "cntIdDataGridViewTextBoxColumn";
            this.cntIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntNomeContaDataGridViewTextBoxColumn
            // 
            this.cntNomeContaDataGridViewTextBoxColumn.DataPropertyName = "Cnt_NomeConta";
            this.cntNomeContaDataGridViewTextBoxColumn.HeaderText = "Nome Conta";
            this.cntNomeContaDataGridViewTextBoxColumn.Name = "cntNomeContaDataGridViewTextBoxColumn";
            this.cntNomeContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntValorDataGridViewTextBoxColumn
            // 
            this.cntValorDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Valor";
            this.cntValorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.cntValorDataGridViewTextBoxColumn.Name = "cntValorDataGridViewTextBoxColumn";
            this.cntValorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntTipoDataGridViewTextBoxColumn
            // 
            this.cntTipoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Tipo";
            this.cntTipoDataGridViewTextBoxColumn.HeaderText = "Tipo Conta";
            this.cntTipoDataGridViewTextBoxColumn.Name = "cntTipoDataGridViewTextBoxColumn";
            this.cntTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDescricaoCartaoDataGridViewTextBoxColumn
            // 
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DescricaoCartao";
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.HeaderText = "Nome Cartão";
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.Name = "cntDescricaoCartaoDataGridViewTextBoxColumn";
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDataEmissaoDataGridViewTextBoxColumn
            // 
            this.cntDataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataEmissao";
            this.cntDataEmissaoDataGridViewTextBoxColumn.HeaderText = "Data Emissao";
            this.cntDataEmissaoDataGridViewTextBoxColumn.Name = "cntDataEmissaoDataGridViewTextBoxColumn";
            this.cntDataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntLancamentoIncertoDataGridViewTextBoxColumn
            // 
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_LancamentoIncerto";
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.HeaderText = "Confirmar Lançamento";
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.Name = "cntLancamentoIncertoDataGridViewTextBoxColumn";
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntQtdTotalParcelaDataGridViewTextBoxColumn
            // 
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.DataPropertyName = "Cnt_QtdTotalParcela";
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.HeaderText = "Qtd Parcelas";
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.Name = "cntQtdTotalParcelaDataGridViewTextBoxColumn";
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntParcelaAtualDataGridViewTextBoxColumn
            // 
            this.cntParcelaAtualDataGridViewTextBoxColumn.DataPropertyName = "Cnt_ParcelaAtual";
            this.cntParcelaAtualDataGridViewTextBoxColumn.HeaderText = "Parcela Atual";
            this.cntParcelaAtualDataGridViewTextBoxColumn.Name = "cntParcelaAtualDataGridViewTextBoxColumn";
            this.cntParcelaAtualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDataLancamentoDataGridViewTextBoxColumn
            // 
            this.cntDataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataLancamento";
            this.cntDataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data Lancamento";
            this.cntDataLancamentoDataGridViewTextBoxColumn.Name = "cntDataLancamentoDataGridViewTextBoxColumn";
            this.cntDataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDataPagamentoDataGridViewTextBoxColumn
            // 
            this.cntDataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataPagamento";
            this.cntDataPagamentoDataGridViewTextBoxColumn.HeaderText = "Data Pagamento";
            this.cntDataPagamentoDataGridViewTextBoxColumn.Name = "cntDataPagamentoDataGridViewTextBoxColumn";
            this.cntDataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntObservacaoDataGridViewTextBoxColumn
            // 
            this.cntObservacaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Observacao";
            this.cntObservacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.cntObservacaoDataGridViewTextBoxColumn.Name = "cntObservacaoDataGridViewTextBoxColumn";
            this.cntObservacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntFormaPgtoDataGridViewTextBoxColumn
            // 
            this.cntFormaPgtoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_FormaPgto";
            this.cntFormaPgtoDataGridViewTextBoxColumn.HeaderText = "Forma Pagamento";
            this.cntFormaPgtoDataGridViewTextBoxColumn.Name = "cntFormaPgtoDataGridViewTextBoxColumn";
            this.cntFormaPgtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDuracaoDataGridViewTextBoxColumn
            // 
            this.cntDuracaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Duracao";
            this.cntDuracaoDataGridViewTextBoxColumn.HeaderText = "Duração da Conta";
            this.cntDuracaoDataGridViewTextBoxColumn.Name = "cntDuracaoDataGridViewTextBoxColumn";
            this.cntDuracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblContaBindingSource1
            // 
            this.tblContaBindingSource1.DataMember = "tblConta";
            this.tblContaBindingSource1.DataSource = this.aCGestorDataSetBindingSource;
            // 
            // tblCartaoBindingSource
            // 
            this.tblCartaoBindingSource.DataMember = "tblCartao";
            this.tblCartaoBindingSource.DataSource = this.aCGestorDataSetBindingSource;
            // 
            // tblCartaoTableAdapter
            // 
            this.tblCartaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmContasLancadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ListagemContas);
            this.KeyPreview = true;
            this.Name = "frmContasLancadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Lançadas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContasLancadas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListagemContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource aCGestorDataSetBindingSource;
        private ACGestorDataSet aCGestorDataSet;
        private System.Windows.Forms.BindingSource tblContaBindingSource;
        private ACGestorDataSetTableAdapters.tblContaTableAdapter tblContaTableAdapter;
        private System.Windows.Forms.DataGridView dgv_ListagemContas;
        private System.Windows.Forms.BindingSource tblCartaoBindingSource;
        private ACGestorDataSetTableAdapters.tblCartaoTableAdapter tblCartaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntNomeContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDescricaoCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntLancamentoIncertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntQtdTotalParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntParcelaAtualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntObservacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntFormaPgtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDuracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblContaBindingSource1;
    }
}