using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Juros
{
    public class JurosCompostos : IJuros
    {
        public double Calcula(double valor)
        {
            return valor * 0.30;
        }
    }
}
