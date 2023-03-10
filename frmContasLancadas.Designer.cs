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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aCGestorDataSet = new Gestor.ACGestorDataSet();
            this.aCGestorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblContaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblContaTableAdapter = new Gestor.ACGestorDataSetTableAdapters.tblContaTableAdapter();
            this.cntIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntLancamentoIncertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntNomeContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntParcelaAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntObservacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntFormaPgtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDuracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDescricaoCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cntIdDataGridViewTextBoxColumn,
            this.cntDataEmissaoDataGridViewTextBoxColumn,
            this.cntLancamentoIncertoDataGridViewTextBoxColumn,
            this.cntValorDataGridViewTextBoxColumn,
            this.cntNomeContaDataGridViewTextBoxColumn,
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn,
            this.cntParcelaAtualDataGridViewTextBoxColumn,
            this.cntTipoDataGridViewTextBoxColumn,
            this.cntDataLancamentoDataGridViewTextBoxColumn,
            this.cntDataPagamentoDataGridViewTextBoxColumn,
            this.cntObservacaoDataGridViewTextBoxColumn,
            this.cntFormaPgtoDataGridViewTextBoxColumn,
            this.cntDuracaoDataGridViewTextBoxColumn,
            this.cntDescricaoCartaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblContaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // aCGestorDataSet
            // 
            this.aCGestorDataSet.DataSetName = "ACGestorDataSet";
            this.aCGestorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCGestorDataSetBindingSource
            // 
            this.aCGestorDataSetBindingSource.DataSource = this.aCGestorDataSet;
            this.aCGestorDataSetBindingSource.Position = 0;
            // 
            // tblContaBindingSource
            // 
            this.tblContaBindingSource.DataMember = "tblConta";
            this.tblContaBindingSource.DataSource = this.aCGestorDataSetBindingSource;
            // 
            // tblContaTableAdapter
            // 
            this.tblContaTableAdapter.ClearBeforeFill = true;
            // 
            // cntIdDataGridViewTextBoxColumn
            // 
            this.cntIdDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Id";
            this.cntIdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cntIdDataGridViewTextBoxColumn.Name = "cntIdDataGridViewTextBoxColumn";
            // 
            // cntDataEmissaoDataGridViewTextBoxColumn
            // 
            this.cntDataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataEmissao";
            this.cntDataEmissaoDataGridViewTextBoxColumn.HeaderText = "Data Emissão";
            this.cntDataEmissaoDataGridViewTextBoxColumn.Name = "cntDataEmissaoDataGridViewTextBoxColumn";
            // 
            // cntLancamentoIncertoDataGridViewTextBoxColumn
            // 
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_LancamentoIncerto";
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.HeaderText = "Confirmar Lançamento";
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.Name = "cntLancamentoIncertoDataGridViewTextBoxColumn";
            // 
            // cntValorDataGridViewTextBoxColumn
            // 
            this.cntValorDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Valor";
            this.cntValorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.cntValorDataGridViewTextBoxColumn.Name = "cntValorDataGridViewTextBoxColumn";
            // 
            // cntNomeContaDataGridViewTextBoxColumn
            // 
            this.cntNomeContaDataGridViewTextBoxColumn.DataPropertyName = "Cnt_NomeConta";
            this.cntNomeContaDataGridViewTextBoxColumn.HeaderText = "Nome da Conta";
            this.cntNomeContaDataGridViewTextBoxColumn.Name = "cntNomeContaDataGridViewTextBoxColumn";
            // 
            // cntQtdTotalParcelaDataGridViewTextBoxColumn
            // 
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.DataPropertyName = "Cnt_QtdTotalParcela";
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.HeaderText = "Qtd Parcelas";
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.Name = "cntQtdTotalParcelaDataGridViewTextBoxColumn";
            // 
            // cntParcelaAtualDataGridViewTextBoxColumn
            // 
            this.cntParcelaAtualDataGridViewTextBoxColumn.DataPropertyName = "Cnt_ParcelaAtual";
            this.cntParcelaAtualDataGridViewTextBoxColumn.HeaderText = "Parcela Atual";
            this.cntParcelaAtualDataGridViewTextBoxColumn.Name = "cntParcelaAtualDataGridViewTextBoxColumn";
            // 
            // cntTipoDataGridViewTextBoxColumn
            // 
            this.cntTipoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Tipo";
            this.cntTipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Conta";
            this.cntTipoDataGridViewTextBoxColumn.Name = "cntTipoDataGridViewTextBoxColumn";
            // 
            // cntDataLancamentoDataGridViewTextBoxColumn
            // 
            this.cntDataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataLancamento";
            this.cntDataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data Lançamento";
            this.cntDataLancamentoDataGridViewTextBoxColumn.Name = "cntDataLancamentoDataGridViewTextBoxColumn";
            // 
            // cntDataPagamentoDataGridViewTextBoxColumn
            // 
            this.cntDataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataPagamento";
            this.cntDataPagamentoDataGridViewTextBoxColumn.HeaderText = "Data Pagamento";
            this.cntDataPagamentoDataGridViewTextBoxColumn.Name = "cntDataPagamentoDataGridViewTextBoxColumn";
            // 
            // cntObservacaoDataGridViewTextBoxColumn
            // 
            this.cntObservacaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Observacao";
            this.cntObservacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.cntObservacaoDataGridViewTextBoxColumn.Name = "cntObservacaoDataGridViewTextBoxColumn";
            // 
            // cntFormaPgtoDataGridViewTextBoxColumn
            // 
            this.cntFormaPgtoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_FormaPgto";
            this.cntFormaPgtoDataGridViewTextBoxColumn.HeaderText = "Forma de Pagamento";
            this.cntFormaPgtoDataGridViewTextBoxColumn.Name = "cntFormaPgtoDataGridViewTextBoxColumn";
            // 
            // cntDuracaoDataGridViewTextBoxColumn
            // 
            this.cntDuracaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Duracao";
            this.cntDuracaoDataGridViewTextBoxColumn.HeaderText = "Duração";
            this.cntDuracaoDataGridViewTextBoxColumn.Name = "cntDuracaoDataGridViewTextBoxColumn";
            // 
            // cntDescricaoCartaoDataGridViewTextBoxColumn
            // 
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DescricaoCartao";
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.HeaderText = "Cartão";
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.Name = "cntDescricaoCartaoDataGridViewTextBoxColumn";
            // 
            // frmContasLancadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmContasLancadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Lançadas";
            this.Load += new System.EventHandler(this.frmContasLancadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aCGestorDataSetBindingSource;
        private ACGestorDataSet aCGestorDataSet;
        private System.Windows.Forms.BindingSource tblContaBindingSource;
        private ACGestorDataSetTableAdapters.tblContaTableAdapter tblContaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntLancamentoIncertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntNomeContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntQtdTotalParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntParcelaAtualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntObservacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntFormaPgtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDuracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDescricaoCartaoDataGridViewTextBoxColumn;
    }
}