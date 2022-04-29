using PadroesProjeto.Comportamentais.Template_Method.Gateway_Pagamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Template_Method
{
    public class PagamentoDebito: Pagamento
    {
        public PagamentoDebito(Gateway gateway, double valor)
               : base(gateway, valor)
        {

        }

        public override double CalcularTaxa()
        {
            return 4;
        }

        public override double CalcularDesconto()
        {
            return this.Valor * 0.05;
        }
    }
}
