using PadroesProjeto.Comportamentais.Template_Method.Gateway_Pagamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Template_Method
{
    public class PagamentoCredito: Pagamento
    {
        public PagamentoCredito(Gateway gateway, double valor)
            :base(gateway, valor)
        {
            
        }

        public override double CalcularTaxa()
        {
            return this.Valor * 0.05;
        }

        public override double CalcularDesconto()
        {
            if (this.Valor > 300)
            {
                return this.Valor * 0.02;
            }

            return 0;
        }
    }
}
