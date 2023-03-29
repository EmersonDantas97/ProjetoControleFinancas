namespace Gestor
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasLançadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasToolStripMenuItem,
            this.recebimentoToolStripMenuItem,
            this.cartãoToolStripMenuItem,
            this.tipoContaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Image = global::Gestor.Properties.Resources.conta;
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.contasToolStripMenuItem.Text = "&Contas";
            this.contasToolStripMenuItem.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
            // 
            // recebimentoToolStripMenuItem
            // 
            this.recebimentoToolStripMenuItem.Image = global::Gestor.Properties.Resources.Recebimento;
            this.recebimentoToolStripMenuItem.Name = "recebimentoToolStripMenuItem";
            this.recebimentoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.recebimentoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.recebimentoToolStripMenuItem.Text = "&Recebimento";
            this.recebimentoToolStripMenuItem.Click += new System.EventHandler(this.recebimentoToolStripMenuItem_Click);
            // 
            // cartãoToolStripMenuItem
            // 
            this.cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
            this.cartãoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cartãoToolStripMenuItem.Text = "Cartão";
            this.cartãoToolStripMenuItem.Click += new System.EventHandler(this.cartãoToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasLançadasToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.relatoriosToolStripMenuItem.Text = "Visualização";
            // 
            // contasLançadasToolStripMenuItem
            // 
            this.contasLançadasToolStripMenuItem.Image = global::Gestor.Properties.Resources.Visualizacao;
            this.contasLançadasToolStripMenuItem.Name = "contasLançadasToolStripMenuItem";
            this.contasLançadasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.contasLançadasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.contasLançadasToolStripMenuItem.Text = "Contas &Lançadas";
            this.contasLançadasToolStripMenuItem.Click += new System.EventHandler(this.contasLançadasToolStripMenuItem_Click);
            // 
            // tipoContaToolStripMenuItem
            // 
            this.tipoContaToolStripMenuItem.Name = "tipoContaToolStripMenuItem";
            this.tipoContaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tipoContaToolStripMenuItem.Text = "Tipo conta";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenuPrincipal_KeyDown);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasLançadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoContaToolStripMenuItem;
    }
}