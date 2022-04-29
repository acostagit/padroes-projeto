using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.State
{
    //Sofrera mudancas usando Design Patterns - State
    public class Pedido
    {
        public IState Aguardando { get; set; }
        public IState Pago { get; set; }
        public IState Cancelado { get; set; }
        public IState Enviado { get; set; }
        public IState EstadoAtual { get; set; }


        public Pedido()
        {
            ////this.estadoAtual = (int)EPagamento.AGUARDANDO_PAGAMENTO;

            this.Aguardando = new AguardandoPagamento(this);
            this.Pago = new Pago(this);
            this.Cancelado = new Cancelado(this);
            this.Enviado= new Enviado(this);


            this.EstadoAtual = this.Aguardando;
        }
        

        public void RealizarPagamento()
        {
            this.EstadoAtual.SucessoAoPagar();

            ////if (estadoAtual == (int)EPagamento.AGUARDANDO_PAGAMENTO)
            ////{
            ////    this.estadoAtual = (int)EPagamento.PAGO;
            ////    Console.WriteLine("Pedido  foi PAGO. {0}", this.estadoAtual);

            ////}
            ////else
            ////{
            ////    Console.WriteLine("Pedido nao estah AGUARDANDO PAGAMENTO.{0}", this.estadoAtual);
            ////}
        }

        public void CancelarPedido()
        {
            this.EstadoAtual.CancelarPedido();

            ////if (estadoAtual == (int)EPagamento.PAGO)
            ////{
            ////    this.estadoAtual = (int)EPagamento.CANCELADO;
            ////}
            ////else if(estadoAtual == (int)EPagamento.PAGO)
            ////{
            ////    this.estadoAtual = (int)EPagamento.CANCELADO;
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Pedido nao pode ser CAENCELADO.{0}", this.estadoAtual);
            ////}
        }

        public void DespacharPedido()
        {
            try
            {
                this.EstadoAtual.DespacharPedido();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO:");
            }
            

            //if (estadoAtual == (int)EPagamento.PAGO)
            //{
            //    this.estadoAtual = (int)EPagamento.ENVIADO;
            //    Console.WriteLine("Pedido ENVIADO com sucesso. {0}", this.estadoAtual);
            //}
            //else
            //{
            //    Console.WriteLine("Pedido nao pode ser ENVIADO. {0}", this.estadoAtual);
            //}
        }

        public void SetEstadoAtual(IState estado)
        {
            this.EstadoAtual = estado;
        }
    }
}
