using PadroesProjeto.Comportamentais.Template_Method.Gateway_Pagamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Comportamentais.Template_Method
{
   abstract public  class Pagamento
    {
        public double Valor { get; set; }
        public Gateway Gateway { get; set; }

        public Pagamento(Gateway gateway, double valor)
        {
            this.Valor = valor;
            this.Gateway = gateway;
        }

        abstract public double CalcularDesconto();       
        public virtual double CalcularTaxa()
        {
            return 0;
        }

        //Executa somente numa classe especifica.
        //abstract public double CalcularTaxaPixSuper();
        

        public double RealizarCobranca()
        {
            var resultado = (this.Valor + this.CalcularTaxa()) - this.CalcularDesconto();

           var retorno =  this.Gateway.Cobrar(resultado);

            Console.WriteLine("Crédito: {0}  Valor: {1} Taxa: {2} Desconto: {3} Pix:{4} ", this.Valor, this.CalcularTaxa(), this.CalcularDesconto(), resultado);

            return resultado;
        }
    }
}
