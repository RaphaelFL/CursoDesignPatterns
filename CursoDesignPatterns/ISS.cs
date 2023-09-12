using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    internal class ISS : Imposto
    {
        public ISS(Imposto outroImposto): base (outroImposto) { }
        public ISS(): base() { }
        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
