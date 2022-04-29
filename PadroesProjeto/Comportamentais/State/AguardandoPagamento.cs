using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.State
{
    public class AguardandoPagamento : IState
    {
        //private IEstadoPagamento estadoAtual;
        private Pedido pedido;

        public AguardandoPagamento(Pedido pedido)
        {
            this.pedido = pedido;
        }
      
        public void CancelarPedido()
        {
            this.pedido.SetEstadoAtual(this.pedido.Cancelado);
        }

        public void DespacharPedido()
        {
            Console.WriteLine("Operacao nao suportada. Pedido nao foi PAGO. {0}", this.pedido.EstadoAtual);

        }

        public void SucessoAoPagar()
        {
            this.pedido.SetEstadoAtual(this.pedido.Pago);
            Console.WriteLine("Pedido foi ..." + this.pedido.EstadoAtual);
        }

       
    }
}
