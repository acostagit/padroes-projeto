using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Estruturais.Adapter.Gateway
{
    public class PagFacil: IGateway
    {
        public float Valor { get; set; }
        public int Parcelas { get; set; }
        public string NumeroCartao { get; set; }
        public string Cvv { get; set; }

        //Define o valor do pagamento.
        public void SetValor(float valor)
        {
            this.Valor = valor;
        }

        //Define a quantidade de parcelas.
        public void SetParcelas(int parcelas)
        {
            this.Parcelas = parcelas;
        }
        //Define o número do cartão.
        public void SetNumeroCartao(string numeroCartao)
        {
            this.NumeroCartao = numeroCartao;
        }
        //Define o CVV do cartão.
        public void SetCVV(string cvv)
        {
            this.Cvv = cvv;
        }
        //Verifica se o cartão é válido.
        public bool ValidarCartao()
        {
            if (this.NumeroCartao != "" && this.Cvv != "" && this.Cvv.Length == 3)
                return true;

            return false;
        }
        //Realiza o pagamento propriamente dito.
        public bool RealizarPagamento()
        {
            Console.WriteLine("Pagamento realizado via PagFacil ");

            return true;
        }

    }
}
