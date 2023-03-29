using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestor.Classes
{
    public class Cartao
    {

        public class Unit
        {
            public string Nome;
            public string Codigo;

            public Unit() { }

            public void CadastrarCartao(string nomeCartao)
            {
                this.Nome = nomeCartao;

                if (this.Nome == "")
                {
                    MessageBox.Show("Necessário fornecer o nome para cadastrar o cartão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLServer db = new SQLServer();
                    string SQL = $"INSERT INTO tblCadastroCartao values ('{this.Nome}');";
                    db.SQLCommand(SQL);
                    db.Close();
                }
            }
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

    }
}
