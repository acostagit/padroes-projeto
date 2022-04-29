using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Estruturais.Adapter
{
    public interface IGateway
    {
        //Define o valor do pagamento.
        public void SetValor(float valor);
        //Define a quantidade de parcelas.
        public void SetParcelas(int parcelas);
        //Define o número do cartão.
        public void SetNumeroCartao(string numeroCartao);
        //Define o CVV do cartão.
        public void SetCVV(string cvv);
        //Verifica se o cartão é válido.
        public bool ValidarCartao();
        //Realiza o pagamento propriamente dito.
        public bool RealizarPagamento();

    }
}
