using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Template_Method.Gateway_Pagamento
{
    public class Gateway
    {
        public bool Cobrar(double valor)
        {
            if (valor > 0)
            {
                return true;
            }

            return false;
        }
    }
}
