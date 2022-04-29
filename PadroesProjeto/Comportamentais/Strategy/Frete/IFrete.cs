using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Frete
{
    public interface IFrete
    {
        //Recebe o valor do pedido que é utilizado no calculo do frete.
        public double Calcula(double valor);
    }
}
