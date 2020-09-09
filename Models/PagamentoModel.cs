using System;
namespace NetCoreAngular.Models
{
    public class PagamentoModel
    {
        public PagamentoModel(int id, string nomeTitular, string numeroCartao, string dataExpiracao, string cvv)
        {
            Id = id;
            NomeTitular = nomeTitular;
            NumeroCartao = numeroCartao;
            DataExpiracao = dataExpiracao;
            CVV = cvv;
        }

        public int Id { get; private set; }
        public string NomeTitular { get; private set; }
        public string NumeroCartao { get; private set; }
        public string DataExpiracao { get; private set; }
        public string CVV { get; private set; }
    }
}