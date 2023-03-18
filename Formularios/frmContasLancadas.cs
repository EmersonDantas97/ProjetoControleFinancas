using System;
using System.Windows.Forms;
using System.Drawing;

namespace Gestor
{
    public partial class frmContasLancadas : Form
    {
        public frmContasLancadas()
        {
            InitializeComponent();

            CarregaGrid();
        }

        public void CarregaGrid()
        {
            dgv_ListagemContas.DataSource = null; // Limpando Grid para evitar ser inseridas linhas duplicadas. 
            dgv_ListagemContas.DataSource = Conta.Unit.BuscarContas(); // Carregando contas na grid.
        }
        private void dgv_ListagemContas_MouseDown(object sender, MouseEventArgs e) // Neste evento será inserido o código relacionado as funções do clique com o botão direito do mouse na grid.
        {
            // Teste lógico para ver se o botão direito do mouse foi clicado.
            if (e.Button == MouseButtons.Right)
            {
                // Criando menu de contexto, que é a caixa onde é incluido as opções de clique de mouse. Por sí só ele não funciona, teremos que inserir as opção nele. 
                var MenuContexto = new ContextMenuStrip();

                // Criando os itens que serão inseridos dentro do menu de contexto. 
                var OpcaoPagar = DesenhaItemMenu("Pagar Conta", "");
                var OpcaoExcluir = DesenhaItemMenu("Excluir Conta", "");
                var OpcaoEditar = DesenhaItemMenu("Editar Conta", "");
                var OpcaoMudarMes = DesenhaItemMenu("Mudar mês da Conta", "");

                // Adicionando os itens criados ao menu.
                MenuContexto.Items.Add(OpcaoPagar);
                MenuContexto.Items.Add(OpcaoExcluir);
                MenuContexto.Items.Add(OpcaoEditar);
                MenuContexto.Items.Add(OpcaoMudarMes);

                // Exibindo o menu de contexto já com os itens inseridos. 
                MenuContexto.Show(this, new Point(e.X, e.Y));

                // Criando o evento do clique na opção, dentro da caixa de contexto. 
                OpcaoPagar.Click += new EventHandler(OpcaoPagar_Click);
                OpcaoExcluir.Click += new EventHandler(OpcaoExcluir_Click);
                OpcaoEditar.Click += new EventHandler(OpcaoEditar_Click);
                OpcaoMudarMes.Click += new EventHandler(OpcaoMudarMes_Click);
            }
        }
        void OpcaoPagar_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Opção foi paga!");
        }
        void OpcaoExcluir_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Opção excluida!");
        }
        void OpcaoEditar_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Opção editada!");
        }
        void OpcaoMudarMes_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Opção foi mudada de mês!");
        }

        /// <summary>
        /// Este método é responsável por criar as opções que serão inseridas no menu de contexto.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="nomeImagem"></param>
        /// <returns></returns>
        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vdicaferramenta = new ToolStripMenuItem();
            vdicaferramenta.Text = text;
            return vdicaferramenta;
        }
        private void frmContasLancadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void dgv_ListagemContas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dgv_ListagemContas.Select();
            }
        }

        private void dgv_ListagemContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_ListagemContas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgv_ListagemContas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow Linha = new DataGridViewRow();
            Linha = dgv_ListagemContas.SelectedRows[0];           
            string id = Linha.Cells[0].Value.ToString();
            MessageBox.Show(id.ToString());
        }
    }
}

