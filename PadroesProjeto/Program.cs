using PadroesProjeto.Comportamentais.Observer;
using PadroesProjeto.Comportamentais.State;
using PadroesProjeto.Comportamentais.Strategy.Frete;
using PadroesProjeto.Comportamentais.Strategy.Juros;
using PadroesProjeto.Comportamentais.Strategy.Pedido;
using PadroesProjeto.Comportamentais.Template_Method;
using PadroesProjeto.Comportamentais.Template_Method.Gateway_Pagamento;
using PadroesProjeto.Estruturais.Adapter;
using PadroesProjeto.Estruturais.Adapter.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadroesProjeto
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");


            int fatorial = 1;
            int numero = 5; // 5! =  5*4*3*2*1 = 120
            for (int n = 1; n <= numero; n++)
            {
                fatorial *= n;
                Console.WriteLine("Fatorial (" + n + ")= " + fatorial);
            }
            Console.WriteLine("-------------------------------------------------------------------------");


            //for (int n = 1; n <= 10; n++)
            //{
            //    fatorial*=n;
            //    Console.WriteLine(n+" fatorial= "+fatorial);
            //}

            //Escreva o código em Linq para executar ordenação descendente por Sobrenome de
            //uma lista da classe acima(List<Pessoa>)


            IList<Pessoa> pessoas = Pessoa.CriaListaPessoas();

            //var objetosEmOrdem = (from o in objetos
            //                      orderby o.Desc
            //                      select s);
            Parallel.ForEach(pessoas, pessoa =>
            {
                Pessoa.ImprimePessoas(pessoa);
            });

            Console.WriteLine("--------------------------------------------------------------");
            pessoas = pessoas.OrderByDescending(x => x.Sobrenome).ToList();
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Sobrenome + " , " + pessoa.Nome + "--" + pessoa.DataNascimento);
            }

            ////var blogs = context.Pessoas
            ////                .Include(b => b.Empresa)
            ////               .ToList();

            //// // Padrao Estrutural - Adapter
            //// IGateway gateway = new PagFacilAdapter();
            //// PagFacilAdapter pagFacilAdapter = new PagFacilAdapter();

            //// TopPagamentos topPagamentos = new TopPagamentos();
            //// TopPagamentosAdapter topPagamentosAdapter = new TopPagamentosAdapter(topPagamentos);


            //// var cobranca = new Cobranca(pagFacilAdapter);
            //// cobranca.SetValor(100);
            //// cobranca.SetParcelas(3);
            //// cobranca.SetNumeroCartao("1234567890");
            //// cobranca.SetCVV("955");
            ////if( cobranca.RealizarPagamento())
            ////     Console.WriteLine("Pagamento realizado com sucesso");


            //Padrao State --------------------------
            ////PadroesProjeto.Comportamentais.State.Pedido pedido = new Comportamentais.State.Pedido();

            //////pedido.EstadoAtual = (int)EPagamento.AGUARDANDO_PAGAMENTO;

            ////pedido.RealizarPagamento();
            //////pedido.CancelarPedido();
            ////pedido.RealizarPagamento();
            //// pedido.DespacharPedido();



            //Padrao Observer ----------------------- XXX
            //////Newsletter newsletter = new Newsletter();
            //////List<IObserver> observers = new List<IObserver>();

            //////List<string> mensagens = new List<string>();

            //////Cliente cliente = new Cliente("Jose Cliente", "jose@cliente.com");
            //////Fornecedor fornecedor = new Fornecedor("Jurema Funcionaria", "jurema@fornecedor.com");
            ////////Funcionario funcionario = new Funcionario("Maria Funcionaria", "maria@funcionaria.com", newsletter);

            //////observers.Add(cliente);
            //////observers.Add(fornecedor);
            ////////observers.Add(funcionario);
            //////newsletter.Observers = observers;

            ////////newsletter.Mensagens.Add("Primeira Mensagem");
            //////mensagens.Add("Primeira Mensagem");
            //////newsletter.Mensagens = mensagens;

            //////newsletter.AdicionaMensagem(observers);
            //////Console.WriteLine("--------------------------------------------------------");

            //////newsletter.RemoveObserver(observers[1]);

            //Stragegy ----------------------------------------------- ok
            ////Gateway gateway = new Gateway();
            ////var valor = 1000;

            ////var pagamentoCredito = new PagamentoCredito(gateway, valor);
            ////pagamentoCredito.RealizarCobranca();

            ////var pagamentoDebito = new PagamentoDebito(gateway, valor);
            ////pagamentoDebito.RealizarCobranca();

            ////var pagamentoDinheiro =  new PagamentoDinheiro(gateway, 1000);
            ////pagamentoDinheiro.RealizarCobranca();

            ////var pagamentoPix = new PagamentoPix(gateway, 1000);
            ////pagamentoPix.RealizarCobranca();

            //credito.CalcularTaxa();
            //credito.CalcularDesconto();
            // Console.WriteLine(gateway.Cobrar(credito));


            //TEMPLATE METHOD
            ////Gateway gateway = new Gateway(); 
            ////PagamentoCredito credito = new PagamentoCredito(gateway, 1000);
            ////PagamentoDebito debito = new PagamentoDebito(gateway, 1000);
            ////PagamentoDinheiro dinheiro = new PagamentoDinheiro(gateway, 1000);
            ///
            ////var vCredito = credito.RealizarCobranca();
            ////var vDebito = debito.RealizarCobranca();
            ////var vDinheiro = dinheiro.RealizarCobranca();
            ////Console.WriteLine("Valor Credito|Débito| {0} {1} {2} |", vCredito, vDebito, vDinheiro);

            //STRATEGY - OK
            ////var tipoFrete = new FreteComum();
            ////var tipoJuros = new JurosSimples();

            ////var pedido = new PedidoEletronico();
            ////pedido.Valor = 200;
            ////pedido.tipoFrete = tipoFrete;
            ////pedido.tipoJuros = tipoJuros;

            ////var valorFrete = pedido.CalculaFrete(pedido.tipoFrete);
            ////Console.WriteLine("Tipo de Frete: Produto: Valor: {0}, {1}, {2} ", pedido.tipoFrete.ToString(),  pedido.Descricao,  valorFrete);

            ////var valorJuros = pedido.CalculaJuros(tipoJuros);
            ////Console.WriteLine("Valor do Juros: {0} {1}", pedido.tipoJuros,  valorJuros);

            ////Console.WriteLine("-------------------------------------------------------------------------");


            //var pedido = new PedidoEletronico();
            //pedido.Valor = 100;

            //var freteComum = pedido.CalculaFreteComum();
            //Console.WriteLine("Frete Comum : {0}, {1} ", pedido.Descricao,  freteComum);
            //pedido.Valor = 100;
            //var freteExpresso = pedido.CalculaFreteExpresso();
            //Console.WriteLine("Frete Expresso : {0}, {1} ", pedido.Descricao, freteExpresso);

            ////var pedido = new PedidoMoveis();
            ////var freteComum = pedido.CalculaFreteComum();
            ////Console.WriteLine("Frete Comum : {0}, {1} ", pedido.Descricao, freteComum);
            ////pedido.Valor = 100;
            ////var freteExpresso = pedido.CalculaFreteExpresso();
            ////Console.WriteLine("Frete Expresso : {0}, {1} ", pedido.Descricao, freteExpresso); ;
        }


    }

    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Empresa Empresa { get; set; }


        public static double FatorialRecursivo(int numero)
        {
            if (numero == 1)
                return 1;
            else
                return numero * FatorialRecursivo(numero - 1);
        }


      

    public static IList<Pessoa> CriaListaPessoas()
    {

        var pessoas = new List<Pessoa>()
            {
                new Pessoa  {
                    Id = 100,
                    Nome = "Dalva",
                    Sobrenome = "Olveira",
                    DataNascimento = new DateTime().AddYears(30),
                    Empresa = new Empresa()
                    {
                        Id = 1,
                        Nome = "XTZ Cell"
                    }
                },
                new Pessoa  {
                    Id = 100,
                    Nome = "Maria",
                    Sobrenome = "Waza",
                    DataNascimento = new DateTime().AddYears(30),
                    Empresa = new Empresa()
                    {
                        Id = 1,
                        Nome = "Atech"
                    }
                },
                new Pessoa
                {
                    Id = 200,
                    Nome = "Rosa",
                    Sobrenome = "Silva",
                    DataNascimento = new DateTime().AddYears(52),
                    Empresa = new Empresa()
                    {
                        Id = 2,
                        Nome = "Brasil Aço"
                    }
                },
                new Pessoa
                {
                    Id = 300,
                    Nome = "Walter",
                    Sobrenome = "Zelo",
                    DataNascimento = new DateTime().AddYears(20),
                    Empresa = new Empresa()
                    {
                        Id = 50,
                        Nome = "Samsung"
                    }
                },
                  new Pessoa
                {
                    Id = 300,
                    Nome = "Amarilia",
                    Sobrenome = "Ferreira",
                    DataNascimento = new DateTime().AddYears(25),
                    Empresa = new Empresa()
                    {
                        Id = 88,
                        Nome = "Vallet"
                    }
                },
                     new Pessoa
                {
                    Id = 400,
                    Nome = "Amarilia",
                    Sobrenome = "Augustina",
                    DataNascimento = new DateTime().AddYears(25),
                    Empresa = new Empresa()
                    {
                        Id = 89,
                        Nome = "Empresa ABC"
                    }
                }

            };
        return pessoas;
    }

    public static void ImprimePessoas(Pessoa pessoa)
    {
        ToString(pessoa);
    }

    public static void ToString(Pessoa pessoa)
    {
        Console.WriteLine(pessoa.Sobrenome + ", " + pessoa.Nome + "--" + pessoa.DataNascimento);
        Console.WriteLine(pessoa.Empresa.Id + ", " + pessoa.Empresa.Nome);
        Console.WriteLine("*********************************************");
    }
}





}
