using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.State
{
    public class Cancelado: IState
    {
        private Pedido pedido;

        public Cancelado(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void CancelarPedido()
        {
            Console.WriteLine("Operacao nao suportada. Pedido já se encontra CANCELADO. {0}", this.pedido.EstadoAtual);
        }

        public void DespacharPedido()
        {
            Console.WriteLine("Operacao nao suportada. Pedido se encontra CANCELADO. {0}", this.pedido.EstadoAtual);
        }

        public void SucessoAoPagar()
        {
            Console.WriteLine("Operacao nao suportada. Pedido se encontra CANCELADO. {0}", this.pedido.EstadoAtual);
        }
    }
}
