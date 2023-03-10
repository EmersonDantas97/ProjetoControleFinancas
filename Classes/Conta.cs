using Gestor.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Gestor
{
    public class Conta
    {
        public class Unit
        {
            public string Id { get; set; }
            public string DataLancamento { get; set; }
            public string NomeConta { get; set; }
            public string ValorConta { get; set; }
            public string TipoConta { get; set; }
            public string DataEmissao { get; set; }
            public string DataPagar { get; set; }
            public string Observacao { get; set; }
            public int ConfirmarDepois { get; set; }
            public int Duracao { get; set; }
            public int TipoPagamento { get; set; }
            public int QtdParcelas { get; set; }
            public int ParcelaAtual { get; set; }
            public string Cartao { get; set; }

            public Unit()
            {
            }

            public static Unit Buscar(string id)
            {
                Conta.Unit c = new Conta.Unit();

                string SelectSQL = $"SELECT * FROM tblConta WHERE Cnt_Id = {id};";
                var db = new SQLServer();

                var dt = db.SQLQuery(SelectSQL);

                var dr = dt.Rows[0];

                c.Id = dr["Cnt_Id"].ToString();
                c.DataEmissao = dr["Cnt_DataEmissao"].ToString();
                c.ValorConta = dr["Cnt_Valor"].ToString();
                c.NomeConta = dr["Cnt_NomeConta"].ToString();
                c.QtdParcelas = Convert.ToInt32(dr["Cnt_QtdTotalParcela"].ToString());
                c.ConfirmarDepois = Convert.ToInt32(dr["Cnt_LancamentoIncerto"].ToString());
                c.ParcelaAtual = Convert.ToInt32(dr["Cnt_ParcelaAtual"].ToString());
                c.TipoPagamento = Convert.ToInt32(dr["Cnt_FormaPgto"].ToString());
                c.Duracao = Convert.ToInt32(dr["Cnt_Duracao"].ToString());
                c.TipoConta = dr["Cnt_Tipo"].ToString();
                c.DataLancamento = dr["Cnt_DataLancamento"].ToString();
                c.DataPagar = dr["Cnt_DataPagamento"].ToString();
                c.Observacao = dr["Cnt_Observacao"].ToString();
                c.Cartao = dr["Cnt_DescricaoCartao"].ToString();

                return c;
            }

            public void Salvar()
            {
                var db = new SQLServer();
                var retorno = db.SQLCommand(this.ToInsert());
                db.Close();
            }

            public static string UltimoCodigo()
            {
                string codigo;
                string SQL = "SELECT MAX(Cnt_Id)+1 as ultcod from tblConta";

                SQLServer db = new SQLServer();

                var dt = db.SQLQuery(SQL);
                var dr = dt.Rows[0];

                codigo = dr["ultcod"].ToString();

                return codigo;

            }

            private string ToInsert()
            {
                string SQL;

                SQL = "insert into dbo.tblConta (Cnt_Id" +
                    ", Cnt_DataEmissao" +
                    ", Cnt_LancamentoIncerto" +
                    ", Cnt_Valor" +
                    ", Cnt_NomeConta" +
                    ", Cnt_QtdTotalParcela" +
                    ", Cnt_ParcelaAtual" +
                    ", Cnt_Tipo" +
                    ", Cnt_DataLancamento" +
                    ", Cnt_DataPagamento" +
                    ", Cnt_Observacao" +
                    ", Cnt_FormaPgto" +
                    ", Cnt_Duracao" +
                    $", Cnt_DescricaoCartao) values ('{this.Id}'" +
                    $", '{Util.FormataData(this.DataEmissao, "yyyy-MM-dd")}'" +
                    $", {this.ConfirmarDepois}" +
                    $", {this.ValorConta}" +
                    $", '{this.NomeConta}'" +
                    $", {this.QtdParcelas}" +
                    $", {this.ParcelaAtual}" +
                    $", '{this.TipoConta}'" +
                    $", '{Util.FormataData(this.DataLancamento, "yyyy-MM-dd  HH:mm:ss.fff")}'" +
                    $", '{Util.FormataData(this.DataPagar, "yyyy-MM-dd")}'" +
                    $", '{this.Observacao}'" +
                    $", {this.TipoPagamento}" +
                    $", {this.Duracao}" +
                    $", '{this.Cartao}');";

                return SQL;
            }

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

    }
}
