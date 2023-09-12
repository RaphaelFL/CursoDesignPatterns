using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor <= 1000.00)
            {
                return orcamento.Valor * 0.05;
            }
            else if(orcamento.Valor <= 1000.00 || orcamento.Valor <= 3000.00)
            {
                return orcamento.Valor * 0.07;
            }
            else 
            {
                return orcamento.Valor * 0.08;
            }
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
