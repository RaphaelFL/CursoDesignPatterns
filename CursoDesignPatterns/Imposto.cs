using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }
        public Imposto()
        {
            this.OutroImposto = null;
        }
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null) { return 0.0; }
            return OutroImposto.Calcular(orcamento);
        }

        public abstract double Calcular(Orcamento orcamento);
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
