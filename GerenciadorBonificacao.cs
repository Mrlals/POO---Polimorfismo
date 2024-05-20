using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; set; } = 0;
        public void TotalizadorBonificacao(Funcionario funcionario)//Polimorfismo para tratar a classe base funcionário
        {
            this.TotalBonificacao += funcionario.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Secretario secretario)//Bonificação do Funcionário + do Secretário
        {
            this.TotalBonificacao += secretario.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Gerente gerente)//Bonificação do Funcionário + do Gerente
        {
            this.TotalBonificacao += gerente.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Diretor diretor)//Bonificação do Funcionário + diretor
        {
            this.TotalBonificacao += diretor.CalcularBonificacao();
        }
    }
}