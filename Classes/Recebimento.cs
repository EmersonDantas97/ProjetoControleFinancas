namespace Gestor.Classes
{
    public class Recebimento
    {
        public class Unit
        {
            public string Valor;
            public string Observacao;
            public string DataRecebimento;
            public string DataLancamento;
            public string Status = "A";
            public string Codigo;

            public Unit()
            {
            }

            // TODO: TERMINAR ROTINA DE SALVAMENTO DE RECEBIMENTO
            public void Salvar()
            {
                string SQL = InsertSQL();
                SQLServer db = new SQLServer();
                db.SQLCommand(SQL);
                db.Close();
            }

            private string InsertSQL()
            {
                string SQL;
                SQL = $"INSERT INTO tblRecebimentos ([Rcb_Valor]" +
                    $", [Rcb_Observacao]" +
                    $", [Rcb_DataRecebimento]" +
                    $", [Rcb_DataLancamento]" +
                    $", [Rcb_Status])" +
                    $" values ('{this.Valor}'" +
                    $", '{this.Observacao}'" +
                    $", '{this.DataRecebimento}'" +
                    $", '{this.DataLancamento}'" +
                    $", '{this.Status}');";
                return SQL;
            }
        }

        public class List
        {

        }
    }
}
