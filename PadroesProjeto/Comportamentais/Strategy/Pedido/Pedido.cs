using PadroesProjeto.Comportamentais.Strategy.Frete;
using PadroesProjeto.Comportamentais.Strategy.Juros;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Strategy.Pedido
{
    public abstract class Pedido
    {
        public double Valor { get; set; }

        public IFrete tipoFrete { get; set; }
        public IJuros tipoJuros { get; set; }

        //Calcula o frete de acordo com a classe Frete recebida.
        public double CalculaFrete(IFrete frete)
        {
            return frete.Calcula(this.Valor);
        }

        public double CalculaJuros(IJuros juros)
        {
            return juros.Calcula(this.Valor);
        }

        //A implementação destes métodos passa a ser responsabilidade das subclasses
        //abstract public double CalculaFreteComum();
        //abstract public double CalculaFreteExpresso();


        //abstract public double CalculaFreteComum();
        //{            
        //    return this.Valor = this.Valor * (0.05);
        //}

        //abstract public double CalculaFreteExpresso();
        //{
        //    return this.Valor = this.Valor * (0.10);
        //}
    }
}
