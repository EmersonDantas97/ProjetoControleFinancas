using System;
using System.Data;
using System.Data.SqlClient;


namespace Gestor.Classes
{
    public class SQLServer
    {
        public string stringConexao;
        public SqlConnection Conexao;

        public SQLServer()
        {
            try
            {
                stringConexao = "Data Source=DESKTOP-7TLUK34;Initial Catalog=ACGestor;Persist Security Info=True;User ID=sa;Password=bispo1997";
                Conexao = new SqlConnection(stringConexao);
                Conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();

            try
            {
                var myCommand = new SqlCommand(SQL, Conexao);
                myCommand.CommandTimeout = 0;

                var myReader = myCommand.ExecuteReader();

                dt.Load(myReader);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, Conexao);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            Conexao.Close();
        }
    }
}
