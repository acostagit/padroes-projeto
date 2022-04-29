using PadroesProjeto.Comportamentais.Template_Method.Gateway_Pagamento;

namespace PadroesProjeto.Comportamentais.Template_Method
{
    public class PagamentoDinheiro : Pagamento
    {

        public PagamentoDinheiro(Gateway gateway, double valor)
              : base(gateway, valor)
        {

        }

        public override double CalcularDesconto()
        {
            return this.Valor * 0.1;
        }
    }
}
