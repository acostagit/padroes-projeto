using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.State
{
    public class Enviado: IState
    {
        private Pedido pedido;

        public Enviado(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void CancelarPedido()
        {
            Console.WriteLine("Operacao nao suportada. Pedido já ENVIADO. {0}", this.pedido.EstadoAtual);
        }

        public void DespacharPedido()
        {
            Console.WriteLine("Operacao nao suportada. Pedido já ENVIADO. {0}", this.pedido.EstadoAtual);
        }

        public void SucessoAoPagar()
        {
            Console.WriteLine("Operacao nao suportada. Pedido já foi PAGO e ENVIADO. {0}", this.pedido.EstadoAtual);
        }
    }
}
