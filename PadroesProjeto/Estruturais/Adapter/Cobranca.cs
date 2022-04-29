using PadroesProjeto.Estruturais.Adapter.Gateway;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Estruturais.Adapter
{
    public class Cobranca
    {
        public IGateway gateway { get; set; }

        public Cobranca(IGateway gateway)
        {
            this.gateway = gateway;
        }

        //Todos os métodos abaixo delegam responsabilidades para os métodos de $gateway.
        //Agora o parâmetro recebido é do tipo Gateway.
        public void SetGateway(IGateway gateway)
        {
            this.gateway = gateway;
            //$this->gateway = $gateway;
        }
        public void SetValor(float valor)
        {
            this.gateway.SetValor(valor);
            //$this->gateway->setValor($valor);
        }

        public void SetParcelas(int parcelas)
        {
            this.gateway.SetParcelas(parcelas);
            //$this->gateway->setParcelas($parcelas);
        }
        public void SetNumeroCartao(string numeroCartao)
        {
            this.gateway.SetNumeroCartao(numeroCartao);
        }

        public void SetCVV(string cvv)
        {
            this.gateway.SetCVV(cvv);
        }

        public bool RealizarPagamento()
        {
            //Verifica se cartão é válido
            if (this.gateway.ValidarCartao())
            {
                //retorna se o pagamento foi realizado com sucesso
                return this.gateway.RealizarPagamento();
            }
            return false;
        }

    }
}
