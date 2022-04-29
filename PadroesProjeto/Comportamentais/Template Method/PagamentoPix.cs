using PadroesProjeto.Comportamentais.Template_Method.Gateway_Pagamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Template_Method
{
    public class PagamentoPix : Pagamento
    {
        public PagamentoPix(Gateway gateway, double valor)
            : base(gateway, valor)
        {

        }
        public override double CalcularDesconto()
        {
            return Valor + 20;
        }

        public override double CalcularTaxa()
        {
            return 100;
        }
        //public override double CalcularTaxaPixSuper()
        //{
        //    return this.Valor + 77;
        //}
    }
}
