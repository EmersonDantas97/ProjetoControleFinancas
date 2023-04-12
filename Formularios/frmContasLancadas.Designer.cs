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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasLancadas));
            this.tblContaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCGestorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCGestorDataSet = new Gestor.ACGestorDataSet();
            this.tblContaTableAdapter = new Gestor.ACGestorDataSetTableAdapters.tblContaTableAdapter();
            this.dgv_ListagemContas = new System.Windows.Forms.DataGridView();
            this.tblContaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCartaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCartaoTableAdapter = new Gestor.ACGestorDataSetTableAdapters.tblCartaoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_RotuloPagas = new System.Windows.Forms.Label();
            this.lbl_Pagas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_APagar = new System.Windows.Forms.Label();
            this.lbl_RotuloAPagar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.lbl_RotuloSaldo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cntIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntNomeContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntObservacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntFormaPgtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDescricaoCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDuracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntParcelaAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntDataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntLancamentoIncertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListagemContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartaoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            resources.ApplyResources(this.dgv_ListagemContas, "dgv_ListagemContas");
            this.dgv_ListagemContas.AutoGenerateColumns = false;
            this.dgv_ListagemContas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ListagemContas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ListagemContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ListagemContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListagemContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cntIdDataGridViewTextBoxColumn,
            this.cntNomeContaDataGridViewTextBoxColumn,
            this.cntObservacaoDataGridViewTextBoxColumn,
            this.cntValorDataGridViewTextBoxColumn,
            this.cntTipoDataGridViewTextBoxColumn,
            this.cntFormaPgtoDataGridViewTextBoxColumn,
            this.cntDescricaoCartaoDataGridViewTextBoxColumn,
            this.cntDuracaoDataGridViewTextBoxColumn,
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn,
            this.cntParcelaAtualDataGridViewTextBoxColumn,
            this.cntDataEmissaoDataGridViewTextBoxColumn,
            this.cntDataLancamentoDataGridViewTextBoxColumn,
            this.cntDataPagamentoDataGridViewTextBoxColumn,
            this.cntLancamentoIncertoDataGridViewTextBoxColumn,
            this.Paga});
            this.dgv_ListagemContas.DataSource = this.tblContaBindingSource1;
            this.dgv_ListagemContas.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_ListagemContas.Name = "dgv_ListagemContas";
            this.dgv_ListagemContas.ReadOnly = true;
            this.dgv_ListagemContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListagemContas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ListagemContas_CellFormatting);
            this.dgv_ListagemContas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_ListagemContas_MouseClick);
            this.dgv_ListagemContas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_ListagemContas_MouseDoubleClick);
            this.dgv_ListagemContas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_ListagemContas_MouseDown);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lbl_Pagas);
            this.panel1.Controls.Add(this.lbl_RotuloPagas);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // lbl_RotuloPagas
            // 
            resources.ApplyResources(this.lbl_RotuloPagas, "lbl_RotuloPagas");
            this.lbl_RotuloPagas.Name = "lbl_RotuloPagas";
            // 
            // lbl_Pagas
            // 
            resources.ApplyResources(this.lbl_Pagas, "lbl_Pagas");
            this.lbl_Pagas.Name = "lbl_Pagas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.lbl_APagar);
            this.panel3.Controls.Add(this.lbl_RotuloAPagar);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbl_APagar
            // 
            resources.ApplyResources(this.lbl_APagar, "lbl_APagar");
            this.lbl_APagar.Name = "lbl_APagar";
            // 
            // lbl_RotuloAPagar
            // 
            resources.ApplyResources(this.lbl_RotuloAPagar, "lbl_RotuloAPagar");
            this.lbl_RotuloAPagar.Name = "lbl_RotuloAPagar";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.lbl_Saldo);
            this.panel4.Controls.Add(this.lbl_RotuloSaldo);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lbl_Saldo
            // 
            resources.ApplyResources(this.lbl_Saldo, "lbl_Saldo");
            this.lbl_Saldo.Name = "lbl_Saldo";
            // 
            // lbl_RotuloSaldo
            // 
            resources.ApplyResources(this.lbl_RotuloSaldo, "lbl_RotuloSaldo");
            this.lbl_RotuloSaldo.Name = "lbl_RotuloSaldo";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // cntIdDataGridViewTextBoxColumn
            // 
            this.cntIdDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Id";
            resources.ApplyResources(this.cntIdDataGridViewTextBoxColumn, "cntIdDataGridViewTextBoxColumn");
            this.cntIdDataGridViewTextBoxColumn.Name = "cntIdDataGridViewTextBoxColumn";
            this.cntIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntNomeContaDataGridViewTextBoxColumn
            // 
            this.cntNomeContaDataGridViewTextBoxColumn.DataPropertyName = "Cnt_NomeConta";
            resources.ApplyResources(this.cntNomeContaDataGridViewTextBoxColumn, "cntNomeContaDataGridViewTextBoxColumn");
            this.cntNomeContaDataGridViewTextBoxColumn.Name = "cntNomeContaDataGridViewTextBoxColumn";
            this.cntNomeContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntObservacaoDataGridViewTextBoxColumn
            // 
            this.cntObservacaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Observacao";
            resources.ApplyResources(this.cntObservacaoDataGridViewTextBoxColumn, "cntObservacaoDataGridViewTextBoxColumn");
            this.cntObservacaoDataGridViewTextBoxColumn.Name = "cntObservacaoDataGridViewTextBoxColumn";
            this.cntObservacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntValorDataGridViewTextBoxColumn
            // 
            this.cntValorDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Valor";
            resources.ApplyResources(this.cntValorDataGridViewTextBoxColumn, "cntValorDataGridViewTextBoxColumn");
            this.cntValorDataGridViewTextBoxColumn.Name = "cntValorDataGridViewTextBoxColumn";
            this.cntValorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntTipoDataGridViewTextBoxColumn
            // 
            this.cntTipoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Tipo";
            resources.ApplyResources(this.cntTipoDataGridViewTextBoxColumn, "cntTipoDataGridViewTextBoxColumn");
            this.cntTipoDataGridViewTextBoxColumn.Name = "cntTipoDataGridViewTextBoxColumn";
            this.cntTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntFormaPgtoDataGridViewTextBoxColumn
            // 
            this.cntFormaPgtoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_FormaPgto";
            resources.ApplyResources(this.cntFormaPgtoDataGridViewTextBoxColumn, "cntFormaPgtoDataGridViewTextBoxColumn");
            this.cntFormaPgtoDataGridViewTextBoxColumn.Name = "cntFormaPgtoDataGridViewTextBoxColumn";
            this.cntFormaPgtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDescricaoCartaoDataGridViewTextBoxColumn
            // 
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DescricaoCartao";
            resources.ApplyResources(this.cntDescricaoCartaoDataGridViewTextBoxColumn, "cntDescricaoCartaoDataGridViewTextBoxColumn");
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.Name = "cntDescricaoCartaoDataGridViewTextBoxColumn";
            this.cntDescricaoCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDuracaoDataGridViewTextBoxColumn
            // 
            this.cntDuracaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_Duracao";
            resources.ApplyResources(this.cntDuracaoDataGridViewTextBoxColumn, "cntDuracaoDataGridViewTextBoxColumn");
            this.cntDuracaoDataGridViewTextBoxColumn.Name = "cntDuracaoDataGridViewTextBoxColumn";
            this.cntDuracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntQtdTotalParcelaDataGridViewTextBoxColumn
            // 
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.DataPropertyName = "Cnt_QtdTotalParcela";
            resources.ApplyResources(this.cntQtdTotalParcelaDataGridViewTextBoxColumn, "cntQtdTotalParcelaDataGridViewTextBoxColumn");
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.Name = "cntQtdTotalParcelaDataGridViewTextBoxColumn";
            this.cntQtdTotalParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntParcelaAtualDataGridViewTextBoxColumn
            // 
            this.cntParcelaAtualDataGridViewTextBoxColumn.DataPropertyName = "Cnt_ParcelaAtual";
            resources.ApplyResources(this.cntParcelaAtualDataGridViewTextBoxColumn, "cntParcelaAtualDataGridViewTextBoxColumn");
            this.cntParcelaAtualDataGridViewTextBoxColumn.Name = "cntParcelaAtualDataGridViewTextBoxColumn";
            this.cntParcelaAtualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDataEmissaoDataGridViewTextBoxColumn
            // 
            this.cntDataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataEmissao";
            resources.ApplyResources(this.cntDataEmissaoDataGridViewTextBoxColumn, "cntDataEmissaoDataGridViewTextBoxColumn");
            this.cntDataEmissaoDataGridViewTextBoxColumn.Name = "cntDataEmissaoDataGridViewTextBoxColumn";
            this.cntDataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDataLancamentoDataGridViewTextBoxColumn
            // 
            this.cntDataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataLancamento";
            resources.ApplyResources(this.cntDataLancamentoDataGridViewTextBoxColumn, "cntDataLancamentoDataGridViewTextBoxColumn");
            this.cntDataLancamentoDataGridViewTextBoxColumn.Name = "cntDataLancamentoDataGridViewTextBoxColumn";
            this.cntDataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntDataPagamentoDataGridViewTextBoxColumn
            // 
            this.cntDataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_DataPagamento";
            resources.ApplyResources(this.cntDataPagamentoDataGridViewTextBoxColumn, "cntDataPagamentoDataGridViewTextBoxColumn");
            this.cntDataPagamentoDataGridViewTextBoxColumn.Name = "cntDataPagamentoDataGridViewTextBoxColumn";
            this.cntDataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntLancamentoIncertoDataGridViewTextBoxColumn
            // 
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.DataPropertyName = "Cnt_LancamentoIncerto";
            resources.ApplyResources(this.cntLancamentoIncertoDataGridViewTextBoxColumn, "cntLancamentoIncertoDataGridViewTextBoxColumn");
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.Name = "cntLancamentoIncertoDataGridViewTextBoxColumn";
            this.cntLancamentoIncertoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Paga
            // 
            this.Paga.DataPropertyName = "Cnt_Status";
            resources.ApplyResources(this.Paga, "Paga");
            this.Paga.Name = "Paga";
            this.Paga.ReadOnly = true;
            // 
            // frmContasLancadas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_ListagemContas);
            this.KeyPreview = true;
            this.Name = "frmContasLancadas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContasLancadas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListagemContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartaoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.BindingSource tblContaBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_Pagas;
        private System.Windows.Forms.Label lbl_RotuloPagas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_APagar;
        private System.Windows.Forms.Label lbl_RotuloAPagar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_RotuloSaldo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntNomeContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntObservacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntFormaPgtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDescricaoCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDuracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntQtdTotalParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntParcelaAtualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntLancamentoIncertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paga;
    }
}