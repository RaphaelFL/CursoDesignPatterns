using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscal
    {
        private IList<ItemDaNota> itens;

        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public IList<ItemDaNota> Itens { get;  set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }

        public String Observacao { get; set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime now, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacao)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens= itens;
            this.Observacao = observacao;

        }
    }

}
