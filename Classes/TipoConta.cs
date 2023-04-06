using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gestor.Classes
{
    public class TipoConta
    {
        public class Unit
        {
            string Nome;

            public Unit()
            {
            }

            public void CadastrarTipoConta(string tipoConta)
            {
                this.Nome = tipoConta;

                if (this.Nome == "")
                {
                    MessageBox.Show("Necessário fornecer o nome para cadastrar o cartão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLServer db = new SQLServer();
                    string SQL = $"INSERT INTO tblTipoConta (cct_TipoConta, cct_Status) values ('{this.Nome}', 'A');";
                    db.SQLCommand(SQL);
                    db.Close();
                }
            }

            public static DataTable TrazerTiposCadastrados()
            {
                DataTable dt;
                SQLServer db = new SQLServer();
                string SQL = $"SELECT cct_id as Codigo, cct_TipoConta as Tipo FROM tblTipoConta WHERE cct_Status = 'A';";
                dt = db.SQLQuery(SQL);
                db.Close();

                return dt;
            }

            public static void ExcluirRegistro(string id)
            {
                // TODO: INSERIR VALIDAÇÃO ANTES DE EXCLUIR PARA VERIFICAR SE NÃO VAI TENTAR EXCLUIR REGISTRO INEXISTENTE
                string SQL = $"UPDATE tblTipoConta SET cct_Status = 'E' WHERE cct_Id = '{id}';";
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
