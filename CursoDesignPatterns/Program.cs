using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadoraDeImpostos caculador = new CalculadoraDeImpostos();

            caculador.RealizaCal(orcamento, icms);

            Console.ReadKey();

            Imposto iss2 = new ISS(new ICMS());

            double valor = iss2.Calcular(orcamento);
            
            Console.WriteLine(valor);

            Console.ReadKey();


            //Desconto

            CalculadorDeDescontos calculadora = new CalculadorDeDescontos();

            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogao", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));


            double desconto = calculadora.Calcular(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();

            Orcamento reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();

            Console.ReadKey();

            //Nota Fiscal

            IList<ItemDaNota> itens = new List<ItemDaNota>();
            double valorTotal = 0;

            foreach(ItemDaNota item in itens)
            {
                valorTotal += item.Valor;
            }

            double impostos = valorTotal * 0.05;

            NotaFiscal nf = new NotaFiscal("Razão", "cpn", DateTime.Now, valorTotal, impostos, itens, "obs qualquer");

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();

            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.ParaEmpresa("Caelum ensino")
            .ComCnpj("23.456.789/0001-12")
            .comItem(new ItemDaNota("item 1", 100.0))
            .comItem(new ItemDaNota("item 2", 200.0))
            .NaDataAtual()
            .ComObservacoes("uma obs");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new EnviadorDeSms());
            criador.AdicionaAcao(new NotaFiscalDao());


            NotaFiscal nft = criador.Constroi();

            Console.WriteLine(nft.ValorBruto);
            Console.WriteLine(nft.Impostos);

            Console.ReadKey();
        }
    }
}