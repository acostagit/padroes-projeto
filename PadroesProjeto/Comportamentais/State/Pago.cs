using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.State
{
    public class Pago: IState
    {
        private Pedido pedido;

        public Pago(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void CancelarPedido()
        {
            this.pedido.SetEstadoAtual(this.pedido.Cancelado);
        }

        public void DespacharPedido()
        {
            this.pedido.SetEstadoAtual(this.pedido.Enviado);
        }

        //nao tem
        public void SucessoAoPagar()
        {
            Console.WriteLine("Operacao nao suportada. Pedido já foi PAGO. {0}", this.pedido.EstadoAtual);
        }
    }
}
