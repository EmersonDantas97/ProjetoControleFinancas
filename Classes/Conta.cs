using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
            public bool ConfirmarDepois { get; set; }

            [Required(ErrorMessage = "Obrigatório ter o DURAÇÃO da conta!")]
            public int Duracao { get; set; }

            [Required(ErrorMessage = "Obrigatório ter o TIPO DE PAGAMENTO da conta!")]
            public int TipoPagamento { get; set; }
            public int QtdParcelas { get; set; }
            public int ParcelaAtual { get; set; }
            public int Cartao { get; set; }

            public void ValidaConta()
            {

            }

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }



    }
}
