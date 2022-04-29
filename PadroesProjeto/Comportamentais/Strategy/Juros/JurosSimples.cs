using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Juros
{
    public class JurosSimples : IJuros
    {
        public double Calcula(double valor)
        {
            return valor * 0.18;
        }
    }
}
