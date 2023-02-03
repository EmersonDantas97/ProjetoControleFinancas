using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gestor
{
    public class Conta
    {
        public class Unit
        {
            public int Id { get; set; }
            public string DataLancamento { get; set; }
            public string NomeConta { get; set; }
            public double ValorConta { get; set; }
            public string TipoConta { get; set; }
            public string DataEmissao { get; set; }
            public string DataPagar { get; set; }
            public string Observacao { get; set; }
            public bool ConfirmarDepois { get; set; }
            public int Duracao { get; set; }
            public int TipoPagamento { get; set; }
            public int QtdParcelas { get; set; }
            public int ParcelaAtual { get; set; }
            public int Cartao { get; set; }
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static string SerializarClasseUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

        public static Unit DesSerializarClasseUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }


    }
}
