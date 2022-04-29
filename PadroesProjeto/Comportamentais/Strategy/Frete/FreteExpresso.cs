using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Frete
{
    public class FreteExpresso : IFrete
    {
        public double Calcula(double valor)
        {
            return valor * 0.1;
        }
    }
}
