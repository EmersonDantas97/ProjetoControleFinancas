using Gestor.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            public int Cartao { get; set; }

            public Unit()
            {
            }


            public void Salvar()
            {
                var db = new SQLServer();
                var retorno = db.SQLCommand(this.ToInsert());
                db.Close();
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
