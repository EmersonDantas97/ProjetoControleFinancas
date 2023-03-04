using Gestor.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestor
{
    public class Conta
    {
        public class Unit
        {
            public string Id { get; set; }
            public string DataLancamento { get; set; }

            [Required(ErrorMessage = "Obrigatório ter o NOME da conta!")]
            public string NomeConta { get; set; }

            [Required(ErrorMessage = "Obrigatório ter o VALOR da conta!")]
            [Range(0.01, double.MaxValue, ErrorMessage = "VALOR DA CONTA deve ser um valor positivo e maior que zero.")]
            public double ValorConta { get; set; }

            [Required(ErrorMessage = "Obrigatório ter o TIPO da conta!")]
            public string TipoConta { get; set; }
            public string DataEmissao { get; set; }
            public string DataPagar { get; set; }
            public string Observacao { get; set; }
            public int ConfirmarDepois { get; set; }

            [Required(ErrorMessage = "Obrigatório ter o DURAÇÃO da conta!")]
            public int Duracao { get; set; }

            [Required(ErrorMessage = "Obrigatório ter o TIPO DE PAGAMENTO da conta!")]
            public int TipoPagamento { get; set; }
            public int QtdParcelas { get; set; }
            public int ParcelaAtual { get; set; }
            public int Cartao { get; set; }

            public void ValidaConta()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void SalvarConta()
            {
                try
                {
                    SQLServer bd = new SQLServer();
                    bd.SQLCommand(this.ToInsert());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            string verificaultimocodigo()
            {
                string codigo;

                return codigo;
            }

            string ToInsert()
            {
                string SQL;

                SQL = "insert into tblConta (Cnt_Id" +
                    ",Cnt_DataEmissao" +
                    ",Cnt_LancamentoIncerto" +
                    ",Cnt_Valor " +
                    ",Cnt_NomeConta" +
                    ",Cnt_QtdTotalParcela" +
                    ",Cnt_ParcelaAtual" +
                    ",Cnt_Tipo" +
                    ",Cnt_DataLancamento" +
                    ",Cnt_DataPagamento" +
                    ",Cnt_Observacao" +
                    ",Cnt_FormaPgto" +
                    ",Cnt_Duracao" +
                    $",Cnt_DescricaoCartao) values ('{this.Id}'" +
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
