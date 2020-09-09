using System;
namespace NetCoreAngular.Models
{
    public class CartaoModel
    {
        public CartaoModel(int id, string nomeTitular, string numeroCartao, string dataExpiracao, string cvv)
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

        public void DefinirId(int id)
        {
            Id = id;
        }

        public void AtualizarDados(string nomeTitular, string numeroCartao, string dataExpiracao, string cvv)
        {
            NomeTitular = nomeTitular;
            NumeroCartao = numeroCartao;
            DataExpiracao = dataExpiracao;
            CVV = cvv;
        }
    }
}