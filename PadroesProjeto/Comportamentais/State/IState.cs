using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.State
{
    public interface IState
    {
        public void SucessoAoPagar();

        public void CancelarPedido();

        public void DespacharPedido();
    }
}
