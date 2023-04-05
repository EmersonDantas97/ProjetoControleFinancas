using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor.Formularios
{
    public partial class frmCadastroTipoConta : Form
    {
        public frmCadastroTipoConta()
        {
            InitializeComponent();
            CriandoDicasFerramentas();
        }
        private void CriandoDicasFerramentas()
        {
            // Instanciando classe ToolTip para ser criadas as dicas de ferramentas.
            ToolTip dicaFerramenta = new ToolTip();

            // Criando dica de ferramenta para o botão.
            dicaFerramenta.SetToolTip(btnSalvar, "Tecla de atalho F1");
            dicaFerramenta.SetToolTip(btnExcluir, "Tecla de atalho F2");
            dicaFerramenta.SetToolTip(btnNovo, "Tecla de atalho F3");
        }
    }
}
