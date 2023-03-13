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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecebimentos));
            this.aCGestorDataSet = new Gestor.ACGestorDataSet();
            this.tblRecebimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRecebimentosTableAdapter = new Gestor.ACGestorDataSetTableAdapters.tblRecebimentosTableAdapter();
            this.tableAdapterManager = new Gestor.ACGestorDataSetTableAdapters.TableAdapterManager();
            this.tblRecebimentosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblRecebimentosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblRecebimentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecebimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecebimentosBindingNavigator)).BeginInit();
            this.tblRecebimentosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecebimentosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aCGestorDataSet
            // 
            this.aCGestorDataSet.DataSetName = "ACGestorDataSet";
            this.aCGestorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRecebimentosBindingSource
            // 
            this.tblRecebimentosBindingSource.DataMember = "tblRecebimentos";
            this.tblRecebimentosBindingSource.DataSource = this.aCGestorDataSet;
            // 
            // tblRecebimentosTableAdapter
            // 
            this.tblRecebimentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCartaoTableAdapter = null;
            this.tableAdapterManager.tblContaTableAdapter = null;
            this.tableAdapterManager.tblRecebimentosTableAdapter = this.tblRecebimentosTableAdapter;
            this.tableAdapterManager.TesteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestor.ACGestorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblRecebimentosBindingNavigator
            // 
            this.tblRecebimentosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblRecebimentosBindingNavigator.BindingSource = this.tblRecebimentosBindingSource;
            this.tblRecebimentosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblRecebimentosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblRecebimentosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblRecebimentosBindingNavigatorSaveItem});
            this.tblRecebimentosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblRecebimentosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblRecebimentosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblRecebimentosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblRecebimentosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblRecebimentosBindingNavigator.Name = "tblRecebimentosBindingNavigator";
            this.tblRecebimentosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblRecebimentosBindingNavigator.Size = new System.Drawing.Size(444, 25);
            this.tblRecebimentosBindingNavigator.TabIndex = 0;
            this.tblRecebimentosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblRecebimentosBindingNavigatorSaveItem
            // 
            this.tblRecebimentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblRecebimentosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblRecebimentosBindingNavigatorSaveItem.Image")));
            this.tblRecebimentosBindingNavigatorSaveItem.Name = "tblRecebimentosBindingNavigatorSaveItem";
            this.tblRecebimentosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblRecebimentosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tblRecebimentosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblRecebimentosBindingNavigatorSaveItem_Click);
            // 
            // tblRecebimentosDataGridView
            // 
            this.tblRecebimentosDataGridView.AutoGenerateColumns = false;
            this.tblRecebimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRecebimentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblRecebimentosDataGridView.DataSource = this.tblRecebimentosBindingSource;
            this.tblRecebimentosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRecebimentosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tblRecebimentosDataGridView.Name = "tblRecebimentosDataGridView";
            this.tblRecebimentosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRecebimentosDataGridView.Size = new System.Drawing.Size(444, 326);
            this.tblRecebimentosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rcb_Valor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rcb_Observacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rcb_DataRecebimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Recebimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rcb_DataLancamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Lançamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmRecebimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 351);
            this.Controls.Add(this.tblRecebimentosDataGridView);
            this.Controls.Add(this.tblRecebimentosBindingNavigator);
            this.Name = "frmRecebimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recebimentos";
            this.Load += new System.EventHandler(this.frmRecebimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aCGestorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecebimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecebimentosBindingNavigator)).EndInit();
            this.tblRecebimentosBindingNavigator.ResumeLayout(false);
            this.tblRecebimentosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecebimentosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ACGestorDataSet aCGestorDataSet;
        private System.Windows.Forms.BindingSource tblRecebimentosBindingSource;
        private ACGestorDataSetTableAdapters.tblRecebimentosTableAdapter tblRecebimentosTableAdapter;
        private ACGestorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblRecebimentosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblRecebimentosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblRecebimentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}