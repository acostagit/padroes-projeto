using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Estruturais.Adapter.Gateway
{
    public class TopPagamentos
    {
        public float Valor { get; set; }
        public int Parcelas { get; set; }
        public string NumeroCartao { get; set; }
        public string Cvv { get; set; }

        public void SetValorTotal(float valor)
        {
            this.Valor = valor;
        }

        public void SetQuantidadeParcelas(int parcelas)
        {
            this.Parcelas = parcelas;
        }

        public void SetCartao(string numeroCartao, string cvv)
        {
            this.NumeroCartao = numeroCartao;
            this.Cvv = cvv;
        }

        public bool RealizarPagamento()
        {
            Console.WriteLine("Pagamento realizado via TopPagamentosAdapter ");
            return true;
        }
    }
}
