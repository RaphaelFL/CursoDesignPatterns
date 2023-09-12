using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadoraDeImpostos
    {
        public void RealizaCal(Orcamento orcamento, Imposto imposto)
        {
            double icms = imposto.Calcular(orcamento);
            Console.WriteLine(icms);

            double iss = imposto.Calcular(orcamento);
            Console.WriteLine(icms);

            double icc = imposto.Calcular(orcamento);
            Console.WriteLine(icc);
        }
    }
}
