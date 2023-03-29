using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
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
                    string SQL = $"INSERT INTO tblCadastroCartao (cdc_NomeCartao) values ('{this.Nome}');";
                    db.SQLCommand(SQL);
                    db.Close();
                }
            }

            public static DataTable TrazerCartoesCadastrados()
            {
                DataTable dt;
                SQLServer db = new SQLServer();
                string SQL = $"SELECT cdc_id as Codigo, cdc_NomeCartao as Cartao FROM tblCadastroCartao WHERE cdc_Status = 'A';";
                dt = db.SQLQuery(SQL);
                db.Close();

                return dt;
            }

            public static void ExcluirRegistro(string id)
            {
                // TODO: INSERIR VALIDAÇÃO ANTES DE EXCLUIR PARA VERIFICAR SE NÃO VAI TENTAR EXCLUIR REGISTRO INEXISTENTE
                string SQL = $"UPDATE tblCadastroCartao SET cdc_Status = 'E' WHERE cdc_Id = '{id}';";
                SQLServer db = new SQLServer();
                db.SQLCommand(SQL);
                db.Close();
            }
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

    }
}
