using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados / finalizados nao recebem desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Ocamento ja esta finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Ocamento ja esta finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Ocamento ja esta finalizado");
        }

    }
}
