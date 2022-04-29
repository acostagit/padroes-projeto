using PadroesProjeto.Estruturais.Adapter.Gateway;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Estruturais.Adapter
{
    public class TopPagamentosAdapter : IGateway
    {
        public TopPagamentos topPagamentos { get; set; }
        private string? numeroCartao = null;
        private string? cvv = null;

        public TopPagamentosAdapter(TopPagamentos topPagamentos)
        {
            this.topPagamentos = topPagamentos;
        }

        public bool RealizarPagamento()
        {
            return this.topPagamentos.RealizarPagamento();
        }

        public void SetCVV(string cvv)
        {
            this.cvv = cvv;

            if (this.numeroCartao != null)
                this.topPagamentos.SetCartao(this.numeroCartao, this.cvv);
        }

        public void SetNumeroCartao(string numeroCartao)
        {
            this.numeroCartao = numeroCartao;

            if (this.cvv != null)
                this.topPagamentos.SetCartao(this.numeroCartao, this.cvv);
        }

        public void SetParcelas(int parcelas)
        {
            this.topPagamentos.SetQuantidadeParcelas(parcelas);
        }

        public void SetValor(float valor)
        {
            this.topPagamentos.SetValorTotal(valor);
        }

        //nao tem no TOpPagamentos
        public bool ValidarCartao()
        {
            return true;
        }
    }
}
