using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Frete
{
    public class FreteComum : IFrete
    {
        public double Calcula(double valor)
        {
            return valor * 0.05;
        }
    }
}
