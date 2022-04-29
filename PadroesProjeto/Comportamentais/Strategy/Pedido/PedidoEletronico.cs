using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Pedido
{
    public class PedidoEletronico: Pedido
    {
        public string Descricao { get; set; }
        public PedidoEletronico()
        {
            this.Descricao = "Eletrônicos";
        }

        //public override double CalculaFreteComum()
        //{
        //    return this.Valor = this.Valor * (0.05);
        //}

        //public override double CalculaFreteExpresso()
        //{
        //    return this.Valor = this.Valor * (0.10);
        //}
    }
}
