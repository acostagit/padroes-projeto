using PadroesProjeto.Comportamentais.Strategy.Frete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Pedido
{
    public class PedidoMoveis: Pedido
    {
        public string Descricao { get; set; }
        public PedidoMoveis()
        {
            this.Descricao = "Móveis";
        }

        //public override double CalculaFrete(IFrete frete)
        //{
        //    var valor = frete.Calcula(120);

        //    return valor;
        //}

        //public override double CalculaFreteComum()
        //{
        //    return this.Valor = this.Valor * (0.05);
        //}

        //public override double CalculaFreteExpresso()
        //{
        //    Console.WriteLine("Produto não possui frete.");

        //    return 0.0;
        //}
    }
}
